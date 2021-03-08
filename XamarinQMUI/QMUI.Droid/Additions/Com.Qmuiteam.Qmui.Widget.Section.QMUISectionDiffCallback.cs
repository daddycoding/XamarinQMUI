using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Section {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISectionDiffCallback']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/section/QMUISectionDiffCallback", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"H extends com.qmuiteam.qmui.widget.section.QMUISection.Model<H>", "T extends com.qmuiteam.qmui.widget.section.QMUISection.Model<T>"})]
	public partial class QMUISectionDiffCallback : global::AndroidX.RecyclerView.Widget.DiffUtil.Callback {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISectionDiffCallback.IndexGenerationInfo']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/section/QMUISectionDiffCallback$IndexGenerationInfo", DoNotGenerateAcw=true)]
		public partial class IndexGenerationInfo : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/section/QMUISectionDiffCallback$IndexGenerationInfo", typeof (IndexGenerationInfo));
			internal static IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected IndexGenerationInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISectionDiffCallback.IndexGenerationInfo']/method[@name='appendCustomIndex' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("appendCustomIndex", "(II)V", "")]
			public unsafe void AppendCustomIndex (int sectionIndex, int itemIndex)
			{
				const string __id = "appendCustomIndex.(II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (sectionIndex);
					__args [1] = new JniArgumentValue (itemIndex);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISectionDiffCallback.IndexGenerationInfo']/method[@name='appendWholeListCustomIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("appendWholeListCustomIndex", "(I)V", "")]
			public unsafe void AppendWholeListCustomIndex (int itemIndex)
			{
				const string __id = "appendWholeListCustomIndex.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (itemIndex);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/section/QMUISectionDiffCallback", typeof (QMUISectionDiffCallback));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected QMUISectionDiffCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISectionDiffCallback']/constructor[@name='QMUISectionDiffCallback' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;&gt;'] and parameter[2][@type='java.util.List&lt;com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;&gt;']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/util/List;)V", "")]
		public unsafe QMUISectionDiffCallback (global::System.Collections.IList oldList, global::System.Collections.IList newList)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_oldList = global::Android.Runtime.JavaList.ToLocalJniHandle (oldList);
			IntPtr native_newList = global::Android.Runtime.JavaList.ToLocalJniHandle (newList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_oldList);
				__args [1] = new JniArgumentValue (native_newList);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_oldList);
				JNIEnv.DeleteLocalRef (native_newList);
				global::System.GC.KeepAlive (oldList);
				global::System.GC.KeepAlive (newList);
			}
		}

		static Delegate cb_getNewListSize;
#pragma warning disable 0169
		static Delegate GetGetNewListSizeHandler ()
		{
			if (cb_getNewListSize == null)
				cb_getNewListSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNewListSize);
			return cb_getNewListSize;
		}

		static int n_GetNewListSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NewListSize;
		}
#pragma warning restore 0169

		public override unsafe int NewListSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISectionDiffCallback']/method[@name='getNewListSize' and count(parameter)=0]"
			[Register ("getNewListSize", "()I", "GetGetNewListSizeHandler")]
			get {
				const string __id = "getNewListSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOldListSize;
#pragma warning disable 0169
		static Delegate GetGetOldListSizeHandler ()
		{
			if (cb_getOldListSize == null)
				cb_getOldListSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetOldListSize);
			return cb_getOldListSize;
		}

		static int n_GetOldListSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OldListSize;
		}
#pragma warning restore 0169

		public override unsafe int OldListSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISectionDiffCallback']/method[@name='getOldListSize' and count(parameter)=0]"
			[Register ("getOldListSize", "()I", "GetGetOldListSizeHandler")]
			get {
				const string __id = "getOldListSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_areContentsTheSame_II;
#pragma warning disable 0169
		static Delegate GetAreContentsTheSame_IIHandler ()
		{
			if (cb_areContentsTheSame_II == null)
				cb_areContentsTheSame_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_Z) n_AreContentsTheSame_II);
			return cb_areContentsTheSame_II;
		}

		static bool n_AreContentsTheSame_II (IntPtr jnienv, IntPtr native__this, int oldItemPosition, int newItemPosition)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AreContentsTheSame (oldItemPosition, newItemPosition);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISectionDiffCallback']/method[@name='areContentsTheSame' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("areContentsTheSame", "(II)Z", "GetAreContentsTheSame_IIHandler")]
		public override unsafe bool AreContentsTheSame (int oldItemPosition, int newItemPosition)
		{
			const string __id = "areContentsTheSame.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (oldItemPosition);
				__args [1] = new JniArgumentValue (newItemPosition);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_areCustomContentsTheSame_Lcom_qmuiteam_qmui_widget_section_QMUISection_ILcom_qmuiteam_qmui_widget_section_QMUISection_I;
#pragma warning disable 0169
		static Delegate GetAreCustomContentsTheSame_Lcom_qmuiteam_qmui_widget_section_QMUISection_ILcom_qmuiteam_qmui_widget_section_QMUISection_IHandler ()
		{
			if (cb_areCustomContentsTheSame_Lcom_qmuiteam_qmui_widget_section_QMUISection_ILcom_qmuiteam_qmui_widget_section_QMUISection_I == null)
				cb_areCustomContentsTheSame_Lcom_qmuiteam_qmui_widget_section_QMUISection_ILcom_qmuiteam_qmui_widget_section_QMUISection_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILI_Z) n_AreCustomContentsTheSame_Lcom_qmuiteam_qmui_widget_section_QMUISection_ILcom_qmuiteam_qmui_widget_section_QMUISection_I);
			return cb_areCustomContentsTheSame_Lcom_qmuiteam_qmui_widget_section_QMUISection_ILcom_qmuiteam_qmui_widget_section_QMUISection_I;
		}

		static bool n_AreCustomContentsTheSame_Lcom_qmuiteam_qmui_widget_section_QMUISection_ILcom_qmuiteam_qmui_widget_section_QMUISection_I (IntPtr jnienv, IntPtr native__this, IntPtr native_oldSection, int oldItemIndex, IntPtr native_newSection, int newItemIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var oldSection = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (native_oldSection, JniHandleOwnership.DoNotTransfer);
			var newSection = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (native_newSection, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AreCustomContentsTheSame (oldSection, oldItemIndex, newSection, newItemIndex);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISectionDiffCallback']/method[@name='areCustomContentsTheSame' and count(parameter)=4 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;'] and parameter[2][@type='int'] and parameter[3][@type='com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;'] and parameter[4][@type='int']]"
		[Register ("areCustomContentsTheSame", "(Lcom/qmuiteam/qmui/widget/section/QMUISection;ILcom/qmuiteam/qmui/widget/section/QMUISection;I)Z", "GetAreCustomContentsTheSame_Lcom_qmuiteam_qmui_widget_section_QMUISection_ILcom_qmuiteam_qmui_widget_section_QMUISection_IHandler")]
		protected virtual unsafe bool AreCustomContentsTheSame (global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection oldSection, int oldItemIndex, global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection newSection, int newItemIndex)
		{
			const string __id = "areCustomContentsTheSame.(Lcom/qmuiteam/qmui/widget/section/QMUISection;ILcom/qmuiteam/qmui/widget/section/QMUISection;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((oldSection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) oldSection).Handle);
				__args [1] = new JniArgumentValue (oldItemIndex);
				__args [2] = new JniArgumentValue ((newSection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newSection).Handle);
				__args [3] = new JniArgumentValue (newItemIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (oldSection);
				global::System.GC.KeepAlive (newSection);
			}
		}

		static Delegate cb_areItemsTheSame_II;
#pragma warning disable 0169
		static Delegate GetAreItemsTheSame_IIHandler ()
		{
			if (cb_areItemsTheSame_II == null)
				cb_areItemsTheSame_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_Z) n_AreItemsTheSame_II);
			return cb_areItemsTheSame_II;
		}

		static bool n_AreItemsTheSame_II (IntPtr jnienv, IntPtr native__this, int oldItemPosition, int newItemPosition)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AreItemsTheSame (oldItemPosition, newItemPosition);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISectionDiffCallback']/method[@name='areItemsTheSame' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("areItemsTheSame", "(II)Z", "GetAreItemsTheSame_IIHandler")]
		public override unsafe bool AreItemsTheSame (int oldItemPosition, int newItemPosition)
		{
			const string __id = "areItemsTheSame.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (oldItemPosition);
				__args [1] = new JniArgumentValue (newItemPosition);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_cloneNewIndexTo_Landroid_util_SparseIntArray_Landroid_util_SparseIntArray_;
#pragma warning disable 0169
		static Delegate GetCloneNewIndexTo_Landroid_util_SparseIntArray_Landroid_util_SparseIntArray_Handler ()
		{
			if (cb_cloneNewIndexTo_Landroid_util_SparseIntArray_Landroid_util_SparseIntArray_ == null)
				cb_cloneNewIndexTo_Landroid_util_SparseIntArray_Landroid_util_SparseIntArray_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CloneNewIndexTo_Landroid_util_SparseIntArray_Landroid_util_SparseIntArray_);
			return cb_cloneNewIndexTo_Landroid_util_SparseIntArray_Landroid_util_SparseIntArray_;
		}

		static void n_CloneNewIndexTo_Landroid_util_SparseIntArray_Landroid_util_SparseIntArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sectionIndex, IntPtr native_itemIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sectionIndex = global::Java.Lang.Object.GetObject<global::Android.Util.SparseIntArray> (native_sectionIndex, JniHandleOwnership.DoNotTransfer);
			var itemIndex = global::Java.Lang.Object.GetObject<global::Android.Util.SparseIntArray> (native_itemIndex, JniHandleOwnership.DoNotTransfer);
			__this.CloneNewIndexTo (sectionIndex, itemIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISectionDiffCallback']/method[@name='cloneNewIndexTo' and count(parameter)=2 and parameter[1][@type='android.util.SparseIntArray'] and parameter[2][@type='android.util.SparseIntArray']]"
		[Register ("cloneNewIndexTo", "(Landroid/util/SparseIntArray;Landroid/util/SparseIntArray;)V", "GetCloneNewIndexTo_Landroid_util_SparseIntArray_Landroid_util_SparseIntArray_Handler")]
		public virtual unsafe void CloneNewIndexTo (global::Android.Util.SparseIntArray sectionIndex, global::Android.Util.SparseIntArray itemIndex)
		{
			const string __id = "cloneNewIndexTo.(Landroid/util/SparseIntArray;Landroid/util/SparseIntArray;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sectionIndex == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sectionIndex).Handle);
				__args [1] = new JniArgumentValue ((itemIndex == null) ? IntPtr.Zero : ((global::Java.Lang.Object) itemIndex).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (sectionIndex);
				global::System.GC.KeepAlive (itemIndex);
			}
		}

		static Delegate cb_onGenerateCustomIndexAfterItemList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Lcom_qmuiteam_qmui_widget_section_QMUISection_I;
#pragma warning disable 0169
		static Delegate GetOnGenerateCustomIndexAfterItemList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Lcom_qmuiteam_qmui_widget_section_QMUISection_IHandler ()
		{
			if (cb_onGenerateCustomIndexAfterItemList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Lcom_qmuiteam_qmui_widget_section_QMUISection_I == null)
				cb_onGenerateCustomIndexAfterItemList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Lcom_qmuiteam_qmui_widget_section_QMUISection_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_OnGenerateCustomIndexAfterItemList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Lcom_qmuiteam_qmui_widget_section_QMUISection_I);
			return cb_onGenerateCustomIndexAfterItemList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Lcom_qmuiteam_qmui_widget_section_QMUISection_I;
		}

		static void n_OnGenerateCustomIndexAfterItemList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Lcom_qmuiteam_qmui_widget_section_QMUISection_I (IntPtr jnienv, IntPtr native__this, IntPtr native_generationInfo, IntPtr native_section, int sectionIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var generationInfo = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback.IndexGenerationInfo> (native_generationInfo, JniHandleOwnership.DoNotTransfer);
			var section = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (native_section, JniHandleOwnership.DoNotTransfer);
			__this.OnGenerateCustomIndexAfterItemList (generationInfo, section, sectionIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISectionDiffCallback']/method[@name='onGenerateCustomIndexAfterItemList' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUISectionDiffCallback.IndexGenerationInfo'] and parameter[2][@type='com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;'] and parameter[3][@type='int']]"
		[Register ("onGenerateCustomIndexAfterItemList", "(Lcom/qmuiteam/qmui/widget/section/QMUISectionDiffCallback$IndexGenerationInfo;Lcom/qmuiteam/qmui/widget/section/QMUISection;I)V", "GetOnGenerateCustomIndexAfterItemList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Lcom_qmuiteam_qmui_widget_section_QMUISection_IHandler")]
		protected virtual unsafe void OnGenerateCustomIndexAfterItemList (global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback.IndexGenerationInfo generationInfo, global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection section, int sectionIndex)
		{
			const string __id = "onGenerateCustomIndexAfterItemList.(Lcom/qmuiteam/qmui/widget/section/QMUISectionDiffCallback$IndexGenerationInfo;Lcom/qmuiteam/qmui/widget/section/QMUISection;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((generationInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) generationInfo).Handle);
				__args [1] = new JniArgumentValue ((section == null) ? IntPtr.Zero : ((global::Java.Lang.Object) section).Handle);
				__args [2] = new JniArgumentValue (sectionIndex);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (generationInfo);
				global::System.GC.KeepAlive (section);
			}
		}

		static Delegate cb_onGenerateCustomIndexAfterSectionList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnGenerateCustomIndexAfterSectionList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Ljava_util_List_Handler ()
		{
			if (cb_onGenerateCustomIndexAfterSectionList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Ljava_util_List_ == null)
				cb_onGenerateCustomIndexAfterSectionList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnGenerateCustomIndexAfterSectionList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Ljava_util_List_);
			return cb_onGenerateCustomIndexAfterSectionList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Ljava_util_List_;
		}

		static void n_OnGenerateCustomIndexAfterSectionList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_generationInfo, IntPtr native_list)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var generationInfo = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback.IndexGenerationInfo> (native_generationInfo, JniHandleOwnership.DoNotTransfer);
			var list = global::Android.Runtime.JavaList.FromJniHandle (native_list, JniHandleOwnership.DoNotTransfer);
			__this.OnGenerateCustomIndexAfterSectionList (generationInfo, list);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISectionDiffCallback']/method[@name='onGenerateCustomIndexAfterSectionList' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUISectionDiffCallback.IndexGenerationInfo'] and parameter[2][@type='java.util.List&lt;com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;&gt;']]"
		[Register ("onGenerateCustomIndexAfterSectionList", "(Lcom/qmuiteam/qmui/widget/section/QMUISectionDiffCallback$IndexGenerationInfo;Ljava/util/List;)V", "GetOnGenerateCustomIndexAfterSectionList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Ljava_util_List_Handler")]
		protected virtual unsafe void OnGenerateCustomIndexAfterSectionList (global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback.IndexGenerationInfo generationInfo, global::System.Collections.IList list)
		{
			const string __id = "onGenerateCustomIndexAfterSectionList.(Lcom/qmuiteam/qmui/widget/section/QMUISectionDiffCallback$IndexGenerationInfo;Ljava/util/List;)V";
			IntPtr native_list = global::Android.Runtime.JavaList.ToLocalJniHandle (list);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((generationInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) generationInfo).Handle);
				__args [1] = new JniArgumentValue (native_list);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
				global::System.GC.KeepAlive (generationInfo);
				global::System.GC.KeepAlive (list);
			}
		}

		static Delegate cb_onGenerateCustomIndexBeforeItemList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Lcom_qmuiteam_qmui_widget_section_QMUISection_I;
#pragma warning disable 0169
		static Delegate GetOnGenerateCustomIndexBeforeItemList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Lcom_qmuiteam_qmui_widget_section_QMUISection_IHandler ()
		{
			if (cb_onGenerateCustomIndexBeforeItemList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Lcom_qmuiteam_qmui_widget_section_QMUISection_I == null)
				cb_onGenerateCustomIndexBeforeItemList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Lcom_qmuiteam_qmui_widget_section_QMUISection_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_OnGenerateCustomIndexBeforeItemList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Lcom_qmuiteam_qmui_widget_section_QMUISection_I);
			return cb_onGenerateCustomIndexBeforeItemList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Lcom_qmuiteam_qmui_widget_section_QMUISection_I;
		}

		static void n_OnGenerateCustomIndexBeforeItemList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Lcom_qmuiteam_qmui_widget_section_QMUISection_I (IntPtr jnienv, IntPtr native__this, IntPtr native_generationInfo, IntPtr native_section, int sectionIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var generationInfo = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback.IndexGenerationInfo> (native_generationInfo, JniHandleOwnership.DoNotTransfer);
			var section = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (native_section, JniHandleOwnership.DoNotTransfer);
			__this.OnGenerateCustomIndexBeforeItemList (generationInfo, section, sectionIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISectionDiffCallback']/method[@name='onGenerateCustomIndexBeforeItemList' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUISectionDiffCallback.IndexGenerationInfo'] and parameter[2][@type='com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;'] and parameter[3][@type='int']]"
		[Register ("onGenerateCustomIndexBeforeItemList", "(Lcom/qmuiteam/qmui/widget/section/QMUISectionDiffCallback$IndexGenerationInfo;Lcom/qmuiteam/qmui/widget/section/QMUISection;I)V", "GetOnGenerateCustomIndexBeforeItemList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Lcom_qmuiteam_qmui_widget_section_QMUISection_IHandler")]
		protected virtual unsafe void OnGenerateCustomIndexBeforeItemList (global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback.IndexGenerationInfo generationInfo, global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection section, int sectionIndex)
		{
			const string __id = "onGenerateCustomIndexBeforeItemList.(Lcom/qmuiteam/qmui/widget/section/QMUISectionDiffCallback$IndexGenerationInfo;Lcom/qmuiteam/qmui/widget/section/QMUISection;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((generationInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) generationInfo).Handle);
				__args [1] = new JniArgumentValue ((section == null) ? IntPtr.Zero : ((global::Java.Lang.Object) section).Handle);
				__args [2] = new JniArgumentValue (sectionIndex);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (generationInfo);
				global::System.GC.KeepAlive (section);
			}
		}

		static Delegate cb_onGenerateCustomIndexBeforeSectionList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnGenerateCustomIndexBeforeSectionList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Ljava_util_List_Handler ()
		{
			if (cb_onGenerateCustomIndexBeforeSectionList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Ljava_util_List_ == null)
				cb_onGenerateCustomIndexBeforeSectionList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnGenerateCustomIndexBeforeSectionList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Ljava_util_List_);
			return cb_onGenerateCustomIndexBeforeSectionList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Ljava_util_List_;
		}

		static void n_OnGenerateCustomIndexBeforeSectionList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_generationInfo, IntPtr native_list)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var generationInfo = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback.IndexGenerationInfo> (native_generationInfo, JniHandleOwnership.DoNotTransfer);
			var list = global::Android.Runtime.JavaList.FromJniHandle (native_list, JniHandleOwnership.DoNotTransfer);
			__this.OnGenerateCustomIndexBeforeSectionList (generationInfo, list);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISectionDiffCallback']/method[@name='onGenerateCustomIndexBeforeSectionList' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUISectionDiffCallback.IndexGenerationInfo'] and parameter[2][@type='java.util.List&lt;com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;&gt;']]"
		[Register ("onGenerateCustomIndexBeforeSectionList", "(Lcom/qmuiteam/qmui/widget/section/QMUISectionDiffCallback$IndexGenerationInfo;Ljava/util/List;)V", "GetOnGenerateCustomIndexBeforeSectionList_Lcom_qmuiteam_qmui_widget_section_QMUISectionDiffCallback_IndexGenerationInfo_Ljava_util_List_Handler")]
		protected virtual unsafe void OnGenerateCustomIndexBeforeSectionList (global::Com.Qmuiteam.Qmui.Widget.Section.QMUISectionDiffCallback.IndexGenerationInfo generationInfo, global::System.Collections.IList list)
		{
			const string __id = "onGenerateCustomIndexBeforeSectionList.(Lcom/qmuiteam/qmui/widget/section/QMUISectionDiffCallback$IndexGenerationInfo;Ljava/util/List;)V";
			IntPtr native_list = global::Android.Runtime.JavaList.ToLocalJniHandle (list);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((generationInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) generationInfo).Handle);
				__args [1] = new JniArgumentValue (native_list);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
				global::System.GC.KeepAlive (generationInfo);
				global::System.GC.KeepAlive (list);
			}
		}

	}
}
