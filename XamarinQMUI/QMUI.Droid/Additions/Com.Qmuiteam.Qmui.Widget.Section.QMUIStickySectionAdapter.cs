using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Section
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']"
    [global::Android.Runtime.Register("com/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter", DoNotGenerateAcw = true)]
    [global::Java.Interop.JavaTypeParameters(new string[] { "H extends com.qmuiteam.qmui.widget.section.QMUISection.Model<H>", "T extends com.qmuiteam.qmui.widget.section.QMUISection.Model<T>", "VH extends com.qmuiteam.qmui.widget.section.QMUIStickySectionAdapter.ViewHolder" })]
    public abstract partial class QMUIStickySectionAdapter : global::AndroidX.RecyclerView.Widget.RecyclerView.Adapter
    {


        // Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/field[@name='ITEM_TYPE_CUSTOM_OFFSET']"
        [Register("ITEM_TYPE_CUSTOM_OFFSET")]
        public const int ItemTypeCustomOffset = (int)1000;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/field[@name='ITEM_TYPE_SECTION_HEADER']"
        [Register("ITEM_TYPE_SECTION_HEADER")]
        public const int ItemTypeSectionHeader = (int)0;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/field[@name='ITEM_TYPE_SECTION_ITEM']"
        [Register("ITEM_TYPE_SECTION_ITEM")]
        public const int ItemTypeSectionItem = (int)1;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/field[@name='ITEM_TYPE_SECTION_LOADING']"
        [Register("ITEM_TYPE_SECTION_LOADING")]
        public const int ItemTypeSectionLoading = (int)2;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/field[@name='ITEM_TYPE_UNKNOWN']"
        [Register("ITEM_TYPE_UNKNOWN")]
        public const int ItemTypeUnknown = (int)-1;
        // Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionAdapter.Callback']"
        [Register("com/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$Callback", "", "Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter/ICallbackInvoker")]
        [global::Java.Interop.JavaTypeParameters(new string[] { "H extends com.qmuiteam.qmui.widget.section.QMUISection.Model<H>", "T extends com.qmuiteam.qmui.widget.section.QMUISection.Model<T>" })]
        public partial interface ICallback : IJavaObject, IJavaPeerable
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionAdapter.Callback']/method[@name='loadMore' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;'] and parameter[2][@type='boolean']]"
            [Register("loadMore", "(Lcom/qmuiteam/qmui/widget/section/QMUISection;Z)V", "GetLoadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_ZHandler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter/ICallbackInvoker, QMUI.Droid")]
            void LoadMore(global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection section, bool loadMoreBefore);

            // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionAdapter.Callback']/method[@name='onItemClick' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUIStickySectionAdapter.ViewHolder'] and parameter[2][@type='int']]"
            [Register("onItemClick", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;I)V", "GetOnItemClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_IHandler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter/ICallbackInvoker, QMUI.Droid")]
            void OnItemClick(global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.ViewHolder holder, int position);

            // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionAdapter.Callback']/method[@name='onItemLongClick' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUIStickySectionAdapter.ViewHolder'] and parameter[2][@type='int']]"
            [Register("onItemLongClick", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;I)Z", "GetOnItemLongClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_IHandler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter/ICallbackInvoker, QMUI.Droid")]
            bool OnItemLongClick(global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.ViewHolder holder, int position);

        }

        [global::Android.Runtime.Register("com/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$Callback", DoNotGenerateAcw = true)]
        internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback
        {

            static readonly JniPeerMembers _members = new XAPeerMembers("com/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$Callback", typeof(ICallbackInvoker));

            static IntPtr java_class_ref
            {
                get { return _members.JniPeerType.PeerReference.Handle; }
            }

            public override global::Java.Interop.JniPeerMembers JniPeerMembers
            {
                get { return _members; }
            }

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return _members.ManagedPeerType; }
            }

            IntPtr class_ref;

            public static ICallback GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<ICallback>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.qmuiteam.qmui.widget.section.QMUIStickySectionAdapter.Callback"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public ICallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_loadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Z;
#pragma warning disable 0169
            static Delegate GetLoadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_ZHandler()
            {
                if (cb_loadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Z == null)
                    cb_loadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Z = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLZ_V)n_LoadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Z);
                return cb_loadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Z;
            }

            static void n_LoadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_section, bool loadMoreBefore)
            {
                var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var section = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection>(native_section, JniHandleOwnership.DoNotTransfer);
                __this.LoadMore(section, loadMoreBefore);
            }
#pragma warning restore 0169

            IntPtr id_loadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Z;
            public unsafe void LoadMore(global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection section, bool loadMoreBefore)
            {
                if (id_loadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Z == IntPtr.Zero)
                    id_loadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Z = JNIEnv.GetMethodID(class_ref, "loadMore", "(Lcom/qmuiteam/qmui/widget/section/QMUISection;Z)V");
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue((section == null) ? IntPtr.Zero : ((global::Java.Lang.Object)section).Handle);
                __args[1] = new JValue(loadMoreBefore);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_loadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Z, __args);
            }

            static Delegate cb_onItemClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I;
#pragma warning disable 0169
            static Delegate GetOnItemClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_IHandler()
            {
                if (cb_onItemClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I == null)
                    cb_onItemClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLI_V)n_OnItemClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I);
                return cb_onItemClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I;
            }

            static void n_OnItemClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I(IntPtr jnienv, IntPtr native__this, IntPtr native_holder, int position)
            {
                var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var holder = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.ViewHolder>(native_holder, JniHandleOwnership.DoNotTransfer);
                __this.OnItemClick(holder, position);
            }
#pragma warning restore 0169

            IntPtr id_onItemClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I;
            public unsafe void OnItemClick(global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.ViewHolder holder, int position)
            {
                if (id_onItemClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I == IntPtr.Zero)
                    id_onItemClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I = JNIEnv.GetMethodID(class_ref, "onItemClick", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;I)V");
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object)holder).Handle);
                __args[1] = new JValue(position);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onItemClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I, __args);
            }

            static Delegate cb_onItemLongClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I;
#pragma warning disable 0169
            static Delegate GetOnItemLongClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_IHandler()
            {
                if (cb_onItemLongClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I == null)
                    cb_onItemLongClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLI_Z)n_OnItemLongClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I);
                return cb_onItemLongClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I;
            }

            static bool n_OnItemLongClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I(IntPtr jnienv, IntPtr native__this, IntPtr native_holder, int position)
            {
                var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var holder = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.ViewHolder>(native_holder, JniHandleOwnership.DoNotTransfer);
                bool __ret = __this.OnItemLongClick(holder, position);
                return __ret;
            }
#pragma warning restore 0169

            IntPtr id_onItemLongClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I;
            public unsafe bool OnItemLongClick(global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.ViewHolder holder, int position)
            {
                if (id_onItemLongClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I == IntPtr.Zero)
                    id_onItemLongClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I = JNIEnv.GetMethodID(class_ref, "onItemLongClick", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;I)Z");
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object)holder).Handle);
                __args[1] = new JValue(position);
                var __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_onItemLongClick_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_I, __args);
                return __ret;
            }

        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionAdapter.PositionFinder']"
        [Register("com/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$PositionFinder", "", "Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter/IPositionFinderInvoker")]
        [global::Java.Interop.JavaTypeParameters(new string[] { "H extends com.qmuiteam.qmui.widget.section.QMUISection.Model<H>", "T extends com.qmuiteam.qmui.widget.section.QMUISection.Model<T>" })]
        public partial interface IPositionFinder : IJavaObject, IJavaPeerable
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionAdapter.PositionFinder']/method[@name='find' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;'] and parameter[2][@type='T']]"
            [Register("find", "(Lcom/qmuiteam/qmui/widget/section/QMUISection;Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;)Z", "GetFind_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_Handler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter/IPositionFinderInvoker, QMUI.Droid")]
            bool Find(global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection section, global::Java.Lang.Object item);

        }

        [global::Android.Runtime.Register("com/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$PositionFinder", DoNotGenerateAcw = true)]
        internal partial class IPositionFinderInvoker : global::Java.Lang.Object, IPositionFinder
        {

            static readonly JniPeerMembers _members = new XAPeerMembers("com/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$PositionFinder", typeof(IPositionFinderInvoker));

            static IntPtr java_class_ref
            {
                get { return _members.JniPeerType.PeerReference.Handle; }
            }

            public override global::Java.Interop.JniPeerMembers JniPeerMembers
            {
                get { return _members; }
            }

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return _members.ManagedPeerType; }
            }

            IntPtr class_ref;

            public static IPositionFinder GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IPositionFinder>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.qmuiteam.qmui.widget.section.QMUIStickySectionAdapter.PositionFinder"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IPositionFinderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_find_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_;
#pragma warning disable 0169
            static Delegate GetFind_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_Handler()
            {
                if (cb_find_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_ == null)
                    cb_find_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLL_Z)n_Find_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_);
                return cb_find_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_;
            }

            static bool n_Find_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_(IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_item)
            {
                var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.IPositionFinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var section = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection>(native_section, JniHandleOwnership.DoNotTransfer);
                var item = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_item, JniHandleOwnership.DoNotTransfer);
                bool __ret = __this.Find(section, item);
                return __ret;
            }
#pragma warning restore 0169

            IntPtr id_find_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_;
            public unsafe bool Find(global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection section, global::Java.Lang.Object item)
            {
                if (id_find_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_ == IntPtr.Zero)
                    id_find_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_ = JNIEnv.GetMethodID(class_ref, "find", "(Lcom/qmuiteam/qmui/widget/section/QMUISection;Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;)Z");
                IntPtr native_item = JNIEnv.ToLocalJniHandle(item);
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue((section == null) ? IntPtr.Zero : ((global::Java.Lang.Object)section).Handle);
                __args[1] = new JValue(native_item);
                var __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_find_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_, __args);
                JNIEnv.DeleteLocalRef(native_item);
                return __ret;
            }

        }


        // Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionAdapter.ViewCallback']"
        [Register("com/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewCallback", "", "Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter/IViewCallbackInvoker")]
        public partial interface IViewCallback : IJavaObject, IJavaPeerable
        {

            // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionAdapter.ViewCallback']/method[@name='findViewHolderForAdapterPosition' and count(parameter)=1 and parameter[1][@type='int']]"
            [Register("findViewHolderForAdapterPosition", "(I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", "GetFindViewHolderForAdapterPosition_IHandler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter/IViewCallbackInvoker, QMUI.Droid")]
            global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder FindViewHolderForAdapterPosition(int position);

            // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionAdapter.ViewCallback']/method[@name='requestChildFocus' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
            [Register("requestChildFocus", "(Landroid/view/View;)V", "GetRequestChildFocus_Landroid_view_View_Handler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter/IViewCallbackInvoker, QMUI.Droid")]
            void RequestChildFocus(global::Android.Views.View p0);

            // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUIStickySectionAdapter.ViewCallback']/method[@name='scrollToPosition' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
            [Register("scrollToPosition", "(IZZ)V", "GetScrollToPosition_IZZHandler:Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter/IViewCallbackInvoker, QMUI.Droid")]
            void ScrollToPosition(int position, bool isSectionHeader, bool scrollToTop);

        }

        [global::Android.Runtime.Register("com/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewCallback", DoNotGenerateAcw = true)]
        internal partial class IViewCallbackInvoker : global::Java.Lang.Object, IViewCallback
        {

            static readonly JniPeerMembers _members = new XAPeerMembers("com/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewCallback", typeof(IViewCallbackInvoker));

            static IntPtr java_class_ref
            {
                get { return _members.JniPeerType.PeerReference.Handle; }
            }

            public override global::Java.Interop.JniPeerMembers JniPeerMembers
            {
                get { return _members; }
            }

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return _members.ManagedPeerType; }
            }

            IntPtr class_ref;

            public static IViewCallback GetObject(IntPtr handle, JniHandleOwnership transfer)
            {
                return global::Java.Lang.Object.GetObject<IViewCallback>(handle, transfer);
            }

            static IntPtr Validate(IntPtr handle)
            {
                if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
                    throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
                                JNIEnv.GetClassNameFromInstance(handle), "com.qmuiteam.qmui.widget.section.QMUIStickySectionAdapter.ViewCallback"));
                return handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (this.class_ref != IntPtr.Zero)
                    JNIEnv.DeleteGlobalRef(this.class_ref);
                this.class_ref = IntPtr.Zero;
                base.Dispose(disposing);
            }

            public IViewCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
            {
                IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
                this.class_ref = JNIEnv.NewGlobalRef(local_ref);
                JNIEnv.DeleteLocalRef(local_ref);
            }

            static Delegate cb_findViewHolderForAdapterPosition_I;
#pragma warning disable 0169
            static Delegate GetFindViewHolderForAdapterPosition_IHandler()
            {
                if (cb_findViewHolderForAdapterPosition_I == null)
                    cb_findViewHolderForAdapterPosition_I = JNINativeWrapper.CreateDelegate((_JniMarshal_PPI_L)n_FindViewHolderForAdapterPosition_I);
                return cb_findViewHolderForAdapterPosition_I;
            }

            static IntPtr n_FindViewHolderForAdapterPosition_I(IntPtr jnienv, IntPtr native__this, int position)
            {
                var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.IViewCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                return JNIEnv.ToLocalJniHandle(__this.FindViewHolderForAdapterPosition(position));
            }
#pragma warning restore 0169

            IntPtr id_findViewHolderForAdapterPosition_I;
            public unsafe global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder FindViewHolderForAdapterPosition(int position)
            {
                if (id_findViewHolderForAdapterPosition_I == IntPtr.Zero)
                    id_findViewHolderForAdapterPosition_I = JNIEnv.GetMethodID(class_ref, "findViewHolderForAdapterPosition", "(I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(position);
                return global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_findViewHolderForAdapterPosition_I, __args), JniHandleOwnership.TransferLocalRef);
            }

            static Delegate cb_requestChildFocus_Landroid_view_View_;
#pragma warning disable 0169
            static Delegate GetRequestChildFocus_Landroid_view_View_Handler()
            {
                if (cb_requestChildFocus_Landroid_view_View_ == null)
                    cb_requestChildFocus_Landroid_view_View_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_V)n_RequestChildFocus_Landroid_view_View_);
                return cb_requestChildFocus_Landroid_view_View_;
            }

            static void n_RequestChildFocus_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.IViewCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View>(native_p0, JniHandleOwnership.DoNotTransfer);
                __this.RequestChildFocus(p0);
            }
#pragma warning restore 0169

            IntPtr id_requestChildFocus_Landroid_view_View_;
            public unsafe void RequestChildFocus(global::Android.Views.View p0)
            {
                if (id_requestChildFocus_Landroid_view_View_ == IntPtr.Zero)
                    id_requestChildFocus_Landroid_view_View_ = JNIEnv.GetMethodID(class_ref, "requestChildFocus", "(Landroid/view/View;)V");
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_requestChildFocus_Landroid_view_View_, __args);
            }

            static Delegate cb_scrollToPosition_IZZ;
#pragma warning disable 0169
            static Delegate GetScrollToPosition_IZZHandler()
            {
                if (cb_scrollToPosition_IZZ == null)
                    cb_scrollToPosition_IZZ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPIZZ_V)n_ScrollToPosition_IZZ);
                return cb_scrollToPosition_IZZ;
            }

            static void n_ScrollToPosition_IZZ(IntPtr jnienv, IntPtr native__this, int position, bool isSectionHeader, bool scrollToTop)
            {
                var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.IViewCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                __this.ScrollToPosition(position, isSectionHeader, scrollToTop);
            }
#pragma warning restore 0169

            IntPtr id_scrollToPosition_IZZ;
            public unsafe void ScrollToPosition(int position, bool isSectionHeader, bool scrollToTop)
            {
                if (id_scrollToPosition_IZZ == IntPtr.Zero)
                    id_scrollToPosition_IZZ = JNIEnv.GetMethodID(class_ref, "scrollToPosition", "(IZZ)V");
                JValue* __args = stackalloc JValue[3];
                __args[0] = new JValue(position);
                __args[1] = new JValue(isSectionHeader);
                __args[2] = new JValue(scrollToTop);
                JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_scrollToPosition_IZZ, __args);
            }

        }


        // Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter.ViewHolder']"
        [global::Android.Runtime.Register("com/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder", DoNotGenerateAcw = true)]
        public partial class ViewHolder : global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder
        {



            // Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter.ViewHolder']/field[@name='isForStickyHeader']"
            [Register("isForStickyHeader")]
            public bool IsForStickyHeader
            {
                get
                {
                    const string __id = "isForStickyHeader.Z";

                    var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                    return __v;
                }
                set
                {
                    const string __id = "isForStickyHeader.Z";

                    try
                    {
                        _members.InstanceFields.SetValue(__id, this, value);
                    }
                    finally
                    {
                    }
                }
            }


            // Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter.ViewHolder']/field[@name='isLoadBefore']"
            [Register("isLoadBefore")]
            public bool IsLoadBefore
            {
                get
                {
                    const string __id = "isLoadBefore.Z";

                    var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                    return __v;
                }
                set
                {
                    const string __id = "isLoadBefore.Z";

                    try
                    {
                        _members.InstanceFields.SetValue(__id, this, value);
                    }
                    finally
                    {
                    }
                }
            }


            // Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter.ViewHolder']/field[@name='isLoadError']"
            [Register("isLoadError")]
            public bool IsLoadError
            {
                get
                {
                    const string __id = "isLoadError.Z";

                    var __v = _members.InstanceFields.GetBooleanValue(__id, this);
                    return __v;
                }
                set
                {
                    const string __id = "isLoadError.Z";

                    try
                    {
                        _members.InstanceFields.SetValue(__id, this, value);
                    }
                    finally
                    {
                    }
                }
            }
            static readonly JniPeerMembers _members = new XAPeerMembers("com/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder", typeof(ViewHolder));
            internal static IntPtr class_ref
            {
                get
                {
                    return _members.JniPeerType.PeerReference.Handle;
                }
            }

            public override global::Java.Interop.JniPeerMembers JniPeerMembers
            {
                get { return _members; }
            }

            protected override IntPtr ThresholdClass
            {
                get { return _members.JniPeerType.PeerReference.Handle; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return _members.ManagedPeerType; }
            }

            protected ViewHolder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

            // Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter.ViewHolder']/constructor[@name='QMUIStickySectionAdapter.ViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
            [Register(".ctor", "(Landroid/view/View;)V", "")]
            public unsafe ViewHolder(global::Android.Views.View itemView)
                : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
            {
                const string __id = "(Landroid/view/View;)V";

                if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                    return;

                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                    __args[0] = new JniArgumentValue((itemView == null) ? IntPtr.Zero : ((global::Java.Lang.Object)itemView).Handle);
                    var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
                    SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
                    _members.InstanceMethods.FinishCreateInstance(__id, this, __args);
                }
                finally
                {
                    global::System.GC.KeepAlive(itemView);
                }
            }

        }

        static readonly JniPeerMembers _members = new XAPeerMembers("com/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter", typeof(QMUIStickySectionAdapter));
        internal static IntPtr class_ref
        {
            get
            {
                return _members.JniPeerType.PeerReference.Handle;
            }
        }

        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        protected QMUIStickySectionAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/constructor[@name='QMUIStickySectionAdapter' and count(parameter)=0]"
        [Register(".ctor", "()V", "")]
        public unsafe QMUIStickySectionAdapter()
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            const string __id = "()V";

            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            try
            {
                var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), null);
                SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
                _members.InstanceMethods.FinishCreateInstance(__id, this, null);
            }
            finally
            {
            }
        }

        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/constructor[@name='QMUIStickySectionAdapter' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register(".ctor", "(Z)V", "")]
        public unsafe QMUIStickySectionAdapter(bool removeSectionTitleIfOnlyOneSection)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            const string __id = "(Z)V";

            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(removeSectionTitleIfOnlyOneSection);
                var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
                SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
                _members.InstanceMethods.FinishCreateInstance(__id, this, __args);
            }
            finally
            {
            }
        }

        static Delegate cb_isRemoveSectionTitleIfOnlyOneSection;
#pragma warning disable 0169
        static Delegate GetIsRemoveSectionTitleIfOnlyOneSectionHandler()
        {
            if (cb_isRemoveSectionTitleIfOnlyOneSection == null)
                cb_isRemoveSectionTitleIfOnlyOneSection = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_Z)n_IsRemoveSectionTitleIfOnlyOneSection);
            return cb_isRemoveSectionTitleIfOnlyOneSection;
        }

        static bool n_IsRemoveSectionTitleIfOnlyOneSection(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.IsRemoveSectionTitleIfOnlyOneSection;
        }
#pragma warning restore 0169

        public virtual unsafe bool IsRemoveSectionTitleIfOnlyOneSection
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='isRemoveSectionTitleIfOnlyOneSection' and count(parameter)=0]"
            [Register("isRemoveSectionTitleIfOnlyOneSection", "()Z", "GetIsRemoveSectionTitleIfOnlyOneSectionHandler")]
            get
            {
                const string __id = "isRemoveSectionTitleIfOnlyOneSection.()Z";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, null);
                    return __rm;
                }
                finally
                {
                }
            }
        }

        public override unsafe int ItemCount
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='getItemCount' and count(parameter)=0]"
            [Register("getItemCount", "()I", "")]
            get
            {
                const string __id = "getItemCount.()I";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method(__id, this, null);
                    return __rm;
                }
                finally
                {
                }
            }
        }

        static Delegate cb_getSectionCount;
#pragma warning disable 0169
        static Delegate GetGetSectionCountHandler()
        {
            if (cb_getSectionCount == null)
                cb_getSectionCount = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_I)n_GetSectionCount);
            return cb_getSectionCount;
        }

        static int n_GetSectionCount(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.SectionCount;
        }
#pragma warning restore 0169

        public virtual unsafe int SectionCount
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='getSectionCount' and count(parameter)=0]"
            [Register("getSectionCount", "()I", "GetGetSectionCountHandler")]
            get
            {
                const string __id = "getSectionCount.()I";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, null);
                    return __rm;
                }
                finally
                {
                }
            }
        }

        static Delegate cb_beforeDiffInSet_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
        static Delegate GetBeforeDiffInSet_Ljava_util_List_Ljava_util_List_Handler()
        {
            if (cb_beforeDiffInSet_Ljava_util_List_Ljava_util_List_ == null)
                cb_beforeDiffInSet_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLL_V)n_BeforeDiffInSet_Ljava_util_List_Ljava_util_List_);
            return cb_beforeDiffInSet_Ljava_util_List_Ljava_util_List_;
        }

        static void n_BeforeDiffInSet_Ljava_util_List_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_oldData, IntPtr native_newData)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var oldData = global::Android.Runtime.JavaList.FromJniHandle(native_oldData, JniHandleOwnership.DoNotTransfer);
            var newData = global::Android.Runtime.JavaList.FromJniHandle(native_newData, JniHandleOwnership.DoNotTransfer);
            __this.BeforeDiffInSet(oldData, newData);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='beforeDiffInSet' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;&gt;'] and parameter[2][@type='java.util.List&lt;com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;&gt;']]"
        [Register("beforeDiffInSet", "(Ljava/util/List;Ljava/util/List;)V", "GetBeforeDiffInSet_Ljava_util_List_Ljava_util_List_Handler")]
        protected virtual unsafe void BeforeDiffInSet(global::System.Collections.IList oldData, global::System.Collections.IList newData)
        {
            const string __id = "beforeDiffInSet.(Ljava/util/List;Ljava/util/List;)V";
            IntPtr native_oldData = global::Android.Runtime.JavaList.ToLocalJniHandle(oldData);
            IntPtr native_newData = global::Android.Runtime.JavaList.ToLocalJniHandle(newData);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(native_oldData);
                __args[1] = new JniArgumentValue(native_newData);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_oldData);
                JNIEnv.DeleteLocalRef(native_newData);
                global::System.GC.KeepAlive(oldData);
                global::System.GC.KeepAlive(newData);
            }
        }

        static Delegate cb_createDiffCallback_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
        static Delegate GetCreateDiffCallback_Ljava_util_List_Ljava_util_List_Handler()
        {
            if (cb_createDiffCallback_Ljava_util_List_Ljava_util_List_ == null)
                cb_createDiffCallback_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLL_L)n_CreateDiffCallback_Ljava_util_List_Ljava_util_List_);
            return cb_createDiffCallback_Ljava_util_List_Ljava_util_List_;
        }

        static IntPtr n_CreateDiffCallback_Ljava_util_List_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_lastData, IntPtr native_currentData)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var lastData = global::Android.Runtime.JavaList.FromJniHandle(native_lastData, JniHandleOwnership.DoNotTransfer);
            var currentData = global::Android.Runtime.JavaList.FromJniHandle(native_currentData, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.CreateDiffCallback(lastData, currentData));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='createDiffCallback' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;&gt;'] and parameter[2][@type='java.util.List&lt;com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;&gt;']]"
        [Register("createDiffCallback", "(Ljava/util/List;Ljava/util/List;)Lcom/qmuiteam/qmui/widget/section/QMUISectionDiffCallback;", "GetCreateDiffCallback_Ljava_util_List_Ljava_util_List_Handler")]
        protected virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback CreateDiffCallback(global::System.Collections.IList lastData, global::System.Collections.IList currentData)
        {
            const string __id = "createDiffCallback.(Ljava/util/List;Ljava/util/List;)Lcom/qmuiteam/qmui/widget/section/QMUISectionDiffCallback;";
            IntPtr native_lastData = global::Android.Runtime.JavaList.ToLocalJniHandle(lastData);
            IntPtr native_currentData = global::Android.Runtime.JavaList.ToLocalJniHandle(currentData);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(native_lastData);
                __args[1] = new JniArgumentValue(native_currentData);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_lastData);
                JNIEnv.DeleteLocalRef(native_currentData);
                global::System.GC.KeepAlive(lastData);
                global::System.GC.KeepAlive(currentData);
            }
        }

        static Delegate cb_findCustomPosition_IIZ;
#pragma warning disable 0169
        static Delegate GetFindCustomPosition_IIZHandler()
        {
            if (cb_findCustomPosition_IIZ == null)
                cb_findCustomPosition_IIZ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPIIZ_I)n_FindCustomPosition_IIZ);
            return cb_findCustomPosition_IIZ;
        }

        static int n_FindCustomPosition_IIZ(IntPtr jnienv, IntPtr native__this, int sectionIndex, int customItemIndex, bool unFoldTargetSection)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.FindCustomPosition(sectionIndex, customItemIndex, unFoldTargetSection);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='findCustomPosition' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
        [Register("findCustomPosition", "(IIZ)I", "GetFindCustomPosition_IIZHandler")]
        public virtual unsafe int FindCustomPosition(int sectionIndex, int customItemIndex, bool unFoldTargetSection)
        {
            const string __id = "findCustomPosition.(IIZ)I";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue(sectionIndex);
                __args[1] = new JniArgumentValue(customItemIndex);
                __args[2] = new JniArgumentValue(unFoldTargetSection);
                var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, __args);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_findPosition_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_PositionFinder_Z;
#pragma warning disable 0169
        static Delegate GetFindPosition_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_PositionFinder_ZHandler()
        {
            if (cb_findPosition_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_PositionFinder_Z == null)
                cb_findPosition_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_PositionFinder_Z = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLZ_I)n_FindPosition_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_PositionFinder_Z);
            return cb_findPosition_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_PositionFinder_Z;
        }

        static int n_FindPosition_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_PositionFinder_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_positionFinder, bool unFoldTargetSection)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var positionFinder = (global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.IPositionFinder)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.IPositionFinder>(native_positionFinder, JniHandleOwnership.DoNotTransfer);
            int __ret = __this.FindPosition(positionFinder, unFoldTargetSection);
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='findPosition' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUIStickySectionAdapter.PositionFinder&lt;H, T&gt;'] and parameter[2][@type='boolean']]"
        [Register("findPosition", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$PositionFinder;Z)I", "GetFindPosition_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_PositionFinder_ZHandler")]
        public virtual unsafe int FindPosition(global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.IPositionFinder positionFinder, bool unFoldTargetSection)
        {
            const string __id = "findPosition.(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$PositionFinder;Z)I";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((positionFinder == null) ? IntPtr.Zero : ((global::Java.Lang.Object)positionFinder).Handle);
                __args[1] = new JniArgumentValue(unFoldTargetSection);
                var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, __args);
                return __rm;
            }
            finally
            {
                global::System.GC.KeepAlive(positionFinder);
            }
        }

        static Delegate cb_findPosition_IIZ;
#pragma warning disable 0169
        static Delegate GetFindPosition_IIZHandler()
        {
            if (cb_findPosition_IIZ == null)
                cb_findPosition_IIZ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPIIZ_I)n_FindPosition_IIZ);
            return cb_findPosition_IIZ;
        }

        static int n_FindPosition_IIZ(IntPtr jnienv, IntPtr native__this, int sectionIndex, int itemIndex, bool unFoldTargetSection)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.FindPosition(sectionIndex, itemIndex, unFoldTargetSection);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='findPosition' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
        [Register("findPosition", "(IIZ)I", "GetFindPosition_IIZHandler")]
        public virtual unsafe int FindPosition(int sectionIndex, int itemIndex, bool unFoldTargetSection)
        {
            const string __id = "findPosition.(IIZ)I";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue(sectionIndex);
                __args[1] = new JniArgumentValue(itemIndex);
                __args[2] = new JniArgumentValue(unFoldTargetSection);
                var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, __args);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_finishLoadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Ljava_util_List_ZZ;
#pragma warning disable 0169
        static Delegate GetFinishLoadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Ljava_util_List_ZZHandler()
        {
            if (cb_finishLoadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Ljava_util_List_ZZ == null)
                cb_finishLoadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Ljava_util_List_ZZ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLLZZ_V)n_FinishLoadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Ljava_util_List_ZZ);
            return cb_finishLoadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Ljava_util_List_ZZ;
        }

        static void n_FinishLoadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Ljava_util_List_ZZ(IntPtr jnienv, IntPtr native__this, IntPtr native_section, IntPtr native_itemList, bool isLoadBefore, bool existMoreData)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var section = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection>(native_section, JniHandleOwnership.DoNotTransfer);
            var itemList = global::Android.Runtime.JavaList.FromJniHandle(native_itemList, JniHandleOwnership.DoNotTransfer);
            __this.FinishLoadMore(section, itemList, isLoadBefore, existMoreData);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='finishLoadMore' and count(parameter)=4 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;'] and parameter[2][@type='java.util.List&lt;T&gt;'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
        [Register("finishLoadMore", "(Lcom/qmuiteam/qmui/widget/section/QMUISection;Ljava/util/List;ZZ)V", "GetFinishLoadMore_Lcom_qmuiteam_qmui_widget_section_QMUISection_Ljava_util_List_ZZHandler")]
        public virtual unsafe void FinishLoadMore(global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection section, global::System.Collections.IList itemList, bool isLoadBefore, bool existMoreData)
        {
            const string __id = "finishLoadMore.(Lcom/qmuiteam/qmui/widget/section/QMUISection;Ljava/util/List;ZZ)V";
            IntPtr native_itemList = global::Android.Runtime.JavaList.ToLocalJniHandle(itemList);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[4];
                __args[0] = new JniArgumentValue((section == null) ? IntPtr.Zero : ((global::Java.Lang.Object)section).Handle);
                __args[1] = new JniArgumentValue(native_itemList);
                __args[2] = new JniArgumentValue(isLoadBefore);
                __args[3] = new JniArgumentValue(existMoreData);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_itemList);
                global::System.GC.KeepAlive(section);
                global::System.GC.KeepAlive(itemList);
            }
        }

        static Delegate cb_getCustomItemViewType_II;
#pragma warning disable 0169
        static Delegate GetGetCustomItemViewType_IIHandler()
        {
            if (cb_getCustomItemViewType_II == null)
                cb_getCustomItemViewType_II = JNINativeWrapper.CreateDelegate((_JniMarshal_PPII_I)n_GetCustomItemViewType_II);
            return cb_getCustomItemViewType_II;
        }

        static int n_GetCustomItemViewType_II(IntPtr jnienv, IntPtr native__this, int itemIndex, int position)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.GetCustomItemViewType(itemIndex, position);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='getCustomItemViewType' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
        [Register("getCustomItemViewType", "(II)I", "GetGetCustomItemViewType_IIHandler")]
        protected virtual unsafe int GetCustomItemViewType(int itemIndex, int position)
        {
            const string __id = "getCustomItemViewType.(II)I";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(itemIndex);
                __args[1] = new JniArgumentValue(position);
                var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, __args);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_getItemIndex_I;
#pragma warning disable 0169
        static Delegate GetGetItemIndex_IHandler()
        {
            if (cb_getItemIndex_I == null)
                cb_getItemIndex_I = JNINativeWrapper.CreateDelegate((_JniMarshal_PPI_I)n_GetItemIndex_I);
            return cb_getItemIndex_I;
        }

        static int n_GetItemIndex_I(IntPtr jnienv, IntPtr native__this, int position)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.GetItemIndex(position);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='getItemIndex' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getItemIndex", "(I)I", "GetGetItemIndex_IHandler")]
        public virtual unsafe int GetItemIndex(int position)
        {
            const string __id = "getItemIndex.(I)I";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(position);
                var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, __args);
                return __rm;
            }
            finally
            {
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='getItemViewType' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getItemViewType", "(I)I", "")]
        public override sealed unsafe int GetItemViewType(int position)
        {
            const string __id = "getItemViewType.(I)I";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(position);
                var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method(__id, this, __args);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_getRelativeStickyPosition_I;
#pragma warning disable 0169
        static Delegate GetGetRelativeStickyPosition_IHandler()
        {
            if (cb_getRelativeStickyPosition_I == null)
                cb_getRelativeStickyPosition_I = JNINativeWrapper.CreateDelegate((_JniMarshal_PPI_I)n_GetRelativeStickyPosition_I);
            return cb_getRelativeStickyPosition_I;
        }

        static int n_GetRelativeStickyPosition_I(IntPtr jnienv, IntPtr native__this, int position)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.GetRelativeStickyPosition(position);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='getRelativeStickyPosition' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getRelativeStickyPosition", "(I)I", "GetGetRelativeStickyPosition_IHandler")]
        public virtual unsafe int GetRelativeStickyPosition(int position)
        {
            const string __id = "getRelativeStickyPosition.(I)I";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(position);
                var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, __args);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_getSection_I;
#pragma warning disable 0169
        static Delegate GetGetSection_IHandler()
        {
            if (cb_getSection_I == null)
                cb_getSection_I = JNINativeWrapper.CreateDelegate((_JniMarshal_PPI_L)n_GetSection_I);
            return cb_getSection_I;
        }

        static IntPtr n_GetSection_I(IntPtr jnienv, IntPtr native__this, int position)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.GetSection(position));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='getSection' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getSection", "(I)Lcom/qmuiteam/qmui/widget/section/QMUISection;", "GetGetSection_IHandler")]
        public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection GetSection(int position)
        {
            const string __id = "getSection.(I)Lcom/qmuiteam/qmui/widget/section/QMUISection;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(position);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_getSectionDirectly_I;
#pragma warning disable 0169
        static Delegate GetGetSectionDirectly_IHandler()
        {
            if (cb_getSectionDirectly_I == null)
                cb_getSectionDirectly_I = JNINativeWrapper.CreateDelegate((_JniMarshal_PPI_L)n_GetSectionDirectly_I);
            return cb_getSectionDirectly_I;
        }

        static IntPtr n_GetSectionDirectly_I(IntPtr jnienv, IntPtr native__this, int index)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.GetSectionDirectly(index));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='getSectionDirectly' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getSectionDirectly", "(I)Lcom/qmuiteam/qmui/widget/section/QMUISection;", "GetGetSectionDirectly_IHandler")]
        public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection GetSectionDirectly(int index)
        {
            const string __id = "getSectionDirectly.(I)Lcom/qmuiteam/qmui/widget/section/QMUISection;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(index);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_getSectionIndex_I;
#pragma warning disable 0169
        static Delegate GetGetSectionIndex_IHandler()
        {
            if (cb_getSectionIndex_I == null)
                cb_getSectionIndex_I = JNINativeWrapper.CreateDelegate((_JniMarshal_PPI_I)n_GetSectionIndex_I);
            return cb_getSectionIndex_I;
        }

        static int n_GetSectionIndex_I(IntPtr jnienv, IntPtr native__this, int position)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.GetSectionIndex(position);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='getSectionIndex' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getSectionIndex", "(I)I", "GetGetSectionIndex_IHandler")]
        public virtual unsafe int GetSectionIndex(int position)
        {
            const string __id = "getSectionIndex.(I)I";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(position);
                var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, __args);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_getSectionItem_I;
#pragma warning disable 0169
        static Delegate GetGetSectionItem_IHandler()
        {
            if (cb_getSectionItem_I == null)
                cb_getSectionItem_I = JNINativeWrapper.CreateDelegate((_JniMarshal_PPI_L)n_GetSectionItem_I);
            return cb_getSectionItem_I;
        }

        static IntPtr n_GetSectionItem_I(IntPtr jnienv, IntPtr native__this, int position)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.GetSectionItem(position));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='getSectionItem' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("getSectionItem", "(I)Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;", "GetGetSectionItem_IHandler")]
        public virtual unsafe global::Java.Lang.Object GetSectionItem(int position)
        {
            const string __id = "getSectionItem.(I)Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(position);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return (Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate cb_isSectionFold_I;
#pragma warning disable 0169
        static Delegate GetIsSectionFold_IHandler()
        {
            if (cb_isSectionFold_I == null)
                cb_isSectionFold_I = JNINativeWrapper.CreateDelegate((_JniMarshal_PPI_Z)n_IsSectionFold_I);
            return cb_isSectionFold_I;
        }

        static bool n_IsSectionFold_I(IntPtr jnienv, IntPtr native__this, int position)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.IsSectionFold(position);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='isSectionFold' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("isSectionFold", "(I)Z", "GetIsSectionFold_IHandler")]
        public virtual unsafe bool IsSectionFold(int position)
        {
            const string __id = "isSectionFold.(I)Z";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(position);
                var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, __args);
                return __rm;
            }
            finally
            {
            }
        }

        static Delegate cb_onBindCustomItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_I;
#pragma warning disable 0169
        static Delegate GetOnBindCustomItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_IHandler()
        {
            if (cb_onBindCustomItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_I == null)
                cb_onBindCustomItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_I = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLILI_V)n_OnBindCustomItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_I);
            return cb_onBindCustomItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_I;
        }

        static void n_OnBindCustomItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_I(IntPtr jnienv, IntPtr native__this, IntPtr native_holder, int position, IntPtr native_section, int itemIndex)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var holder = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_holder, JniHandleOwnership.DoNotTransfer);
            var section = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection>(native_section, JniHandleOwnership.DoNotTransfer);
            __this.OnBindCustomItem(holder, position, section, itemIndex);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='onBindCustomItem' and count(parameter)=4 and parameter[1][@type='VH'] and parameter[2][@type='int'] and parameter[3][@type='com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;'] and parameter[4][@type='int']]"
        [Register("onBindCustomItem", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;ILcom/qmuiteam/qmui/widget/section/QMUISection;I)V", "GetOnBindCustomItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_IHandler")]
        protected virtual unsafe void OnBindCustomItem(global::Java.Lang.Object holder, int position, global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection section, int itemIndex)
        {
            const string __id = "onBindCustomItem.(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;ILcom/qmuiteam/qmui/widget/section/QMUISection;I)V";
            IntPtr native_holder = JNIEnv.ToLocalJniHandle(holder);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[4];
                __args[0] = new JniArgumentValue(native_holder);
                __args[1] = new JniArgumentValue(position);
                __args[2] = new JniArgumentValue((section == null) ? IntPtr.Zero : ((global::Java.Lang.Object)section).Handle);
                __args[3] = new JniArgumentValue(itemIndex);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_holder);
                global::System.GC.KeepAlive(holder);
                global::System.GC.KeepAlive(section);
            }
        }

        static Delegate cb_onBindSectionHeader_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_;
#pragma warning disable 0169
        static Delegate GetOnBindSectionHeader_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_Handler()
        {
            if (cb_onBindSectionHeader_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_ == null)
                cb_onBindSectionHeader_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLIL_V)n_OnBindSectionHeader_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_);
            return cb_onBindSectionHeader_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_;
        }

        static void n_OnBindSectionHeader_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_(IntPtr jnienv, IntPtr native__this, IntPtr native_holder, int position, IntPtr native_section)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var holder = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_holder, JniHandleOwnership.DoNotTransfer);
            var section = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection>(native_section, JniHandleOwnership.DoNotTransfer);
            __this.OnBindSectionHeader(holder, position, section);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='onBindSectionHeader' and count(parameter)=3 and parameter[1][@type='VH'] and parameter[2][@type='int'] and parameter[3][@type='com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;']]"
        [Register("onBindSectionHeader", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;ILcom/qmuiteam/qmui/widget/section/QMUISection;)V", "GetOnBindSectionHeader_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_Handler")]
        protected virtual unsafe void OnBindSectionHeader(global::Java.Lang.Object holder, int position, global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection section)
        {
            const string __id = "onBindSectionHeader.(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;ILcom/qmuiteam/qmui/widget/section/QMUISection;)V";
            IntPtr native_holder = JNIEnv.ToLocalJniHandle(holder);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue(native_holder);
                __args[1] = new JniArgumentValue(position);
                __args[2] = new JniArgumentValue((section == null) ? IntPtr.Zero : ((global::Java.Lang.Object)section).Handle);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_holder);
                global::System.GC.KeepAlive(holder);
                global::System.GC.KeepAlive(section);
            }
        }

        static Delegate cb_onBindSectionItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_I;
#pragma warning disable 0169
        static Delegate GetOnBindSectionItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_IHandler()
        {
            if (cb_onBindSectionItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_I == null)
                cb_onBindSectionItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_I = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLILI_V)n_OnBindSectionItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_I);
            return cb_onBindSectionItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_I;
        }

        static void n_OnBindSectionItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_I(IntPtr jnienv, IntPtr native__this, IntPtr native_holder, int position, IntPtr native_section, int itemIndex)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var holder = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_holder, JniHandleOwnership.DoNotTransfer);
            var section = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection>(native_section, JniHandleOwnership.DoNotTransfer);
            __this.OnBindSectionItem(holder, position, section, itemIndex);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='onBindSectionItem' and count(parameter)=4 and parameter[1][@type='VH'] and parameter[2][@type='int'] and parameter[3][@type='com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;'] and parameter[4][@type='int']]"
        [Register("onBindSectionItem", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;ILcom/qmuiteam/qmui/widget/section/QMUISection;I)V", "GetOnBindSectionItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_IHandler")]
        protected virtual unsafe void OnBindSectionItem(global::Java.Lang.Object holder, int position, global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection section, int itemIndex)
        {
            const string __id = "onBindSectionItem.(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;ILcom/qmuiteam/qmui/widget/section/QMUISection;I)V";
            IntPtr native_holder = JNIEnv.ToLocalJniHandle(holder);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[4];
                __args[0] = new JniArgumentValue(native_holder);
                __args[1] = new JniArgumentValue(position);
                __args[2] = new JniArgumentValue((section == null) ? IntPtr.Zero : ((global::Java.Lang.Object)section).Handle);
                __args[3] = new JniArgumentValue(itemIndex);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_holder);
                global::System.GC.KeepAlive(holder);
                global::System.GC.KeepAlive(section);
            }
        }

        static Delegate cb_onBindSectionLoadingItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_Z;
#pragma warning disable 0169
        static Delegate GetOnBindSectionLoadingItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_ZHandler()
        {
            if (cb_onBindSectionLoadingItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_Z == null)
                cb_onBindSectionLoadingItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_Z = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLILZ_V)n_OnBindSectionLoadingItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_Z);
            return cb_onBindSectionLoadingItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_Z;
        }

        static void n_OnBindSectionLoadingItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_holder, int position, IntPtr native_section, bool loadingBefore)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var holder = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_holder, JniHandleOwnership.DoNotTransfer);
            var section = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection>(native_section, JniHandleOwnership.DoNotTransfer);
            __this.OnBindSectionLoadingItem(holder, position, section, loadingBefore);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='onBindSectionLoadingItem' and count(parameter)=4 and parameter[1][@type='VH'] and parameter[2][@type='int'] and parameter[3][@type='com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;'] and parameter[4][@type='boolean']]"
        [Register("onBindSectionLoadingItem", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;ILcom/qmuiteam/qmui/widget/section/QMUISection;Z)V", "GetOnBindSectionLoadingItem_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ILcom_qmuiteam_qmui_widget_section_QMUISection_ZHandler")]
        protected virtual unsafe void OnBindSectionLoadingItem(global::Java.Lang.Object holder, int position, global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection section, bool loadingBefore)
        {
            const string __id = "onBindSectionLoadingItem.(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;ILcom/qmuiteam/qmui/widget/section/QMUISection;Z)V";
            IntPtr native_holder = JNIEnv.ToLocalJniHandle(holder);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[4];
                __args[0] = new JniArgumentValue(native_holder);
                __args[1] = new JniArgumentValue(position);
                __args[2] = new JniArgumentValue((section == null) ? IntPtr.Zero : ((global::Java.Lang.Object)section).Handle);
                __args[3] = new JniArgumentValue(loadingBefore);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_holder);
                global::System.GC.KeepAlive(holder);
                global::System.GC.KeepAlive(section);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='onBindViewHolder' and count(parameter)=2 and parameter[1][@type='VH'] and parameter[2][@type='int']]"
        [Register("onBindViewHolder", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;I)V", "")]
        public unsafe void OnBindViewHolder(global::Java.Lang.Object vh, int position)
        {
            const string __id = "onBindViewHolder.(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;I)V";
            IntPtr native_vh = JNIEnv.ToLocalJniHandle(vh);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(native_vh);
                __args[1] = new JniArgumentValue(position);
                _members.InstanceMethods.InvokeNonvirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_vh);
                global::System.GC.KeepAlive(vh);
            }
        }

        static Delegate cb_onCreateCustomItemViewHolder_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
        static Delegate GetOnCreateCustomItemViewHolder_Landroid_view_ViewGroup_IHandler()
        {
            if (cb_onCreateCustomItemViewHolder_Landroid_view_ViewGroup_I == null)
                cb_onCreateCustomItemViewHolder_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLI_L)n_OnCreateCustomItemViewHolder_Landroid_view_ViewGroup_I);
            return cb_onCreateCustomItemViewHolder_Landroid_view_ViewGroup_I;
        }

        static IntPtr n_OnCreateCustomItemViewHolder_Landroid_view_ViewGroup_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup>(native_p0, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.OnCreateCustomItemViewHolder(p0, p1));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='onCreateCustomItemViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
        [Register("onCreateCustomItemViewHolder", "(Landroid/view/ViewGroup;I)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;", "GetOnCreateCustomItemViewHolder_Landroid_view_ViewGroup_IHandler")]
        protected abstract global::Java.Lang.Object OnCreateCustomItemViewHolder(global::Android.Views.ViewGroup p0, int p1);

        static Delegate cb_onCreateSectionHeaderViewHolder_Landroid_view_ViewGroup_;
#pragma warning disable 0169
        static Delegate GetOnCreateSectionHeaderViewHolder_Landroid_view_ViewGroup_Handler()
        {
            if (cb_onCreateSectionHeaderViewHolder_Landroid_view_ViewGroup_ == null)
                cb_onCreateSectionHeaderViewHolder_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_OnCreateSectionHeaderViewHolder_Landroid_view_ViewGroup_);
            return cb_onCreateSectionHeaderViewHolder_Landroid_view_ViewGroup_;
        }

        static IntPtr n_OnCreateSectionHeaderViewHolder_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup>(native_p0, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.OnCreateSectionHeaderViewHolder(p0));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='onCreateSectionHeaderViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
        [Register("onCreateSectionHeaderViewHolder", "(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;", "GetOnCreateSectionHeaderViewHolder_Landroid_view_ViewGroup_Handler")]
        protected abstract global::Java.Lang.Object OnCreateSectionHeaderViewHolder(global::Android.Views.ViewGroup p0);

        static Delegate cb_onCreateSectionItemViewHolder_Landroid_view_ViewGroup_;
#pragma warning disable 0169
        static Delegate GetOnCreateSectionItemViewHolder_Landroid_view_ViewGroup_Handler()
        {
            if (cb_onCreateSectionItemViewHolder_Landroid_view_ViewGroup_ == null)
                cb_onCreateSectionItemViewHolder_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_OnCreateSectionItemViewHolder_Landroid_view_ViewGroup_);
            return cb_onCreateSectionItemViewHolder_Landroid_view_ViewGroup_;
        }

        static IntPtr n_OnCreateSectionItemViewHolder_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup>(native_p0, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.OnCreateSectionItemViewHolder(p0));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='onCreateSectionItemViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
        [Register("onCreateSectionItemViewHolder", "(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;", "GetOnCreateSectionItemViewHolder_Landroid_view_ViewGroup_Handler")]
        protected abstract global::Java.Lang.Object OnCreateSectionItemViewHolder(global::Android.Views.ViewGroup p0);

        static Delegate cb_onCreateSectionLoadingViewHolder_Landroid_view_ViewGroup_;
#pragma warning disable 0169
        static Delegate GetOnCreateSectionLoadingViewHolder_Landroid_view_ViewGroup_Handler()
        {
            if (cb_onCreateSectionLoadingViewHolder_Landroid_view_ViewGroup_ == null)
                cb_onCreateSectionLoadingViewHolder_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_OnCreateSectionLoadingViewHolder_Landroid_view_ViewGroup_);
            return cb_onCreateSectionLoadingViewHolder_Landroid_view_ViewGroup_;
        }

        static IntPtr n_OnCreateSectionLoadingViewHolder_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup>(native_p0, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.OnCreateSectionLoadingViewHolder(p0));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='onCreateSectionLoadingViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
        [Register("onCreateSectionLoadingViewHolder", "(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;", "GetOnCreateSectionLoadingViewHolder_Landroid_view_ViewGroup_Handler")]
        protected abstract global::Java.Lang.Object OnCreateSectionLoadingViewHolder(global::Android.Views.ViewGroup p0);

        //// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='onCreateViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
        //[Register("onCreateViewHolder", "(Landroid/view/ViewGroup;I)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;", "")]
        //public virtual unsafe global::Java.Lang.Object OnCreateViewHolder(global::Android.Views.ViewGroup viewGroup, int type)
        //{
        //    const string __id = "onCreateViewHolder.(Landroid/view/ViewGroup;I)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;";
        //    try
        //    {
        //        JniArgumentValue* __args = stackalloc JniArgumentValue[2];
        //        __args[0] = new JniArgumentValue((viewGroup == null) ? IntPtr.Zero : ((global::Java.Lang.Object)viewGroup).Handle);
        //        __args[1] = new JniArgumentValue(type);
        //        var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, __args);
        //        return (Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
        //    }
        //    finally
        //    {
        //        global::System.GC.KeepAlive(viewGroup);
        //    }
        //}

        static Delegate cb_onViewAttachedToWindow_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_;
#pragma warning disable 0169
        static Delegate GetOnViewAttachedToWindow_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_Handler()
        {
            if (cb_onViewAttachedToWindow_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ == null)
                cb_onViewAttachedToWindow_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_V)n_OnViewAttachedToWindow_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_);
            return cb_onViewAttachedToWindow_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_;
        }

        static void n_OnViewAttachedToWindow_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var holder = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_holder, JniHandleOwnership.DoNotTransfer);
            __this.OnViewAttachedToWindow(holder);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='onViewAttachedToWindow' and count(parameter)=1 and parameter[1][@type='VH']]"
        [Register("onViewAttachedToWindow", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;)V", "GetOnViewAttachedToWindow_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_ViewHolder_Handler")]
        public virtual unsafe void OnViewAttachedToWindow(global::Java.Lang.Object holder)
        {
            const string __id = "onViewAttachedToWindow.(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;)V";
            IntPtr native_holder = JNIEnv.ToLocalJniHandle(holder);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(native_holder);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_holder);
                global::System.GC.KeepAlive(holder);
            }
        }

        static Delegate cb_refreshCustomData;
#pragma warning disable 0169
        static Delegate GetRefreshCustomDataHandler()
        {
            if (cb_refreshCustomData == null)
                cb_refreshCustomData = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_V)n_RefreshCustomData);
            return cb_refreshCustomData;
        }

        static void n_RefreshCustomData(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.RefreshCustomData();
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='refreshCustomData' and count(parameter)=0]"
        [Register("refreshCustomData", "()V", "GetRefreshCustomDataHandler")]
        public virtual unsafe void RefreshCustomData()
        {
            const string __id = "refreshCustomData.()V";
            try
            {
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, null);
            }
            finally
            {
            }
        }

        static Delegate cb_scrollToSectionHeader_Lcom_qmuiteam_qmui_widget_section_QMUISection_Z;
#pragma warning disable 0169
        static Delegate GetScrollToSectionHeader_Lcom_qmuiteam_qmui_widget_section_QMUISection_ZHandler()
        {
            if (cb_scrollToSectionHeader_Lcom_qmuiteam_qmui_widget_section_QMUISection_Z == null)
                cb_scrollToSectionHeader_Lcom_qmuiteam_qmui_widget_section_QMUISection_Z = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLZ_V)n_ScrollToSectionHeader_Lcom_qmuiteam_qmui_widget_section_QMUISection_Z);
            return cb_scrollToSectionHeader_Lcom_qmuiteam_qmui_widget_section_QMUISection_Z;
        }

        static void n_ScrollToSectionHeader_Lcom_qmuiteam_qmui_widget_section_QMUISection_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_targetSection, bool scrollToTop)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var targetSection = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection>(native_targetSection, JniHandleOwnership.DoNotTransfer);
            __this.ScrollToSectionHeader(targetSection, scrollToTop);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='scrollToSectionHeader' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;'] and parameter[2][@type='boolean']]"
        [Register("scrollToSectionHeader", "(Lcom/qmuiteam/qmui/widget/section/QMUISection;Z)V", "GetScrollToSectionHeader_Lcom_qmuiteam_qmui_widget_section_QMUISection_ZHandler")]
        public virtual unsafe void ScrollToSectionHeader(global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection targetSection, bool scrollToTop)
        {
            const string __id = "scrollToSectionHeader.(Lcom/qmuiteam/qmui/widget/section/QMUISection;Z)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((targetSection == null) ? IntPtr.Zero : ((global::Java.Lang.Object)targetSection).Handle);
                __args[1] = new JniArgumentValue(scrollToTop);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                global::System.GC.KeepAlive(targetSection);
            }
        }

        static Delegate cb_scrollToSectionItem_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_Z;
#pragma warning disable 0169
        static Delegate GetScrollToSectionItem_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_ZHandler()
        {
            if (cb_scrollToSectionItem_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_Z == null)
                cb_scrollToSectionItem_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_Z = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLLZ_V)n_ScrollToSectionItem_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_Z);
            return cb_scrollToSectionItem_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_Z;
        }

        static void n_ScrollToSectionItem_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_targetSection, IntPtr native_targetItem, bool scrollToTop)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var targetSection = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection>(native_targetSection, JniHandleOwnership.DoNotTransfer);
            var targetItem = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_targetItem, JniHandleOwnership.DoNotTransfer);
            __this.ScrollToSectionItem(targetSection, targetItem, scrollToTop);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='scrollToSectionItem' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;'] and parameter[2][@type='T'] and parameter[3][@type='boolean']]"
        [Register("scrollToSectionItem", "(Lcom/qmuiteam/qmui/widget/section/QMUISection;Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;Z)V", "GetScrollToSectionItem_Lcom_qmuiteam_qmui_widget_section_QMUISection_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_ZHandler")]
        public virtual unsafe void ScrollToSectionItem(global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection targetSection, global::Java.Lang.Object targetItem, bool scrollToTop)
        {
            const string __id = "scrollToSectionItem.(Lcom/qmuiteam/qmui/widget/section/QMUISection;Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;Z)V";
            IntPtr native_targetItem = JNIEnv.ToLocalJniHandle(targetItem);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue((targetSection == null) ? IntPtr.Zero : ((global::Java.Lang.Object)targetSection).Handle);
                __args[1] = new JniArgumentValue(native_targetItem);
                __args[2] = new JniArgumentValue(scrollToTop);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_targetItem);
                global::System.GC.KeepAlive(targetSection);
                global::System.GC.KeepAlive(targetItem);
            }
        }

        static Delegate cb_setCallback_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_Callback_;
#pragma warning disable 0169
        static Delegate GetSetCallback_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_Callback_Handler()
        {
            if (cb_setCallback_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_Callback_ == null)
                cb_setCallback_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_Callback_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_V)n_SetCallback_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_Callback_);
            return cb_setCallback_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_Callback_;
        }

        static void n_SetCallback_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var @callback = (global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.ICallback)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.ICallback>(native__callback, JniHandleOwnership.DoNotTransfer);
            __this.SetCallback(@callback);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUIStickySectionAdapter.Callback&lt;H, T&gt;']]"
        [Register("setCallback", "(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$Callback;)V", "GetSetCallback_Lcom_qmuiteam_qmui_widget_section_QMUIStickySectionAdapter_Callback_Handler")]
        public virtual unsafe void SetCallback(global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.ICallback @callback)
        {
            const string __id = "setCallback.(Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$Callback;)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object)@callback).Handle);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                global::System.GC.KeepAlive(@callback);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;&gt;']]"
        [Register("setData", "(Ljava/util/List;)V", "")]
        public unsafe void SetData(global::System.Collections.IList data)
        {
            const string __id = "setData.(Ljava/util/List;)V";
            IntPtr native_data = global::Android.Runtime.JavaList.ToLocalJniHandle(data);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(native_data);
                _members.InstanceMethods.InvokeNonvirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_data);
                global::System.GC.KeepAlive(data);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='setData' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;&gt;'] and parameter[2][@type='boolean']]"
        [Register("setData", "(Ljava/util/List;Z)V", "")]
        public unsafe void SetData(global::System.Collections.IList data, bool onlyMutateState)
        {
            const string __id = "setData.(Ljava/util/List;Z)V";
            IntPtr native_data = global::Android.Runtime.JavaList.ToLocalJniHandle(data);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(native_data);
                __args[1] = new JniArgumentValue(onlyMutateState);
                _members.InstanceMethods.InvokeNonvirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_data);
                global::System.GC.KeepAlive(data);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='setData' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;&gt;'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
        [Register("setData", "(Ljava/util/List;ZZ)V", "")]
        public unsafe void SetData(global::System.Collections.IList data, bool onlyMutateState, bool checkLock)
        {
            const string __id = "setData.(Ljava/util/List;ZZ)V";
            IntPtr native_data = global::Android.Runtime.JavaList.ToLocalJniHandle(data);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue(native_data);
                __args[1] = new JniArgumentValue(onlyMutateState);
                __args[2] = new JniArgumentValue(checkLock);
                _members.InstanceMethods.InvokeNonvirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_data);
                global::System.GC.KeepAlive(data);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='setDataWithoutDiff' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;&gt;'] and parameter[2][@type='boolean']]"
        [Register("setDataWithoutDiff", "(Ljava/util/List;Z)V", "")]
        public unsafe void SetDataWithoutDiff(global::System.Collections.IList data, bool onlyMutateState)
        {
            const string __id = "setDataWithoutDiff.(Ljava/util/List;Z)V";
            IntPtr native_data = global::Android.Runtime.JavaList.ToLocalJniHandle(data);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(native_data);
                __args[1] = new JniArgumentValue(onlyMutateState);
                _members.InstanceMethods.InvokeNonvirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_data);
                global::System.GC.KeepAlive(data);
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='setDataWithoutDiff' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;&gt;'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
        [Register("setDataWithoutDiff", "(Ljava/util/List;ZZ)V", "")]
        public unsafe void SetDataWithoutDiff(global::System.Collections.IList data, bool onlyMutateState, bool checkLock)
        {
            const string __id = "setDataWithoutDiff.(Ljava/util/List;ZZ)V";
            IntPtr native_data = global::Android.Runtime.JavaList.ToLocalJniHandle(data);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[3];
                __args[0] = new JniArgumentValue(native_data);
                __args[1] = new JniArgumentValue(onlyMutateState);
                __args[2] = new JniArgumentValue(checkLock);
                _members.InstanceMethods.InvokeNonvirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_data);
                global::System.GC.KeepAlive(data);
            }
        }

        static Delegate cb_toggleFold_IZ;
#pragma warning disable 0169
        static Delegate GetToggleFold_IZHandler()
        {
            if (cb_toggleFold_IZ == null)
                cb_toggleFold_IZ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPIZ_V)n_ToggleFold_IZ);
            return cb_toggleFold_IZ;
        }

        static void n_ToggleFold_IZ(IntPtr jnienv, IntPtr native__this, int position, bool scrollToTop)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            __this.ToggleFold(position, scrollToTop);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='toggleFold' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
        [Register("toggleFold", "(IZ)V", "GetToggleFold_IZHandler")]
        public virtual unsafe void ToggleFold(int position, bool scrollToTop)
        {
            const string __id = "toggleFold.(IZ)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue(position);
                __args[1] = new JniArgumentValue(scrollToTop);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
            }
        }

    }

    //[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter", DoNotGenerateAcw=true)]
    //internal partial class QMUIStickySectionAdapterInvoker : QMUIStickySectionAdapter {

    //	public QMUIStickySectionAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

    //	static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter", typeof (QMUIStickySectionAdapterInvoker));

    //	public override global::Java.Interop.JniPeerMembers JniPeerMembers {
    //		get { return _members; }
    //	}

    //	protected override global::System.Type ThresholdType {
    //		get { return _members.ManagedPeerType; }
    //	}

    //	// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='onCreateCustomItemViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
    //	[Register ("onCreateCustomItemViewHolder", "(Landroid/view/ViewGroup;I)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;", "GetOnCreateCustomItemViewHolder_Landroid_view_ViewGroup_IHandler")]
    //	protected override unsafe global::Java.Lang.Object OnCreateCustomItemViewHolder (global::Android.Views.ViewGroup p0, int p1)
    //	{
    //		const string __id = "onCreateCustomItemViewHolder.(Landroid/view/ViewGroup;I)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;";
    //		try {
    //			JniArgumentValue* __args = stackalloc JniArgumentValue [2];
    //			__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
    //			__args [1] = new JniArgumentValue (p1);
    //			var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
    //			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
    //		} finally {
    //			global::System.GC.KeepAlive (p0);
    //		}
    //	}

    //	// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='onCreateSectionHeaderViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
    //	[Register ("onCreateSectionHeaderViewHolder", "(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;", "GetOnCreateSectionHeaderViewHolder_Landroid_view_ViewGroup_Handler")]
    //	protected override unsafe global::Java.Lang.Object OnCreateSectionHeaderViewHolder (global::Android.Views.ViewGroup p0)
    //	{
    //		const string __id = "onCreateSectionHeaderViewHolder.(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;";
    //		try {
    //			JniArgumentValue* __args = stackalloc JniArgumentValue [1];
    //			__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
    //			var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
    //			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
    //		} finally {
    //			global::System.GC.KeepAlive (p0);
    //		}
    //	}

    //	// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='onCreateSectionItemViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
    //	[Register ("onCreateSectionItemViewHolder", "(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;", "GetOnCreateSectionItemViewHolder_Landroid_view_ViewGroup_Handler")]
    //	protected override unsafe global::Java.Lang.Object OnCreateSectionItemViewHolder (global::Android.Views.ViewGroup p0)
    //	{
    //		const string __id = "onCreateSectionItemViewHolder.(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;";
    //		try {
    //			JniArgumentValue* __args = stackalloc JniArgumentValue [1];
    //			__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
    //			var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
    //			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
    //		} finally {
    //			global::System.GC.KeepAlive (p0);
    //		}
    //	}

    //	// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='onCreateSectionLoadingViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
    //	[Register ("onCreateSectionLoadingViewHolder", "(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;", "GetOnCreateSectionLoadingViewHolder_Landroid_view_ViewGroup_Handler")]
    //	protected override unsafe global::Java.Lang.Object OnCreateSectionLoadingViewHolder (global::Android.Views.ViewGroup p0)
    //	{
    //		const string __id = "onCreateSectionLoadingViewHolder.(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;";
    //		try {
    //			JniArgumentValue* __args = stackalloc JniArgumentValue [1];
    //			__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
    //			var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
    //			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
    //		} finally {
    //			global::System.GC.KeepAlive (p0);
    //		}
    //	}

    //	[Register ("onBindViewHolder", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V", "GetOnBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler")]
    //	public override unsafe void OnBindViewHolder (global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder holder, int position)
    //	{
    //		const string __id = "onBindViewHolder.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V";
    //		try {
    //			JniArgumentValue* __args = stackalloc JniArgumentValue [2];
    //			__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
    //			__args [1] = new JniArgumentValue (position);
    //			_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
    //		} finally {
    //			global::System.GC.KeepAlive (holder);
    //		}
    //	}

    //	[Register ("onCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", "GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler")]
    //	public  override unsafe global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder OnCreateViewHolder (global::Android.Views.ViewGroup parent, int viewType)
    //	{
    //		const string __id = "onCreateViewHolder.(Landroid/view/ViewGroup;I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;";
    //		try {
    //			JniArgumentValue* __args = stackalloc JniArgumentValue [2];
    //			__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
    //			__args [1] = new JniArgumentValue (viewType);
    //			var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
    //			return global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
    //		} finally {
    //			global::System.GC.KeepAlive (parent);
    //		}
    //	}


    //   }

}
