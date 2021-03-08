using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Section {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/section/QMUISection", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"H extends com.qmuiteam.qmui.widget.section.QMUISection.Model<H>", "T extends com.qmuiteam.qmui.widget.section.QMUISection.Model<T>"})]
	public partial class QMUISection : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/field[@name='ITEM_INDEX_CUSTOM_OFFSET']"
		[Register ("ITEM_INDEX_CUSTOM_OFFSET")]
		public const int ItemIndexCustomOffset = (int) -1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/field[@name='ITEM_INDEX_INTERNAL_END']"
		[Register ("ITEM_INDEX_INTERNAL_END")]
		public const int ItemIndexInternalEnd = (int) -4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/field[@name='ITEM_INDEX_LOAD_AFTER']"
		[Register ("ITEM_INDEX_LOAD_AFTER")]
		public const int ItemIndexLoadAfter = (int) -4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/field[@name='ITEM_INDEX_LOAD_BEFORE']"
		[Register ("ITEM_INDEX_LOAD_BEFORE")]
		public const int ItemIndexLoadBefore = (int) -3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/field[@name='ITEM_INDEX_SECTION_HEADER']"
		[Register ("ITEM_INDEX_SECTION_HEADER")]
		public const int ItemIndexSectionHeader = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/field[@name='ITEM_INDEX_UNKNOWN']"
		[Register ("ITEM_INDEX_UNKNOWN")]
		public const int ItemIndexUnknown = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/field[@name='SECTION_INDEX_UNKNOWN']"
		[Register ("SECTION_INDEX_UNKNOWN")]
		public const int SectionIndexUnknown = (int) -1;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUISection.Model']"
		[Register ("com/qmuiteam/qmui/widget/section/QMUISection$Model", "", "Com.Qmuiteam.Qmui.Widget.Section.QMUISection/IModelInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial interface IModel : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUISection.Model']/method[@name='cloneForDiff' and count(parameter)=0]"
			[Register ("cloneForDiff", "()Ljava/lang/Object;", "GetCloneForDiffHandler:Com.Qmuiteam.Qmui.Widget.Section.QMUISection/IModelInvoker, QMUI.Droid")]
			global::Java.Lang.Object CloneForDiff ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUISection.Model']/method[@name='isSameContent' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("isSameContent", "(Ljava/lang/Object;)Z", "GetIsSameContent_Ljava_lang_Object_Handler:Com.Qmuiteam.Qmui.Widget.Section.QMUISection/IModelInvoker, QMUI.Droid")]
			bool IsSameContent (global::Java.Lang.Object other);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/interface[@name='QMUISection.Model']/method[@name='isSameItem' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("isSameItem", "(Ljava/lang/Object;)Z", "GetIsSameItem_Ljava_lang_Object_Handler:Com.Qmuiteam.Qmui.Widget.Section.QMUISection/IModelInvoker, QMUI.Droid")]
			bool IsSameItem (global::Java.Lang.Object other);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/section/QMUISection$Model", DoNotGenerateAcw=true)]
		internal partial class IModelInvoker : global::Java.Lang.Object, IModel {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/section/QMUISection$Model", typeof (IModelInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IModel GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IModel> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.section.QMUISection.Model"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IModelInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_cloneForDiff;
#pragma warning disable 0169
			static Delegate GetCloneForDiffHandler ()
			{
				if (cb_cloneForDiff == null)
					cb_cloneForDiff = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CloneForDiff);
				return cb_cloneForDiff;
			}

			static IntPtr n_CloneForDiff (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection.IModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CloneForDiff ());
			}
#pragma warning restore 0169

			IntPtr id_cloneForDiff;
			public unsafe global::Java.Lang.Object CloneForDiff ()
			{
				if (id_cloneForDiff == IntPtr.Zero)
					id_cloneForDiff = JNIEnv.GetMethodID (class_ref, "cloneForDiff", "()Ljava/lang/Object;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cloneForDiff), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_isSameContent_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetIsSameContent_Ljava_lang_Object_Handler ()
			{
				if (cb_isSameContent_Ljava_lang_Object_ == null)
					cb_isSameContent_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsSameContent_Ljava_lang_Object_);
				return cb_isSameContent_Ljava_lang_Object_;
			}

			static bool n_IsSameContent_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection.IModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var other = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_other, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.IsSameContent (other);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_isSameContent_Ljava_lang_Object_;
			public unsafe bool IsSameContent (global::Java.Lang.Object other)
			{
				if (id_isSameContent_Ljava_lang_Object_ == IntPtr.Zero)
					id_isSameContent_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "isSameContent", "(Ljava/lang/Object;)Z");
				IntPtr native_other = JNIEnv.ToLocalJniHandle (other);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_other);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSameContent_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_other);
				return __ret;
			}

			static Delegate cb_isSameItem_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetIsSameItem_Ljava_lang_Object_Handler ()
			{
				if (cb_isSameItem_Ljava_lang_Object_ == null)
					cb_isSameItem_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsSameItem_Ljava_lang_Object_);
				return cb_isSameItem_Ljava_lang_Object_;
			}

			static bool n_IsSameItem_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection.IModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var other = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_other, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.IsSameItem (other);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_isSameItem_Ljava_lang_Object_;
			public unsafe bool IsSameItem (global::Java.Lang.Object other)
			{
				if (id_isSameItem_Ljava_lang_Object_ == IntPtr.Zero)
					id_isSameItem_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "isSameItem", "(Ljava/lang/Object;)Z");
				IntPtr native_other = JNIEnv.ToLocalJniHandle (other);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_other);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSameItem_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_other);
				return __ret;
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/section/QMUISection", typeof (QMUISection));
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

		protected QMUISection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/constructor[@name='QMUISection' and count(parameter)=2 and parameter[1][@type='H'] and parameter[2][@type='java.util.List&lt;T&gt;']]"
		[Register (".ctor", "(Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;Ljava/util/List;)V", "")]
		public unsafe QMUISection (global::Java.Lang.Object header, global::System.Collections.IList itemList)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_header = JNIEnv.ToLocalJniHandle (header);
			IntPtr native_itemList = global::Android.Runtime.JavaList.ToLocalJniHandle (itemList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_header);
				__args [1] = new JniArgumentValue (native_itemList);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_header);
				JNIEnv.DeleteLocalRef (native_itemList);
				global::System.GC.KeepAlive (header);
				global::System.GC.KeepAlive (itemList);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/constructor[@name='QMUISection' and count(parameter)=3 and parameter[1][@type='H'] and parameter[2][@type='java.util.List&lt;T&gt;'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;Ljava/util/List;Z)V", "")]
		public unsafe QMUISection (global::Java.Lang.Object header, global::System.Collections.IList itemList, bool isFold)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;Ljava/util/List;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_header = JNIEnv.ToLocalJniHandle (header);
			IntPtr native_itemList = global::Android.Runtime.JavaList.ToLocalJniHandle (itemList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_header);
				__args [1] = new JniArgumentValue (native_itemList);
				__args [2] = new JniArgumentValue (isFold);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_header);
				JNIEnv.DeleteLocalRef (native_itemList);
				global::System.GC.KeepAlive (header);
				global::System.GC.KeepAlive (itemList);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/constructor[@name='QMUISection' and count(parameter)=6 and parameter[1][@type='H'] and parameter[2][@type='java.util.List&lt;T&gt;'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean']]"
		[Register (".ctor", "(Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;Ljava/util/List;ZZZZ)V", "")]
		public unsafe QMUISection (global::Java.Lang.Object header, global::System.Collections.IList itemList, bool isFold, bool isLocked, bool existBeforeDataToLoad, bool existAfterDataToLoad)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;Ljava/util/List;ZZZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_header = JNIEnv.ToLocalJniHandle (header);
			IntPtr native_itemList = global::Android.Runtime.JavaList.ToLocalJniHandle (itemList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_header);
				__args [1] = new JniArgumentValue (native_itemList);
				__args [2] = new JniArgumentValue (isFold);
				__args [3] = new JniArgumentValue (isLocked);
				__args [4] = new JniArgumentValue (existBeforeDataToLoad);
				__args [5] = new JniArgumentValue (existAfterDataToLoad);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_header);
				JNIEnv.DeleteLocalRef (native_itemList);
				global::System.GC.KeepAlive (header);
				global::System.GC.KeepAlive (itemList);
			}
		}

		static Delegate cb_isErrorToLoadAfter;
#pragma warning disable 0169
		static Delegate GetIsErrorToLoadAfterHandler ()
		{
			if (cb_isErrorToLoadAfter == null)
				cb_isErrorToLoadAfter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsErrorToLoadAfter);
			return cb_isErrorToLoadAfter;
		}

		static bool n_IsErrorToLoadAfter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorToLoadAfter;
		}
#pragma warning restore 0169

		static Delegate cb_setErrorToLoadAfter_Z;
#pragma warning disable 0169
		static Delegate GetSetErrorToLoadAfter_ZHandler ()
		{
			if (cb_setErrorToLoadAfter_Z == null)
				cb_setErrorToLoadAfter_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetErrorToLoadAfter_Z);
			return cb_setErrorToLoadAfter_Z;
		}

		static void n_SetErrorToLoadAfter_Z (IntPtr jnienv, IntPtr native__this, bool errorToLoadAfter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ErrorToLoadAfter = errorToLoadAfter;
		}
#pragma warning restore 0169

		public virtual unsafe bool ErrorToLoadAfter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='isErrorToLoadAfter' and count(parameter)=0]"
			[Register ("isErrorToLoadAfter", "()Z", "GetIsErrorToLoadAfterHandler")]
			get {
				const string __id = "isErrorToLoadAfter.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='setErrorToLoadAfter' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setErrorToLoadAfter", "(Z)V", "GetSetErrorToLoadAfter_ZHandler")]
			set {
				const string __id = "setErrorToLoadAfter.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isErrorToLoadBefore;
#pragma warning disable 0169
		static Delegate GetIsErrorToLoadBeforeHandler ()
		{
			if (cb_isErrorToLoadBefore == null)
				cb_isErrorToLoadBefore = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsErrorToLoadBefore);
			return cb_isErrorToLoadBefore;
		}

		static bool n_IsErrorToLoadBefore (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorToLoadBefore;
		}
#pragma warning restore 0169

		static Delegate cb_setErrorToLoadBefore_Z;
#pragma warning disable 0169
		static Delegate GetSetErrorToLoadBefore_ZHandler ()
		{
			if (cb_setErrorToLoadBefore_Z == null)
				cb_setErrorToLoadBefore_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetErrorToLoadBefore_Z);
			return cb_setErrorToLoadBefore_Z;
		}

		static void n_SetErrorToLoadBefore_Z (IntPtr jnienv, IntPtr native__this, bool errorToLoadBefore)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ErrorToLoadBefore = errorToLoadBefore;
		}
#pragma warning restore 0169

		public virtual unsafe bool ErrorToLoadBefore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='isErrorToLoadBefore' and count(parameter)=0]"
			[Register ("isErrorToLoadBefore", "()Z", "GetIsErrorToLoadBeforeHandler")]
			get {
				const string __id = "isErrorToLoadBefore.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='setErrorToLoadBefore' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setErrorToLoadBefore", "(Z)V", "GetSetErrorToLoadBefore_ZHandler")]
			set {
				const string __id = "setErrorToLoadBefore.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isExistAfterDataToLoad;
#pragma warning disable 0169
		static Delegate GetIsExistAfterDataToLoadHandler ()
		{
			if (cb_isExistAfterDataToLoad == null)
				cb_isExistAfterDataToLoad = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsExistAfterDataToLoad);
			return cb_isExistAfterDataToLoad;
		}

		static bool n_IsExistAfterDataToLoad (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExistAfterDataToLoad;
		}
#pragma warning restore 0169

		static Delegate cb_setExistAfterDataToLoad_Z;
#pragma warning disable 0169
		static Delegate GetSetExistAfterDataToLoad_ZHandler ()
		{
			if (cb_setExistAfterDataToLoad_Z == null)
				cb_setExistAfterDataToLoad_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetExistAfterDataToLoad_Z);
			return cb_setExistAfterDataToLoad_Z;
		}

		static void n_SetExistAfterDataToLoad_Z (IntPtr jnienv, IntPtr native__this, bool existAfterDataToLoad)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExistAfterDataToLoad = existAfterDataToLoad;
		}
#pragma warning restore 0169

		public virtual unsafe bool ExistAfterDataToLoad {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='isExistAfterDataToLoad' and count(parameter)=0]"
			[Register ("isExistAfterDataToLoad", "()Z", "GetIsExistAfterDataToLoadHandler")]
			get {
				const string __id = "isExistAfterDataToLoad.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='setExistAfterDataToLoad' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setExistAfterDataToLoad", "(Z)V", "GetSetExistAfterDataToLoad_ZHandler")]
			set {
				const string __id = "setExistAfterDataToLoad.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isExistBeforeDataToLoad;
#pragma warning disable 0169
		static Delegate GetIsExistBeforeDataToLoadHandler ()
		{
			if (cb_isExistBeforeDataToLoad == null)
				cb_isExistBeforeDataToLoad = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsExistBeforeDataToLoad);
			return cb_isExistBeforeDataToLoad;
		}

		static bool n_IsExistBeforeDataToLoad (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExistBeforeDataToLoad;
		}
#pragma warning restore 0169

		static Delegate cb_setExistBeforeDataToLoad_Z;
#pragma warning disable 0169
		static Delegate GetSetExistBeforeDataToLoad_ZHandler ()
		{
			if (cb_setExistBeforeDataToLoad_Z == null)
				cb_setExistBeforeDataToLoad_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetExistBeforeDataToLoad_Z);
			return cb_setExistBeforeDataToLoad_Z;
		}

		static void n_SetExistBeforeDataToLoad_Z (IntPtr jnienv, IntPtr native__this, bool existBeforeDataToLoad)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExistBeforeDataToLoad = existBeforeDataToLoad;
		}
#pragma warning restore 0169

		public virtual unsafe bool ExistBeforeDataToLoad {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='isExistBeforeDataToLoad' and count(parameter)=0]"
			[Register ("isExistBeforeDataToLoad", "()Z", "GetIsExistBeforeDataToLoadHandler")]
			get {
				const string __id = "isExistBeforeDataToLoad.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='setExistBeforeDataToLoad' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setExistBeforeDataToLoad", "(Z)V", "GetSetExistBeforeDataToLoad_ZHandler")]
			set {
				const string __id = "setExistBeforeDataToLoad.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isFold;
#pragma warning disable 0169
		static Delegate GetIsFoldHandler ()
		{
			if (cb_isFold == null)
				cb_isFold = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsFold);
			return cb_isFold;
		}

		static bool n_IsFold (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Fold;
		}
#pragma warning restore 0169

		static Delegate cb_setFold_Z;
#pragma warning disable 0169
		static Delegate GetSetFold_ZHandler ()
		{
			if (cb_setFold_Z == null)
				cb_setFold_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetFold_Z);
			return cb_setFold_Z;
		}

		static void n_SetFold_Z (IntPtr jnienv, IntPtr native__this, bool fold)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Fold = fold;
		}
#pragma warning restore 0169

		public virtual unsafe bool Fold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='isFold' and count(parameter)=0]"
			[Register ("isFold", "()Z", "GetIsFoldHandler")]
			get {
				const string __id = "isFold.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='setFold' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFold", "(Z)V", "GetSetFold_ZHandler")]
			set {
				const string __id = "setFold.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeader;
#pragma warning disable 0169
		static Delegate GetGetHeaderHandler ()
		{
			if (cb_getHeader == null)
				cb_getHeader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHeader);
			return cb_getHeader;
		}

		static IntPtr n_GetHeader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Header);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Header {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='getHeader' and count(parameter)=0]"
			[Register ("getHeader", "()Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;", "GetGetHeaderHandler")]
			get {
				const string __id = "getHeader.()Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getItemCount;
#pragma warning disable 0169
		static Delegate GetGetItemCountHandler ()
		{
			if (cb_getItemCount == null)
				cb_getItemCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetItemCount);
			return cb_getItemCount;
		}

		static int n_GetItemCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemCount;
		}
#pragma warning restore 0169

		public virtual unsafe int ItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='getItemCount' and count(parameter)=0]"
			[Register ("getItemCount", "()I", "GetGetItemCountHandler")]
			get {
				const string __id = "getItemCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isLocked;
#pragma warning disable 0169
		static Delegate GetIsLockedHandler ()
		{
			if (cb_isLocked == null)
				cb_isLocked = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsLocked);
			return cb_isLocked;
		}

		static bool n_IsLocked (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Locked;
		}
#pragma warning restore 0169

		static Delegate cb_setLocked_Z;
#pragma warning disable 0169
		static Delegate GetSetLocked_ZHandler ()
		{
			if (cb_setLocked_Z == null)
				cb_setLocked_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetLocked_Z);
			return cb_setLocked_Z;
		}

		static void n_SetLocked_Z (IntPtr jnienv, IntPtr native__this, bool locked)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Locked = locked;
		}
#pragma warning restore 0169

		public virtual unsafe bool Locked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='isLocked' and count(parameter)=0]"
			[Register ("isLocked", "()Z", "GetIsLockedHandler")]
			get {
				const string __id = "isLocked.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='setLocked' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLocked", "(Z)V", "GetSetLocked_ZHandler")]
			set {
				const string __id = "setLocked.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_cloneForDiff;
#pragma warning disable 0169
		static Delegate GetCloneForDiffHandler ()
		{
			if (cb_cloneForDiff == null)
				cb_cloneForDiff = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CloneForDiff);
			return cb_cloneForDiff;
		}

		static IntPtr n_CloneForDiff (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CloneForDiff ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='cloneForDiff' and count(parameter)=0]"
		[Register ("cloneForDiff", "()Lcom/qmuiteam/qmui/widget/section/QMUISection;", "GetCloneForDiffHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection CloneForDiff ()
		{
			const string __id = "cloneForDiff.()Lcom/qmuiteam/qmui/widget/section/QMUISection;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_cloneStatusTo_Lcom_qmuiteam_qmui_widget_section_QMUISection_;
#pragma warning disable 0169
		static Delegate GetCloneStatusTo_Lcom_qmuiteam_qmui_widget_section_QMUISection_Handler ()
		{
			if (cb_cloneStatusTo_Lcom_qmuiteam_qmui_widget_section_QMUISection_ == null)
				cb_cloneStatusTo_Lcom_qmuiteam_qmui_widget_section_QMUISection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CloneStatusTo_Lcom_qmuiteam_qmui_widget_section_QMUISection_);
			return cb_cloneStatusTo_Lcom_qmuiteam_qmui_widget_section_QMUISection_;
		}

		static void n_CloneStatusTo_Lcom_qmuiteam_qmui_widget_section_QMUISection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var other = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (native_other, JniHandleOwnership.DoNotTransfer);
			__this.CloneStatusTo (other);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='cloneStatusTo' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.section.QMUISection&lt;H, T&gt;']]"
		[Register ("cloneStatusTo", "(Lcom/qmuiteam/qmui/widget/section/QMUISection;)V", "GetCloneStatusTo_Lcom_qmuiteam_qmui_widget_section_QMUISection_Handler")]
		public virtual unsafe void CloneStatusTo (global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection other)
		{
			const string __id = "cloneStatusTo.(Lcom/qmuiteam/qmui/widget/section/QMUISection;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (other);
			}
		}

		static Delegate cb_existItem_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_;
#pragma warning disable 0169
		static Delegate GetExistItem_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_Handler ()
		{
			if (cb_existItem_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_ == null)
				cb_existItem_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ExistItem_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_);
			return cb_existItem_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_;
		}

		static bool n_ExistItem_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_ (IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var item = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_item, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ExistItem (item);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='existItem' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("existItem", "(Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;)Z", "GetExistItem_Lcom_qmuiteam_qmui_widget_section_QMUISection_Model_Handler")]
		public virtual unsafe bool ExistItem (global::Java.Lang.Object item)
		{
			const string __id = "existItem.(Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;)Z";
			IntPtr native_item = JNIEnv.ToLocalJniHandle (item);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_item);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_item);
				global::System.GC.KeepAlive (item);
			}
		}

		static Delegate cb_finishLoadMore_Ljava_util_List_ZZ;
#pragma warning disable 0169
		static Delegate GetFinishLoadMore_Ljava_util_List_ZZHandler ()
		{
			if (cb_finishLoadMore_Ljava_util_List_ZZ == null)
				cb_finishLoadMore_Ljava_util_List_ZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZZ_V) n_FinishLoadMore_Ljava_util_List_ZZ);
			return cb_finishLoadMore_Ljava_util_List_ZZ;
		}

		static void n_FinishLoadMore_Ljava_util_List_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_data, bool isLoadBefore, bool existMoreData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Android.Runtime.JavaList.FromJniHandle (native_data, JniHandleOwnership.DoNotTransfer);
			__this.FinishLoadMore (data, isLoadBefore, existMoreData);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='finishLoadMore' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("finishLoadMore", "(Ljava/util/List;ZZ)V", "GetFinishLoadMore_Ljava_util_List_ZZHandler")]
		public virtual unsafe void FinishLoadMore (global::System.Collections.IList data, bool isLoadBefore, bool existMoreData)
		{
			const string __id = "finishLoadMore.(Ljava/util/List;ZZ)V";
			IntPtr native_data = global::Android.Runtime.JavaList.ToLocalJniHandle (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (isLoadBefore);
				__args [2] = new JniArgumentValue (existMoreData);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_getItemAt_I;
#pragma warning disable 0169
		static Delegate GetGetItemAt_IHandler ()
		{
			if (cb_getItemAt_I == null)
				cb_getItemAt_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetItemAt_I);
			return cb_getItemAt_I;
		}

		static IntPtr n_GetItemAt_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItemAt (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='getItemAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemAt", "(I)Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;", "GetGetItemAt_IHandler")]
		public virtual unsafe global::Java.Lang.Object GetItemAt (int index)
		{
			const string __id = "getItemAt.(I)Lcom/qmuiteam/qmui/widget/section/QMUISection$Model;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='isCustomItemIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isCustomItemIndex", "(I)Z", "")]
		public static unsafe bool IsCustomItemIndex (int index)
		{
			const string __id = "isCustomItemIndex.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_mutate;
#pragma warning disable 0169
		static Delegate GetMutateHandler ()
		{
			if (cb_mutate == null)
				cb_mutate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Mutate);
			return cb_mutate;
		}

		static IntPtr n_Mutate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Mutate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.section']/class[@name='QMUISection']/method[@name='mutate' and count(parameter)=0]"
		[Register ("mutate", "()Lcom/qmuiteam/qmui/widget/section/QMUISection;", "GetMutateHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection Mutate ()
		{
			const string __id = "mutate.()Lcom/qmuiteam/qmui/widget/section/QMUISection;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Section.QMUISection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
