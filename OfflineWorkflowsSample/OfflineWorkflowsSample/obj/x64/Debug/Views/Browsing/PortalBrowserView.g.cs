﻿#pragma checksum "C:\Users\User\Downloads\arcgis-runtime-demos-dotnet-main\arcgis-runtime-demos-dotnet-main\src\OfflineWorkflowsSample\OfflineWorkflowsSample\Views\Browsing\PortalBrowserView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1D50353FD8EE38977DB02AAC438FC51FFF735D90AD276112AC4A41C328430478"
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
    partial class PortalBrowserView : 
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
            public static void Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedItem(global::Windows.UI.Xaml.Controls.Primitives.Selector obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedItem = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton obj, global::System.Nullable<global::System.Boolean> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Boolean) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Boolean), targetNullValue);
                }
                obj.IsChecked = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_SearchBox_QueryText(global::Windows.UI.Xaml.Controls.SearchBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.QueryText = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class PortalBrowserView_obj8_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPortalBrowserView_Bindings
        {
            private global::OfflineWorkflowSample.PortalFolderViewModel dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj8TextDisabled = false;

            public PortalBrowserView_obj8_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 22 && columnNumber == 44)
                {
                    isobj8TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 8: // Views\Browsing\PortalBrowserView.xaml line 22
                        this.obj8 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.TextBlock)target);
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj8.Target as global::Windows.UI.Xaml.Controls.TextBlock).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::OfflineWorkflowSample.PortalFolderViewModel) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IPortalBrowserView_Bindings

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
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::OfflineWorkflowSample.PortalFolderViewModel)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::OfflineWorkflowSample.PortalFolderViewModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Title(obj.Title, phase);
                    }
                }
            }
            private void Update_Title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Browsing\PortalBrowserView.xaml line 22
                    if (!isobj8TextDisabled)
                    {
                        if ((this.obj8.Target as global::Windows.UI.Xaml.Controls.TextBlock) != null)
                        {
                            XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text((this.obj8.Target as global::Windows.UI.Xaml.Controls.TextBlock), obj, null);
                        }
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class PortalBrowserView_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPortalBrowserView_Bindings
        {
            private global::OfflineWorkflowSample.Views.PortalBrowserView dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj2;
            private global::Windows.UI.Xaml.Controls.CheckBox obj3;
            private global::Windows.UI.Xaml.Controls.SearchBox obj4;
            private global::Windows.UI.Xaml.Controls.ComboBox obj5;
            private global::Windows.UI.Xaml.Controls.GridView obj9;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2ItemsSourceDisabled = false;
            private static bool isobj2SelectedItemDisabled = false;
            private static bool isobj3IsCheckedDisabled = false;
            private static bool isobj4QueryTextDisabled = false;
            private static bool isobj5ItemsSourceDisabled = false;
            private static bool isobj9ItemsSourceDisabled = false;

            private PortalBrowserView_obj1_BindingsTracking bindingsTracking;

            public PortalBrowserView_obj1_Bindings()
            {
                this.bindingsTracking = new PortalBrowserView_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 17 && columnNumber == 31)
                {
                    isobj2ItemsSourceDisabled = true;
                }
                else if (lineNumber == 18 && columnNumber == 31)
                {
                    isobj2SelectedItemDisabled = true;
                }
                else if (lineNumber == 27 && columnNumber == 31)
                {
                    isobj3IsCheckedDisabled = true;
                }
                else if (lineNumber == 30 && columnNumber == 32)
                {
                    isobj4QueryTextDisabled = true;
                }
                else if (lineNumber == 34 && columnNumber == 31)
                {
                    isobj5ItemsSourceDisabled = true;
                }
                else if (lineNumber == 48 && columnNumber == 23)
                {
                    isobj9ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\Browsing\PortalBrowserView.xaml line 17
                        this.obj2 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        this.bindingsTracking.RegisterTwoWayListener_2(this.obj2);
                        break;
                    case 3: // Views\Browsing\PortalBrowserView.xaml line 27
                        this.obj3 = (global::Windows.UI.Xaml.Controls.CheckBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_3(this.obj3);
                        break;
                    case 4: // Views\Browsing\PortalBrowserView.xaml line 30
                        this.obj4 = (global::Windows.UI.Xaml.Controls.SearchBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_4(this.obj4);
                        break;
                    case 5: // Views\Browsing\PortalBrowserView.xaml line 34
                        this.obj5 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    case 9: // Views\Browsing\PortalBrowserView.xaml line 48
                        this.obj9 = (global::Windows.UI.Xaml.Controls.GridView)target;
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

            // IPortalBrowserView_Bindings

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
                    this.dataRoot = (global::OfflineWorkflowSample.Views.PortalBrowserView)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::OfflineWorkflowSample.Views.PortalBrowserView obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PortalViewModel(obj.PortalViewModel, phase);
                    }
                }
            }
            private void Update_PortalViewModel(global::OfflineWorkflowSample.PortalViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_PortalViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PortalViewModel_VisibleFolders(obj.VisibleFolders, phase);
                        this.Update_PortalViewModel_SelectedFolder(obj.SelectedFolder, phase);
                        this.Update_PortalViewModel_OfflineOnlyFilter(obj.OfflineOnlyFilter, phase);
                        this.Update_PortalViewModel_SearchFilter(obj.SearchFilter, phase);
                        this.Update_PortalViewModel_AvailableTypeFilters(obj.AvailableTypeFilters, phase);
                    }
                }
            }
            private void Update_PortalViewModel_VisibleFolders(global::System.Collections.Generic.List<global::OfflineWorkflowSample.PortalFolderViewModel> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Browsing\PortalBrowserView.xaml line 17
                    if (!isobj2ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj2, obj, null);
                    }
                }
            }
            private void Update_PortalViewModel_SelectedFolder(global::OfflineWorkflowSample.PortalFolderViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_PortalViewModel_SelectedFolder(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_PortalViewModel_SelectedFolder_Items(obj.Items, phase);
                    }
                }
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Browsing\PortalBrowserView.xaml line 17
                    if (!isobj2SelectedItemDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedItem(this.obj2, obj, null);
                    }
                }
            }
            private void Update_PortalViewModel_OfflineOnlyFilter(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Browsing\PortalBrowserView.xaml line 27
                    if (!isobj3IsCheckedDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj3, obj, null);
                    }
                }
            }
            private void Update_PortalViewModel_SearchFilter(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Browsing\PortalBrowserView.xaml line 30
                    if (!isobj4QueryTextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_SearchBox_QueryText(this.obj4, obj, null);
                    }
                }
            }
            private void Update_PortalViewModel_AvailableTypeFilters(global::System.Collections.Generic.List<global::System.Nullable<global::Esri.ArcGISRuntime.Portal.PortalItemType>> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Browsing\PortalBrowserView.xaml line 34
                    if (!isobj5ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj5, obj, null);
                    }
                }
            }
            private void Update_PortalViewModel_SelectedFolder_Items(global::System.Collections.Generic.IEnumerable<global::OfflineWorkflowSample.ViewModels.PortalItemViewModel> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Browsing\PortalBrowserView.xaml line 48
                    if (!isobj9ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj9, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_2_SelectedItem()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.PortalViewModel != null)
                        {
                            this.dataRoot.PortalViewModel.SelectedFolder = (global::OfflineWorkflowSample.PortalFolderViewModel)this.obj2.SelectedItem;
                        }
                    }
                }
            }
            private void UpdateTwoWay_3_IsChecked()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.PortalViewModel != null)
                        {
                            this.dataRoot.PortalViewModel.OfflineOnlyFilter = (global::System.Boolean)this.obj3.IsChecked;
                        }
                    }
                }
            }
            private void UpdateTwoWay_4_QueryText()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.PortalViewModel != null)
                        {
                            this.dataRoot.PortalViewModel.SearchFilter = this.obj4.QueryText;
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class PortalBrowserView_obj1_BindingsTracking
            {
                private global::System.WeakReference<PortalBrowserView_obj1_Bindings> weakRefToBindingObj; 

                public PortalBrowserView_obj1_BindingsTracking(PortalBrowserView_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<PortalBrowserView_obj1_Bindings>(obj);
                }

                public PortalBrowserView_obj1_Bindings TryGetBindingObject()
                {
                    PortalBrowserView_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_PortalViewModel(null);
                    UpdateChildListeners_PortalViewModel_SelectedFolder(null);
                }

                public void PropertyChanged_PortalViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    PortalBrowserView_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::OfflineWorkflowSample.PortalViewModel obj = sender as global::OfflineWorkflowSample.PortalViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_PortalViewModel_VisibleFolders(obj.VisibleFolders, DATA_CHANGED);
                                bindings.Update_PortalViewModel_SelectedFolder(obj.SelectedFolder, DATA_CHANGED);
                                bindings.Update_PortalViewModel_OfflineOnlyFilter(obj.OfflineOnlyFilter, DATA_CHANGED);
                                bindings.Update_PortalViewModel_SearchFilter(obj.SearchFilter, DATA_CHANGED);
                                bindings.Update_PortalViewModel_AvailableTypeFilters(obj.AvailableTypeFilters, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "VisibleFolders":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PortalViewModel_VisibleFolders(obj.VisibleFolders, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedFolder":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PortalViewModel_SelectedFolder(obj.SelectedFolder, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "OfflineOnlyFilter":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PortalViewModel_OfflineOnlyFilter(obj.OfflineOnlyFilter, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SearchFilter":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PortalViewModel_SearchFilter(obj.SearchFilter, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "AvailableTypeFilters":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_PortalViewModel_AvailableTypeFilters(obj.AvailableTypeFilters, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::OfflineWorkflowSample.PortalViewModel cache_PortalViewModel = null;
                public void UpdateChildListeners_PortalViewModel(global::OfflineWorkflowSample.PortalViewModel obj)
                {
                    if (obj != cache_PortalViewModel)
                    {
                        if (cache_PortalViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_PortalViewModel).PropertyChanged -= PropertyChanged_PortalViewModel;
                            cache_PortalViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_PortalViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_PortalViewModel;
                        }
                    }
                }
                public void PropertyChanged_PortalViewModel_SelectedFolder(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    PortalBrowserView_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::OfflineWorkflowSample.PortalFolderViewModel obj = sender as global::OfflineWorkflowSample.PortalFolderViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_PortalViewModel_SelectedFolder_Items(obj.Items, DATA_CHANGED);
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
                                        bindings.Update_PortalViewModel_SelectedFolder_Items(obj.Items, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::OfflineWorkflowSample.PortalFolderViewModel cache_PortalViewModel_SelectedFolder = null;
                public void UpdateChildListeners_PortalViewModel_SelectedFolder(global::OfflineWorkflowSample.PortalFolderViewModel obj)
                {
                    if (obj != cache_PortalViewModel_SelectedFolder)
                    {
                        if (cache_PortalViewModel_SelectedFolder != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_PortalViewModel_SelectedFolder).PropertyChanged -= PropertyChanged_PortalViewModel_SelectedFolder;
                            cache_PortalViewModel_SelectedFolder = null;
                        }
                        if (obj != null)
                        {
                            cache_PortalViewModel_SelectedFolder = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_PortalViewModel_SelectedFolder;
                        }
                    }
                }
                public void RegisterTwoWayListener_2(global::Windows.UI.Xaml.Controls.ListView sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedItemProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_2_SelectedItem();
                        }
                    });
                }
                public void RegisterTwoWayListener_3(global::Windows.UI.Xaml.Controls.CheckBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_3_IsChecked();
                        }
                    });
                }
                public void RegisterTwoWayListener_4(global::Windows.UI.Xaml.Controls.SearchBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.SearchBox.QueryTextProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_4_QueryText();
                        }
                    });
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
            case 1: // Views\Browsing\PortalBrowserView.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    PortalBrowserView_obj1_Bindings bindings = new PortalBrowserView_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 8: // Views\Browsing\PortalBrowserView.xaml line 22
                {                    
                    global::Windows.UI.Xaml.Controls.TextBlock element8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                    PortalBrowserView_obj8_Bindings bindings = new PortalBrowserView_obj8_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element8.DataContext);
                    element8.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element8, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element8, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

