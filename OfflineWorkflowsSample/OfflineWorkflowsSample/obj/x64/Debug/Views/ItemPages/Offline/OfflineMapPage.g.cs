﻿#pragma checksum "C:\Users\User\Downloads\arcgis-runtime-demos-dotnet-main\arcgis-runtime-demos-dotnet-main\src\OfflineWorkflowsSample\OfflineWorkflowsSample\Views\ItemPages\Offline\OfflineMapPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "355AC556D71F122CAA15DDD7497339458E011C535AAF31EBA2162399E7C9E19D"
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
    partial class OfflineMapPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_FrameworkElement_DataContext(global::Windows.UI.Xaml.FrameworkElement obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.DataContext = value;
            }
            public static void Set_OfflineWorkflowSample_MapWithTools_Map(global::OfflineWorkflowSample.MapWithTools obj, global::Esri.ArcGISRuntime.Mapping.Map value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = global::Esri.ArcGISRuntime.CreateFromStringHelpers.CreateMapFromStringUrl(targetNullValue);
                }
                obj.Map = value;
            }
            public static void Set_OfflineWorkflowSample_MapWithTools_Item(global::OfflineWorkflowSample.MapWithTools obj, global::OfflineWorkflowSample.ViewModels.PortalItemViewModel value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::OfflineWorkflowSample.ViewModels.PortalItemViewModel) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::OfflineWorkflowSample.ViewModels.PortalItemViewModel), targetNullValue);
                }
                obj.Item = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class OfflineMapPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IOfflineMapPage_Bindings
        {
            private global::OfflineWorkflowSample.Views.OfflineMapPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::OfflineWorkflowsSample.DownloadMapArea.DownloadMapAreaView obj2;
            private global::OfflineWorkflowsSample.GenerateMapArea.GenerateMapAreaView obj3;
            private global::OfflineWorkflowSample.MapWithTools obj4;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2DataContextDisabled = false;
            private static bool isobj3DataContextDisabled = false;
            private static bool isobj4MapDisabled = false;
            private static bool isobj4ItemDisabled = false;

            private OfflineMapPage_obj1_BindingsTracking bindingsTracking;

            public OfflineMapPage_obj1_Bindings()
            {
                this.bindingsTracking = new OfflineMapPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 32 && columnNumber == 62)
                {
                    isobj2DataContextDisabled = true;
                }
                else if (lineNumber == 29 && columnNumber == 62)
                {
                    isobj3DataContextDisabled = true;
                }
                else if (lineNumber == 36 && columnNumber == 49)
                {
                    isobj4MapDisabled = true;
                }
                else if (lineNumber == 37 && columnNumber == 49)
                {
                    isobj4ItemDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\ItemPages\Offline\OfflineMapPage.xaml line 32
                        this.obj2 = (global::OfflineWorkflowsSample.DownloadMapArea.DownloadMapAreaView)target;
                        break;
                    case 3: // Views\ItemPages\Offline\OfflineMapPage.xaml line 29
                        this.obj3 = (global::OfflineWorkflowsSample.GenerateMapArea.GenerateMapAreaView)target;
                        break;
                    case 4: // Views\ItemPages\Offline\OfflineMapPage.xaml line 36
                        this.obj4 = (global::OfflineWorkflowSample.MapWithTools)target;
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

            // IOfflineMapPage_Bindings

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
                    this.dataRoot = (global::OfflineWorkflowSample.Views.OfflineMapPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::OfflineWorkflowSample.Views.OfflineMapPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::OfflineWorkflowSample.ViewModels.OfflineMapViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_DownloadMapAreaViewModel(obj.DownloadMapAreaViewModel, phase);
                        this.Update_ViewModel_GenerateMapAreaViewModel(obj.GenerateMapAreaViewModel, phase);
                        this.Update_ViewModel_Map(obj.Map, phase);
                        this.Update_ViewModel_Item(obj.Item, phase);
                    }
                }
            }
            private void Update_ViewModel_DownloadMapAreaViewModel(global::OfflineWorkflowsSample.DownloadMapArea.DownloadMapAreaViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_DownloadMapAreaViewModel(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ItemPages\Offline\OfflineMapPage.xaml line 32
                    if (!isobj2DataContextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_DataContext(this.obj2, obj, null);
                    }
                }
            }
            private void Update_ViewModel_GenerateMapAreaViewModel(global::OfflineWorkflowsSample.GenerateMapArea.GenerateMapAreaViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_GenerateMapAreaViewModel(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ItemPages\Offline\OfflineMapPage.xaml line 29
                    if (!isobj3DataContextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_DataContext(this.obj3, obj, null);
                    }
                }
            }
            private void Update_ViewModel_Map(global::Esri.ArcGISRuntime.Mapping.Map obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_Map(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ItemPages\Offline\OfflineMapPage.xaml line 36
                    if (!isobj4MapDisabled)
                    {
                        XamlBindingSetters.Set_OfflineWorkflowSample_MapWithTools_Map(this.obj4, obj, null);
                    }
                }
            }
            private void Update_ViewModel_Item(global::OfflineWorkflowSample.ViewModels.PortalItemViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_Item(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ItemPages\Offline\OfflineMapPage.xaml line 36
                    if (!isobj4ItemDisabled)
                    {
                        XamlBindingSetters.Set_OfflineWorkflowSample_MapWithTools_Item(this.obj4, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class OfflineMapPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<OfflineMapPage_obj1_Bindings> weakRefToBindingObj; 

                public OfflineMapPage_obj1_BindingsTracking(OfflineMapPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<OfflineMapPage_obj1_Bindings>(obj);
                }

                public OfflineMapPage_obj1_Bindings TryGetBindingObject()
                {
                    OfflineMapPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_ViewModel_DownloadMapAreaViewModel(null);
                    UpdateChildListeners_ViewModel_GenerateMapAreaViewModel(null);
                    UpdateChildListeners_ViewModel_Map(null);
                    UpdateChildListeners_ViewModel_Item(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    OfflineMapPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::OfflineWorkflowSample.ViewModels.OfflineMapViewModel obj = sender as global::OfflineWorkflowSample.ViewModels.OfflineMapViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_DownloadMapAreaViewModel(obj.DownloadMapAreaViewModel, DATA_CHANGED);
                                bindings.Update_ViewModel_GenerateMapAreaViewModel(obj.GenerateMapAreaViewModel, DATA_CHANGED);
                                bindings.Update_ViewModel_Map(obj.Map, DATA_CHANGED);
                                bindings.Update_ViewModel_Item(obj.Item, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "DownloadMapAreaViewModel":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_DownloadMapAreaViewModel(obj.DownloadMapAreaViewModel, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "GenerateMapAreaViewModel":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_GenerateMapAreaViewModel(obj.GenerateMapAreaViewModel, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Map":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Map(obj.Map, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Item":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Item(obj.Item, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::OfflineWorkflowSample.ViewModels.OfflineMapViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::OfflineWorkflowSample.ViewModels.OfflineMapViewModel obj)
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
                public void PropertyChanged_ViewModel_DownloadMapAreaViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    OfflineMapPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::OfflineWorkflowsSample.DownloadMapArea.DownloadMapAreaViewModel obj = sender as global::OfflineWorkflowsSample.DownloadMapArea.DownloadMapAreaViewModel;
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
                private global::OfflineWorkflowsSample.DownloadMapArea.DownloadMapAreaViewModel cache_ViewModel_DownloadMapAreaViewModel = null;
                public void UpdateChildListeners_ViewModel_DownloadMapAreaViewModel(global::OfflineWorkflowsSample.DownloadMapArea.DownloadMapAreaViewModel obj)
                {
                    if (obj != cache_ViewModel_DownloadMapAreaViewModel)
                    {
                        if (cache_ViewModel_DownloadMapAreaViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_DownloadMapAreaViewModel).PropertyChanged -= PropertyChanged_ViewModel_DownloadMapAreaViewModel;
                            cache_ViewModel_DownloadMapAreaViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_DownloadMapAreaViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_DownloadMapAreaViewModel;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_GenerateMapAreaViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    OfflineMapPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::OfflineWorkflowsSample.GenerateMapArea.GenerateMapAreaViewModel obj = sender as global::OfflineWorkflowsSample.GenerateMapArea.GenerateMapAreaViewModel;
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
                private global::OfflineWorkflowsSample.GenerateMapArea.GenerateMapAreaViewModel cache_ViewModel_GenerateMapAreaViewModel = null;
                public void UpdateChildListeners_ViewModel_GenerateMapAreaViewModel(global::OfflineWorkflowsSample.GenerateMapArea.GenerateMapAreaViewModel obj)
                {
                    if (obj != cache_ViewModel_GenerateMapAreaViewModel)
                    {
                        if (cache_ViewModel_GenerateMapAreaViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_GenerateMapAreaViewModel).PropertyChanged -= PropertyChanged_ViewModel_GenerateMapAreaViewModel;
                            cache_ViewModel_GenerateMapAreaViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_GenerateMapAreaViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_GenerateMapAreaViewModel;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_Map(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    OfflineMapPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Esri.ArcGISRuntime.Mapping.Map obj = sender as global::Esri.ArcGISRuntime.Mapping.Map;
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
                private global::Esri.ArcGISRuntime.Mapping.Map cache_ViewModel_Map = null;
                public void UpdateChildListeners_ViewModel_Map(global::Esri.ArcGISRuntime.Mapping.Map obj)
                {
                    if (obj != cache_ViewModel_Map)
                    {
                        if (cache_ViewModel_Map != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_Map).PropertyChanged -= PropertyChanged_ViewModel_Map;
                            cache_ViewModel_Map = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_Map = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_Map;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_Item(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    OfflineMapPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::OfflineWorkflowSample.ViewModels.PortalItemViewModel obj = sender as global::OfflineWorkflowSample.ViewModels.PortalItemViewModel;
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
                private global::OfflineWorkflowSample.ViewModels.PortalItemViewModel cache_ViewModel_Item = null;
                public void UpdateChildListeners_ViewModel_Item(global::OfflineWorkflowSample.ViewModels.PortalItemViewModel obj)
                {
                    if (obj != cache_ViewModel_Item)
                    {
                        if (cache_ViewModel_Item != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_Item).PropertyChanged -= PropertyChanged_ViewModel_Item;
                            cache_ViewModel_Item = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_Item = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_Item;
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
            case 1: // Views\ItemPages\Offline\OfflineMapPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    OfflineMapPage_obj1_Bindings bindings = new OfflineMapPage_obj1_Bindings();
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

