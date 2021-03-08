using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Section
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIDefaultStickySectionAdapter']"
    [global::Android.Runtime.Register("com/qmuiteam/qmui/widget/section/QMUIDefaultStickySectionAdapter", DoNotGenerateAcw = true)]
    [global::Java.Interop.JavaTypeParameters(new string[] { "H extends com.qmuiteam.qmui.widget.section.QMUISection.Model<H>", "T extends com.qmuiteam.qmui.widget.section.QMUISection.Model<T>" })]
    public abstract partial class QMUIDefaultStickySectionAdapter : global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter
    {

        static readonly JniPeerMembers _members = new XAPeerMembers("com/qmuiteam/qmui/widget/section/QMUIDefaultStickySectionAdapter", typeof(QMUIDefaultStickySectionAdapter));
        internal static new IntPtr class_ref
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

        protected QMUIDefaultStickySectionAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIDefaultStickySectionAdapter']/constructor[@name='QMUIDefaultStickySectionAdapter' and count(parameter)=0]"
        [Register(".ctor", "()V", "")]
        public unsafe QMUIDefaultStickySectionAdapter()
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

        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIDefaultStickySectionAdapter']/constructor[@name='QMUIDefaultStickySectionAdapter' and count(parameter)=1 and parameter[1][@type='boolean']]"
        [Register(".ctor", "(Z)V", "")]
        public unsafe QMUIDefaultStickySectionAdapter(bool removeSectionTitleIfOnlyOneSection)
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

        static Delegate cb_onCreateCustomItemViewHolder_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
        static Delegate GetOnCreateCustomItemViewHolder_Landroid_view_ViewGroup_IHandler()
        {
            if (cb_onCreateCustomItemViewHolder_Landroid_view_ViewGroup_I == null)
                cb_onCreateCustomItemViewHolder_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLI_L)n_OnCreateCustomItemViewHolder_Landroid_view_ViewGroup_I);
            return cb_onCreateCustomItemViewHolder_Landroid_view_ViewGroup_I;
        }

        static IntPtr n_OnCreateCustomItemViewHolder_Landroid_view_ViewGroup_I(IntPtr jnienv, IntPtr native__this, IntPtr native_viewGroup, int type)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIDefaultStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var viewGroup = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup>(native_viewGroup, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.OnCreateCustomItemViewHolder(viewGroup, type));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIDefaultStickySectionAdapter']/method[@name='onCreateCustomItemViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
        [Register("onCreateCustomItemViewHolder", "(Landroid/view/ViewGroup;I)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;", "GetOnCreateCustomItemViewHolder_Landroid_view_ViewGroup_IHandler")]
        protected override unsafe global::Java.Lang.Object OnCreateCustomItemViewHolder(global::Android.Views.ViewGroup viewGroup, int type)
        {
            const string __id = "onCreateCustomItemViewHolder.(Landroid/view/ViewGroup;I)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((viewGroup == null) ? IntPtr.Zero : ((global::Java.Lang.Object)viewGroup).Handle);
                __args[1] = new JniArgumentValue(type);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.ViewHolder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                global::System.GC.KeepAlive(viewGroup);
            }
        }

        static Delegate cb_onCreateSectionLoadingViewHolder_Landroid_view_ViewGroup_;
#pragma warning disable 0169
        static Delegate GetOnCreateSectionLoadingViewHolder_Landroid_view_ViewGroup_Handler()
        {
            if (cb_onCreateSectionLoadingViewHolder_Landroid_view_ViewGroup_ == null)
                cb_onCreateSectionLoadingViewHolder_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_OnCreateSectionLoadingViewHolder_Landroid_view_ViewGroup_);
            return cb_onCreateSectionLoadingViewHolder_Landroid_view_ViewGroup_;
        }

        static IntPtr n_OnCreateSectionLoadingViewHolder_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewGroup)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIDefaultStickySectionAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var viewGroup = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup>(native_viewGroup, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.OnCreateSectionLoadingViewHolder(viewGroup));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIDefaultStickySectionAdapter']/method[@name='onCreateSectionLoadingViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
        [Register("onCreateSectionLoadingViewHolder", "(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;", "GetOnCreateSectionLoadingViewHolder_Landroid_view_ViewGroup_Handler")]
        protected override unsafe global::Java.Lang.Object OnCreateSectionLoadingViewHolder(global::Android.Views.ViewGroup viewGroup)
        {
            const string __id = "onCreateSectionLoadingViewHolder.(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((viewGroup == null) ? IntPtr.Zero : ((global::Java.Lang.Object)viewGroup).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUIStickySectionAdapter.ViewHolder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                global::System.GC.KeepAlive(viewGroup);
            }
        }

    }

    //[global::Android.Runtime.Register("com/qmuiteam/qmui/widget/section/QMUIDefaultStickySectionAdapter", DoNotGenerateAcw = true)]
    //internal partial class QMUIDefaultStickySectionAdapterInvoker : QMUIDefaultStickySectionAdapter
    //{

    //    public QMUIDefaultStickySectionAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer) { }

    //    static readonly JniPeerMembers _members = new XAPeerMembers("com/qmuiteam/qmui/widget/section/QMUIDefaultStickySectionAdapter", typeof(QMUIDefaultStickySectionAdapterInvoker));

    //    public override global::Java.Interop.JniPeerMembers JniPeerMembers
    //    {
    //        get { return _members; }
    //    }

    //    protected override global::System.Type ThresholdType
    //    {
    //        get { return _members.ManagedPeerType; }
    //    }

    //    // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='onCreateSectionHeaderViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
    //    [Register("onCreateSectionHeaderViewHolder", "(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;", "GetOnCreateSectionHeaderViewHolder_Landroid_view_ViewGroup_Handler")]
    //    protected override unsafe global::Java.Lang.Object OnCreateSectionHeaderViewHolder(global::Android.Views.ViewGroup p0)
    //    {
    //        const string __id = "onCreateSectionHeaderViewHolder.(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;";
    //        try
    //        {
    //            JniArgumentValue* __args = stackalloc JniArgumentValue[1];
    //            __args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
    //            var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
    //            return (Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
    //        }
    //        finally
    //        {
    //            global::System.GC.KeepAlive(p0);
    //        }
    //    }

    //    // Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUIStickySectionAdapter']/method[@name='onCreateSectionItemViewHolder' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
    //    [Register("onCreateSectionItemViewHolder", "(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;", "GetOnCreateSectionItemViewHolder_Landroid_view_ViewGroup_Handler")]
    //    protected override unsafe global::Java.Lang.Object OnCreateSectionItemViewHolder(global::Android.Views.ViewGroup p0)
    //    {
    //        const string __id = "onCreateSectionItemViewHolder.(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/widget/section/QMUIStickySectionAdapter$ViewHolder;";
    //        try
    //        {
    //            JniArgumentValue* __args = stackalloc JniArgumentValue[1];
    //            __args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
    //            var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
    //            return (Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
    //        }
    //        finally
    //        {
    //            global::System.GC.KeepAlive(p0);
    //        }
    //    }

    //    [Register("onBindViewHolder", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V", "GetOnBindViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler")]
    //    public override unsafe void OnBindViewHolder(global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder holder, int position)
    //    {
    //        const string __id = "onBindViewHolder.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V";
    //        try
    //        {
    //            JniArgumentValue* __args = stackalloc JniArgumentValue[2];
    //            __args[0] = new JniArgumentValue((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object)holder).Handle);
    //            __args[1] = new JniArgumentValue(position);
    //            _members.InstanceMethods.InvokeAbstractVoidMethod(__id, this, __args);
    //        }
    //        finally
    //        {
    //            global::System.GC.KeepAlive(holder);
    //        }
    //    }

    //    [Register("onCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", "GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler")]
    //    public override unsafe global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder OnCreateViewHolder(global::Android.Views.ViewGroup parent, int viewType)
    //    {
    //        const string __id = "onCreateViewHolder.(Landroid/view/ViewGroup;I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;";
    //        try
    //        {
    //            JniArgumentValue* __args = stackalloc JniArgumentValue[2];
    //            __args[0] = new JniArgumentValue((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object)parent).Handle);
    //            __args[1] = new JniArgumentValue(viewType);
    //            var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
    //            return global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
    //        }
    //        finally
    //        {
    //            global::System.GC.KeepAlive(parent);
    //        }
    //    }

       
      
    //}

}
