﻿#pragma checksum "C:\Users\User\Downloads\arcgis-runtime-demos-dotnet-main\arcgis-runtime-demos-dotnet-main\src\OfflineWorkflowsSample\OfflineWorkflowsSample\Views\Browsing\OfflineMapsView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "34A162D79E46FA9CD72C61F418C6DC77C1E165C29DCC5553D98B456A56DFCD8D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OfflineWorkflowSample.Views
{
    partial class OfflineMapsView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class OfflineMapsView_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IOfflineMapsView_Bindings
        {
            private global::OfflineWorkflowSample.Views.OfflineMapsView dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj2;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2ItemsSourceDisabled = false;

            private OfflineMapsView_obj1_BindingsTracking bindingsTracking;

            public OfflineMapsView_obj1_Bindings()
            {
                this.bindingsTracking = new OfflineMapsView_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 10 && columnNumber == 15)
                {
                    isobj2ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\Browsing\OfflineMapsView.xaml line 10
                        this.obj2 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IOfflineMapsView_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::OfflineWorkflowSample.Views.OfflineMapsView)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::OfflineWorkflowSample.Views.OfflineMapsView obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::OfflineWorkflowsSample.MainViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_LocalContentViewModel(obj.LocalContentViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel_LocalContentViewModel(global::OfflineWorkflowSample.ViewModels.LocalContentViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_LocalContentViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_LocalContentViewModel_Items(obj.Items, phase);
                    }
                }
            }
            private void Update_ViewModel_LocalContentViewModel_Items(global::System.Collections.ObjectModel.ObservableCollection<global::OfflineWorkflowSample.ViewModels.PortalItemViewModel> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_LocalContentViewModel_Items(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Browsing\OfflineMapsView.xaml line 10
                    if (!isobj2ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj2, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class OfflineMapsView_obj1_BindingsTracking
            {
                private global::System.WeakReference<OfflineMapsView_obj1_Bindings> weakRefToBindingObj; 

                public OfflineMapsView_obj1_BindingsTracking(OfflineMapsView_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<OfflineMapsView_obj1_Bindings>(obj);
                }

                public OfflineMapsView_obj1_Bindings TryGetBindingObject()
                {
                    OfflineMapsView_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                    UpdateChildListeners_ViewModel_LocalContentViewModel(null);
                    UpdateChildListeners_ViewModel_LocalContentViewModel_Items(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    OfflineMapsView_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::OfflineWorkflowsSample.MainViewModel obj = sender as global::OfflineWorkflowsSample.MainViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_LocalContentViewModel(obj.LocalContentViewModel, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "LocalContentViewModel":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_LocalContentViewModel(obj.LocalContentViewModel, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::OfflineWorkflowsSample.MainViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::OfflineWorkflowsSample.MainViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_LocalContentViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    OfflineMapsView_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::OfflineWorkflowSample.ViewModels.LocalContentViewModel obj = sender as global::OfflineWorkflowSample.ViewModels.LocalContentViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_LocalContentViewModel_Items(obj.Items, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Items":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_LocalContentViewModel_Items(obj.Items, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::OfflineWorkflowSample.ViewModels.LocalContentViewModel cache_ViewModel_LocalContentViewModel = null;
                public void UpdateChildListeners_ViewModel_LocalContentViewModel(global::OfflineWorkflowSample.ViewModels.LocalContentViewModel obj)
                {
                    if (obj != cache_ViewModel_LocalContentViewModel)
                    {
                        if (cache_ViewModel_LocalContentViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_LocalContentViewModel).PropertyChanged -= PropertyChanged_ViewModel_LocalContentViewModel;
                            cache_ViewModel_LocalContentViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_LocalContentViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_LocalContentViewModel;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_LocalContentViewModel_Items(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    OfflineMapsView_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::OfflineWorkflowSample.ViewModels.PortalItemViewModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::OfflineWorkflowSample.ViewModels.PortalItemViewModel>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_ViewModel_LocalContentViewModel_Items(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    OfflineMapsView_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::OfflineWorkflowSample.ViewModels.PortalItemViewModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::OfflineWorkflowSample.ViewModels.PortalItemViewModel>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::OfflineWorkflowSample.ViewModels.PortalItemViewModel> cache_ViewModel_LocalContentViewModel_Items = null;
                public void UpdateChildListeners_ViewModel_LocalContentViewModel_Items(global::System.Collections.ObjectModel.ObservableCollection<global::OfflineWorkflowSample.ViewModels.PortalItemViewModel> obj)
                {
                    if (obj != cache_ViewModel_LocalContentViewModel_Items)
                    {
                        if (cache_ViewModel_LocalContentViewModel_Items != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_LocalContentViewModel_Items).PropertyChanged -= PropertyChanged_ViewModel_LocalContentViewModel_Items;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_ViewModel_LocalContentViewModel_Items).CollectionChanged -= CollectionChanged_ViewModel_LocalContentViewModel_Items;
                            cache_ViewModel_LocalContentViewModel_Items = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_LocalContentViewModel_Items = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_LocalContentViewModel_Items;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_ViewModel_LocalContentViewModel_Items;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\Browsing\OfflineMapsView.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    OfflineMapsView_obj1_Bindings bindings = new OfflineMapsView_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
