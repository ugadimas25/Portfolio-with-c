#pragma checksum "C:\Users\User\Downloads\arcgis-runtime-demos-dotnet-main\arcgis-runtime-demos-dotnet-main\src\OfflineWorkflowsSample\OfflineWorkflowsSample\Views\ItemPages\MapPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0213F6E5532A50C1D32EF1633E575FB32D03BBA9F5BDE328EF713EC7D58FBD00"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OfflineWorkflowSample.Views.ItemPages
{
    partial class MapPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
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
        private class MapPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMapPage_Bindings
        {
            private global::OfflineWorkflowSample.Views.ItemPages.MapPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::OfflineWorkflowSample.MapWithTools obj2;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2MapDisabled = false;
            private static bool isobj2ItemDisabled = false;

            private MapPage_obj1_BindingsTracking bindingsTracking;

            public MapPage_obj1_Bindings()
            {
                this.bindingsTracking = new MapPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 17 && columnNumber == 45)
                {
                    isobj2MapDisabled = true;
                }
                else if (lineNumber == 18 && columnNumber == 45)
                {
                    isobj2ItemDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\ItemPages\MapPage.xaml line 17
                        this.obj2 = (global::OfflineWorkflowSample.MapWithTools)target;
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

            // IMapPage_Bindings

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
                    this.dataRoot = (global::OfflineWorkflowSample.Views.ItemPages.MapPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::OfflineWorkflowSample.Views.ItemPages.MapPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::OfflineWorkflowSample.ViewModels.ItemPages.MapPageViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Map(obj.Map, phase);
                        this.Update_ViewModel_Item(obj.Item, phase);
                    }
                }
            }
            private void Update_ViewModel_Map(global::Esri.ArcGISRuntime.Mapping.Map obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_Map(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ItemPages\MapPage.xaml line 17
                    if (!isobj2MapDisabled)
                    {
                        XamlBindingSetters.Set_OfflineWorkflowSample_MapWithTools_Map(this.obj2, obj, null);
                    }
                }
            }
            private void Update_ViewModel_Item(global::OfflineWorkflowSample.ViewModels.PortalItemViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_Item(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ItemPages\MapPage.xaml line 17
                    if (!isobj2ItemDisabled)
                    {
                        XamlBindingSetters.Set_OfflineWorkflowSample_MapWithTools_Item(this.obj2, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MapPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<MapPage_obj1_Bindings> weakRefToBindingObj; 

                public MapPage_obj1_BindingsTracking(MapPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MapPage_obj1_Bindings>(obj);
                }

                public MapPage_obj1_Bindings TryGetBindingObject()
                {
                    MapPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_ViewModel_Map(null);
                    UpdateChildListeners_ViewModel_Item(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MapPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::OfflineWorkflowSample.ViewModels.ItemPages.MapPageViewModel obj = sender as global::OfflineWorkflowSample.ViewModels.ItemPages.MapPageViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_Map(obj.Map, DATA_CHANGED);
                                bindings.Update_ViewModel_Item(obj.Item, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
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
                private global::OfflineWorkflowSample.ViewModels.ItemPages.MapPageViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::OfflineWorkflowSample.ViewModels.ItemPages.MapPageViewModel obj)
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
                public void PropertyChanged_ViewModel_Map(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MapPage_obj1_Bindings bindings = TryGetBindingObject();
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
                    MapPage_obj1_Bindings bindings = TryGetBindingObject();
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
            case 1: // Views\ItemPages\MapPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MapPage_obj1_Bindings bindings = new MapPage_obj1_Bindings();
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

