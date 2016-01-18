﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;
using Quart.Msiler.Annotations;

namespace Quart.Msiler
{
    public class MyControlVM : INotifyPropertyChanged, IVsUpdateSolutionEvents, IVsSolutionEvents
    {
        ICollectionView _methodsView;
        byte[] _lastBuildMd5Hash;

        public MyControlVM() {
            this.UpdateMethodsFilter();
            InitCommon();
        }

        public void InitCommon() {
            uint solutionUpdateCookie;
            uint solutionCookie;
            Common.Instance.Build.AdviseUpdateSolutionEvents(this, out solutionUpdateCookie);
            Common.Instance.Solution.AdviseSolutionEvents(this, out solutionCookie);
            Common.Instance.SolutionUpdateCookie = solutionUpdateCookie;
            Common.Instance.SolutionCookie = solutionCookie;
        }

        private bool _hideNopInstructions;
        public bool HideNopInstructions {
            get { return _hideNopInstructions; }
            set
            {
                if (value == _hideNopInstructions) {
                    return;
                }
                _hideNopInstructions = value;
                OnPropertyChanged();
            }
        }

        private string _instructionsString;
        public string InstructionsString {
            get { return _instructionsString; }
            set
            {
                if (Equals(value, _instructionsString)) {
                    return;
                }
                _instructionsString = value;
                OnPropertyChanged();
            }
        }

        private string _filterString = "";
        public string FilterString {
            get { return _filterString; }
            set
            {
                if (value == _filterString) {
                    return;
                }
                _filterString = value;
                this._methodsView.Refresh();
                OnPropertyChanged();
            }
        }

        private ObservableCollection<MsilMethodEntity> _methods
            = new ObservableCollection<MsilMethodEntity>();
        public ObservableCollection<MsilMethodEntity> Methods {
            get { return _methods; }
            set
            {
                if (value == null || Equals(value, _methods)) {
                    return;
                }
                _methods = new ObservableCollection<MsilMethodEntity>(value);
                OnPropertyChanged();
                try {
                    if (this.SelectedMethod == null) {
                        return;
                    }
                    string selectedName = this.SelectedMethod.MethodData.FullName;
                    this.SelectedMethod = value.FirstOrDefault(x => x.MethodData.FullName == selectedName);
                } catch {
                    // ignored
                }
            }
        }

        private MsilMethodEntity _selectedMethod;
        public MsilMethodEntity SelectedMethod {
            get { return _selectedMethod; }
            set
            {
                if (value == null || value.Equals(_selectedMethod)) {
                    return;
                }
                _selectedMethod = value;
                this.InstructionsString = value.InstructionsStr;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public int OnAfterCloseSolution(object pUnkReserved) {
            this.Methods.Clear(); // empty collection
            return VSConstants.S_OK;
        }

        public int UpdateSolution_Done(int fSucceeded, int fModified, int fCancelCommand) {
            if (!MyToolWindow.IsVisible || fSucceeded != 1) {
                return VSConstants.S_OK;
            }
            Debug.Write("Compiled, generating IL code...");
            string assemblyFile = Helpers.GetOutputAssemblyFileName();
            try {
                var hash = Helpers.ComputeMd5(assemblyFile);
                // if assembly was not changed
                if (_lastBuildMd5Hash != null && _lastBuildMd5Hash.SequenceEqual(hash)) {
                    return VSConstants.S_OK;
                }
                var msilReader = new MsilReader(assemblyFile);

                var methodsEnumerable = msilReader.EnumerateMethods();
                this.Methods = new ObservableCollection<MsilMethodEntity>(methodsEnumerable);
                _lastBuildMd5Hash = hash;
                this.UpdateMethodsFilter();
            } catch {
                this.Methods = new ObservableCollection<MsilMethodEntity>();
            }
            Debug.WriteLine("Done");
            return VSConstants.S_OK;
        }

        private void UpdateMethodsFilter() {
            this._methodsView = CollectionViewSource.GetDefaultView(this.Methods);
            this._methodsView.Filter = o => {
                if (String.IsNullOrEmpty(this.FilterString)) {
                    return true;
                }
                var obj = (MsilMethodEntity)o;
                return obj.Name.ToLower().Contains(this.FilterString.ToLower());
            };
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            var handler = PropertyChanged;
            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #region Unused handlers

        public int UpdateSolution_Begin(ref int pfCancelUpdate) {
            return VSConstants.S_OK;
        }

        public int UpdateSolution_StartUpdate(ref int pfCancelUpdate) {
            return VSConstants.S_OK;
        }

        public int UpdateSolution_Cancel() {
            return VSConstants.S_OK;
        }

        public int OnActiveProjectCfgChange(IVsHierarchy pIVsHierarchy) {
            return VSConstants.S_OK;
        }

        public int OnAfterOpenProject(IVsHierarchy pHierarchy, int fAdded) {
            return VSConstants.S_OK;
        }

        public int OnQueryCloseProject(IVsHierarchy pHierarchy, int fRemoving, ref int pfCancel) {
            return VSConstants.S_OK;
        }

        public int OnBeforeCloseProject(IVsHierarchy pHierarchy, int fRemoved) {
            return VSConstants.S_OK;
        }

        public int OnAfterLoadProject(IVsHierarchy pStubHierarchy, IVsHierarchy pRealHierarchy) {
            return VSConstants.S_OK;
        }

        public int OnQueryUnloadProject(IVsHierarchy pRealHierarchy, ref int pfCancel) {
            return VSConstants.S_OK;
        }

        public int OnBeforeUnloadProject(IVsHierarchy pRealHierarchy, IVsHierarchy pStubHierarchy) {
            return VSConstants.S_OK;
        }

        public int OnAfterOpenSolution(object pUnkReserved, int fNewSolution) {
            return VSConstants.S_OK;
        }

        public int OnQueryCloseSolution(object pUnkReserved, ref int pfCancel) {
            return VSConstants.S_OK;
        }

        public int OnBeforeCloseSolution(object pUnkReserved) {
            return VSConstants.S_OK;
        }

        #endregion
    }
}