using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/QMUISkinManager", DoNotGenerateAcw=true)]
	public sealed partial class QMUISkinManager : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/field[@name='DEFAULT_DISPATCH_LISTEN_STRATEGY_SELECTOR']"
		[Register ("DEFAULT_DISPATCH_LISTEN_STRATEGY_SELECTOR")]
		public static global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.IDispatchListenStrategySelector DefaultDispatchListenStrategySelector {
			get {
				const string __id = "DEFAULT_DISPATCH_LISTEN_STRATEGY_SELECTOR.Lcom/qmuiteam/qmui/skin/QMUISkinManager$DispatchListenStrategySelector;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.IDispatchListenStrategySelector> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/field[@name='DEFAULT_SKIN']"
		[Register ("DEFAULT_SKIN")]
		public const int DefaultSkin = (int) -1;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager.DispatchListenStrategy']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/QMUISkinManager$DispatchListenStrategy", DoNotGenerateAcw=true)]
		public sealed partial class DispatchListenStrategy : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager.DispatchListenStrategy']/field[@name='LISTEN_ON_HIERARCHY_CHANGE']"
			[Register ("LISTEN_ON_HIERARCHY_CHANGE")]
			public static global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.DispatchListenStrategy ListenOnHierarchyChange {
				get {
					const string __id = "LISTEN_ON_HIERARCHY_CHANGE.Lcom/qmuiteam/qmui/skin/QMUISkinManager$DispatchListenStrategy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.DispatchListenStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager.DispatchListenStrategy']/field[@name='LISTEN_ON_LAYOUT']"
			[Register ("LISTEN_ON_LAYOUT")]
			public static global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.DispatchListenStrategy ListenOnLayout {
				get {
					const string __id = "LISTEN_ON_LAYOUT.Lcom/qmuiteam/qmui/skin/QMUISkinManager$DispatchListenStrategy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.DispatchListenStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/QMUISkinManager$DispatchListenStrategy", typeof (DispatchListenStrategy));
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

			internal DispatchListenStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager.DispatchListenStrategy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinManager$DispatchListenStrategy;", "")]
			public static unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.DispatchListenStrategy ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinManager$DispatchListenStrategy;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.DispatchListenStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager.DispatchListenStrategy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/qmuiteam/qmui/skin/QMUISkinManager$DispatchListenStrategy;", "")]
			public static unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.DispatchListenStrategy[] Values ()
			{
				const string __id = "values.()[Lcom/qmuiteam/qmui/skin/QMUISkinManager$DispatchListenStrategy;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.DispatchListenStrategy[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.DispatchListenStrategy));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/interface[@name='QMUISkinManager.DispatchListenStrategySelector']"
		[Register ("com/qmuiteam/qmui/skin/QMUISkinManager$DispatchListenStrategySelector", "", "Com.Qmuiteam.Qmui.Skin.QMUISkinManager/IDispatchListenStrategySelectorInvoker")]
		public partial interface IDispatchListenStrategySelector : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/interface[@name='QMUISkinManager.DispatchListenStrategySelector']/method[@name='select' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup']]"
			[Register ("select", "(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/skin/QMUISkinManager$DispatchListenStrategy;", "GetSelect_Landroid_view_ViewGroup_Handler:Com.Qmuiteam.Qmui.Skin.QMUISkinManager/IDispatchListenStrategySelectorInvoker, QMUI.Droid")]
			global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.DispatchListenStrategy Select (global::Android.Views.ViewGroup p0);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/QMUISkinManager$DispatchListenStrategySelector", DoNotGenerateAcw=true)]
		internal partial class IDispatchListenStrategySelectorInvoker : global::Java.Lang.Object, IDispatchListenStrategySelector {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/QMUISkinManager$DispatchListenStrategySelector", typeof (IDispatchListenStrategySelectorInvoker));

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

			public static IDispatchListenStrategySelector GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDispatchListenStrategySelector> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.skin.QMUISkinManager.DispatchListenStrategySelector"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDispatchListenStrategySelectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_select_Landroid_view_ViewGroup_;
#pragma warning disable 0169
			static Delegate GetSelect_Landroid_view_ViewGroup_Handler ()
			{
				if (cb_select_Landroid_view_ViewGroup_ == null)
					cb_select_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Select_Landroid_view_ViewGroup_);
				return cb_select_Landroid_view_ViewGroup_;
			}

			static IntPtr n_Select_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.IDispatchListenStrategySelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Select (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_select_Landroid_view_ViewGroup_;
			public unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.DispatchListenStrategy Select (global::Android.Views.ViewGroup p0)
			{
				if (id_select_Landroid_view_ViewGroup_ == IntPtr.Zero)
					id_select_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "select", "(Landroid/view/ViewGroup;)Lcom/qmuiteam/qmui/skin/QMUISkinManager$DispatchListenStrategy;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __ret = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.DispatchListenStrategy> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_select_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/interface[@name='QMUISkinManager.OnSkinChangeListener']"
		[Register ("com/qmuiteam/qmui/skin/QMUISkinManager$OnSkinChangeListener", "", "Com.Qmuiteam.Qmui.Skin.QMUISkinManager/IOnSkinChangeListenerInvoker")]
		public partial interface IOnSkinChangeListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/interface[@name='QMUISkinManager.OnSkinChangeListener']/method[@name='onSkinChange' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onSkinChange", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager;II)V", "GetOnSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_IIHandler:Com.Qmuiteam.Qmui.Skin.QMUISkinManager/IOnSkinChangeListenerInvoker, QMUI.Droid")]
			void OnSkinChange (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager skinManager, int oldSkin, int newSkin);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/QMUISkinManager$OnSkinChangeListener", DoNotGenerateAcw=true)]
		internal partial class IOnSkinChangeListenerInvoker : global::Java.Lang.Object, IOnSkinChangeListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/QMUISkinManager$OnSkinChangeListener", typeof (IOnSkinChangeListenerInvoker));

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

			public static IOnSkinChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnSkinChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.skin.QMUISkinManager.OnSkinChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnSkinChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_II;
#pragma warning disable 0169
			static Delegate GetOnSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_IIHandler ()
			{
				if (cb_onSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_II == null)
					cb_onSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_OnSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_II);
				return cb_onSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_II;
			}

			static void n_OnSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_II (IntPtr jnienv, IntPtr native__this, IntPtr native_skinManager, int oldSkin, int newSkin)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.IOnSkinChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var skinManager = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_skinManager, JniHandleOwnership.DoNotTransfer);
				__this.OnSkinChange (skinManager, oldSkin, newSkin);
			}
#pragma warning restore 0169

			IntPtr id_onSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_II;
			public unsafe void OnSkinChange (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager skinManager, int oldSkin, int newSkin)
			{
				if (id_onSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_II == IntPtr.Zero)
					id_onSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_II = JNIEnv.GetMethodID (class_ref, "onSkinChange", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager;II)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((skinManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skinManager).Handle);
				__args [1] = new JValue (oldSkin);
				__args [2] = new JValue (newSkin);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSkinChange_Lcom_qmuiteam_qmui_skin_QMUISkinManager_II, __args);
			}

		}

		// event args for com.qmuiteam.qmui.skin.QMUISkinManager.OnSkinChangeListener.onSkinChange
		public partial class SkinChangeEventArgs : global::System.EventArgs {

			public SkinChangeEventArgs (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager skinManager, int oldSkin, int newSkin)
			{
				this.skinManager = skinManager;
				this.oldSkin = oldSkin;
				this.newSkin = newSkin;
			}

			global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager skinManager;
			public global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager SkinManager {
				get { return skinManager; }
			}

			int oldSkin;
			public int OldSkin {
				get { return oldSkin; }
			}

			int newSkin;
			public int NewSkin {
				get { return newSkin; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/skin/QMUISkinManager_OnSkinChangeListenerImplementor")]
		internal sealed partial class IOnSkinChangeListenerImplementor : global::Java.Lang.Object, IOnSkinChangeListener {

			object sender;

			public IOnSkinChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/skin/QMUISkinManager_OnSkinChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<SkinChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnSkinChange (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager skinManager, int oldSkin, int newSkin)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new SkinChangeEventArgs (skinManager, oldSkin, newSkin));
			}

			internal static bool __IsEmpty (IOnSkinChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/QMUISkinManager", typeof (QMUISkinManager));
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

		internal QMUISkinManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/constructor[@name='QMUISkinManager' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.res.Resources'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Landroid/content/res/Resources;Ljava/lang/String;)V", "")]
		public unsafe QMUISkinManager (string name, global::Android.Content.Res.Resources resources, string packageName)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Landroid/content/res/Resources;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_packageName = JNIEnv.NewString (packageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((resources == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resources).Handle);
				__args [2] = new JniArgumentValue (native_packageName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_packageName);
				global::System.GC.KeepAlive (resources);
			}
		}

		public unsafe int CurrentSkin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='getCurrentSkin' and count(parameter)=0]"
			[Register ("getCurrentSkin", "()I", "")]
			get {
				const string __id = "getCurrentSkin.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.Content.Res.Resources.Theme CurrentTheme {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='getCurrentTheme' and count(parameter)=0]"
			[Register ("getCurrentTheme", "()Landroid/content/res/Resources$Theme;", "")]
			get {
				const string __id = "getCurrentTheme.()Landroid/content/res/Resources$Theme;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='addSkin' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("addSkin", "(II)V", "")]
		public unsafe void AddSkin (int index, int styleRes)
		{
			const string __id = "addSkin.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (styleRes);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='addSkinChangeListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager.OnSkinChangeListener']]"
		[Register ("addSkinChangeListener", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager$OnSkinChangeListener;)V", "")]
		public unsafe void AddSkinChangeListener (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.IOnSkinChangeListener listener)
		{
			const string __id = "addSkinChangeListener.(Lcom/qmuiteam/qmui/skin/QMUISkinManager$OnSkinChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='changeSkin' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("changeSkin", "(I)V", "")]
		public unsafe void ChangeSkin (int index)
		{
			const string __id = "changeSkin.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='defaultHandleSkinAttr' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.content.res.Resources.Theme'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("defaultHandleSkinAttr", "(Landroid/view/View;Landroid/content/res/Resources$Theme;Ljava/lang/String;I)V", "")]
		public unsafe void DefaultHandleSkinAttr (global::Android.Views.View view, global::Android.Content.Res.Resources.Theme theme, string name, int attr)
		{
			const string __id = "defaultHandleSkinAttr.(Landroid/view/View;Landroid/content/res/Resources$Theme;Ljava/lang/String;I)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((theme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theme).Handle);
				__args [2] = new JniArgumentValue (native_name);
				__args [3] = new JniArgumentValue (attr);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (theme);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='defaultHandleSkinAttrs' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.content.res.Resources.Theme'] and parameter[3][@type='androidx.collection.SimpleArrayMap&lt;java.lang.String, java.lang.Integer&gt;']]"
		[Register ("defaultHandleSkinAttrs", "(Landroid/view/View;Landroid/content/res/Resources$Theme;Landroidx/collection/SimpleArrayMap;)V", "")]
		public unsafe void DefaultHandleSkinAttrs (global::Android.Views.View view, global::Android.Content.Res.Resources.Theme theme, global::AndroidX.Collection.SimpleArrayMap attrs)
		{
			const string __id = "defaultHandleSkinAttrs.(Landroid/view/View;Landroid/content/res/Resources$Theme;Landroidx/collection/SimpleArrayMap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((theme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theme).Handle);
				__args [2] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (theme);
				global::System.GC.KeepAlive (attrs);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='defaultInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("defaultInstance", "(Landroid/content/Context;)Lcom/qmuiteam/qmui/skin/QMUISkinManager;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager DefaultInstance (global::Android.Content.Context context)
		{
			const string __id = "defaultInstance.(Landroid/content/Context;)Lcom/qmuiteam/qmui/skin/QMUISkinManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='dispatch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("dispatch", "(Landroid/view/View;I)V", "")]
		public unsafe void Dispatch (global::Android.Views.View view, int skinIndex)
		{
			const string __id = "dispatch.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (skinIndex);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='getAttrFromName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAttrFromName", "(Ljava/lang/String;)I", "")]
		public unsafe int GetAttrFromName (string attrName)
		{
			const string __id = "getAttrFromName.(Ljava/lang/String;)I";
			IntPtr native_attrName = JNIEnv.NewString (attrName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrName);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_attrName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='getTheme' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTheme", "(I)Landroid/content/res/Resources$Theme;", "")]
		public unsafe global::Android.Content.Res.Resources.Theme GetTheme (int skinIndex)
		{
			const string __id = "getTheme.(I)Landroid/content/res/Resources$Theme;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (skinIndex);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='of' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("of", "(Ljava/lang/String;Landroid/content/Context;)Lcom/qmuiteam/qmui/skin/QMUISkinManager;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager Of (string name, global::Android.Content.Context context)
		{
			const string __id = "of.(Ljava/lang/String;Landroid/content/Context;)Lcom/qmuiteam/qmui/skin/QMUISkinManager;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='of' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.res.Resources'] and parameter[3][@type='java.lang.String']]"
		[Register ("of", "(Ljava/lang/String;Landroid/content/res/Resources;Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinManager;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager Of (string name, global::Android.Content.Res.Resources resources, string packageName)
		{
			const string __id = "of.(Ljava/lang/String;Landroid/content/res/Resources;Ljava/lang/String;)Lcom/qmuiteam/qmui/skin/QMUISkinManager;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_packageName = JNIEnv.NewString (packageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((resources == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resources).Handle);
				__args [2] = new JniArgumentValue (native_packageName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_packageName);
				global::System.GC.KeepAlive (resources);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='register' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("register", "(Landroid/app/Activity;)V", "")]
		public unsafe void Register (global::Android.App.Activity activity)
		{
			const string __id = "register.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='register' and count(parameter)=1 and parameter[1][@type='android.app.Dialog']]"
		[Register ("register", "(Landroid/app/Dialog;)V", "")]
		public unsafe void Register (global::Android.App.Dialog dialog)
		{
			const string __id = "register.(Landroid/app/Dialog;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dialog == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dialog).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dialog);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='register' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("register", "(Landroid/view/View;)V", "")]
		public unsafe void Register (global::Android.Views.View view)
		{
			const string __id = "register.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='register' and count(parameter)=1 and parameter[1][@type='android.view.Window']]"
		[Register ("register", "(Landroid/view/Window;)V", "")]
		public unsafe void Register (global::Android.Views.Window window)
		{
			const string __id = "register.(Landroid/view/Window;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((window == null) ? IntPtr.Zero : ((global::Java.Lang.Object) window).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (window);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='register' and count(parameter)=1 and parameter[1][@type='android.widget.PopupWindow']]"
		[Register ("register", "(Landroid/widget/PopupWindow;)V", "")]
		public unsafe void Register (global::Android.Widget.PopupWindow popupWindow)
		{
			const string __id = "register.(Landroid/widget/PopupWindow;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((popupWindow == null) ? IntPtr.Zero : ((global::Java.Lang.Object) popupWindow).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (popupWindow);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='register' and count(parameter)=1 and parameter[1][@type='androidx.fragment.app.Fragment']]"
		[Register ("register", "(Landroidx/fragment/app/Fragment;)V", "")]
		public unsafe void Register (global::AndroidX.Fragment.App.Fragment fragment)
		{
			const string __id = "register.(Landroidx/fragment/app/Fragment;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fragment == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fragment).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (fragment);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='removeSkinChangeListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager.OnSkinChangeListener']]"
		[Register ("removeSkinChangeListener", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager$OnSkinChangeListener;)V", "")]
		public unsafe void RemoveSkinChangeListener (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.IOnSkinChangeListener listener)
		{
			const string __id = "removeSkinChangeListener.(Lcom/qmuiteam/qmui/skin/QMUISkinManager$OnSkinChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='setDispatchListenStrategySelector' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager.DispatchListenStrategySelector']]"
		[Register ("setDispatchListenStrategySelector", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager$DispatchListenStrategySelector;)V", "")]
		public static unsafe void SetDispatchListenStrategySelector (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.IDispatchListenStrategySelector dispatchListenStrategySelector)
		{
			const string __id = "setDispatchListenStrategySelector.(Lcom/qmuiteam/qmui/skin/QMUISkinManager$DispatchListenStrategySelector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dispatchListenStrategySelector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dispatchListenStrategySelector).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (dispatchListenStrategySelector);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='setRuleHandler' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.qmuiteam.qmui.skin.handler.IQMUISkinRuleHandler']]"
		[Register ("setRuleHandler", "(Ljava/lang/String;Lcom/qmuiteam/qmui/skin/handler/IQMUISkinRuleHandler;)V", "")]
		public static unsafe void SetRuleHandler (string name, global::Com.Qmuiteam.Qmui.Skin.Handler.IQMUISkinRuleHandler handler)
		{
			const string __id = "setRuleHandler.(Ljava/lang/String;Lcom/qmuiteam/qmui/skin/handler/IQMUISkinRuleHandler;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (handler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='unRegister' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("unRegister", "(Landroid/app/Activity;)V", "")]
		public unsafe void UnRegister (global::Android.App.Activity activity)
		{
			const string __id = "unRegister.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='unRegister' and count(parameter)=1 and parameter[1][@type='android.app.Dialog']]"
		[Register ("unRegister", "(Landroid/app/Dialog;)V", "")]
		public unsafe void UnRegister (global::Android.App.Dialog dialog)
		{
			const string __id = "unRegister.(Landroid/app/Dialog;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dialog == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dialog).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dialog);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='unRegister' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("unRegister", "(Landroid/view/View;)V", "")]
		public unsafe void UnRegister (global::Android.Views.View view)
		{
			const string __id = "unRegister.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='unRegister' and count(parameter)=1 and parameter[1][@type='android.view.Window']]"
		[Register ("unRegister", "(Landroid/view/Window;)V", "")]
		public unsafe void UnRegister (global::Android.Views.Window window)
		{
			const string __id = "unRegister.(Landroid/view/Window;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((window == null) ? IntPtr.Zero : ((global::Java.Lang.Object) window).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (window);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='unRegister' and count(parameter)=1 and parameter[1][@type='android.widget.PopupWindow']]"
		[Register ("unRegister", "(Landroid/widget/PopupWindow;)V", "")]
		public unsafe void UnRegister (global::Android.Widget.PopupWindow popupWindow)
		{
			const string __id = "unRegister.(Landroid/widget/PopupWindow;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((popupWindow == null) ? IntPtr.Zero : ((global::Java.Lang.Object) popupWindow).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (popupWindow);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinManager']/method[@name='unRegister' and count(parameter)=1 and parameter[1][@type='androidx.fragment.app.Fragment']]"
		[Register ("unRegister", "(Landroidx/fragment/app/Fragment;)V", "")]
		public unsafe void UnRegister (global::AndroidX.Fragment.App.Fragment fragment)
		{
			const string __id = "unRegister.(Landroidx/fragment/app/Fragment;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fragment == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fragment).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (fragment);
			}
		}

#region "Event implementation for Com.Qmuiteam.Qmui.Skin.QMUISkinManager.IOnSkinChangeListener"
		public event EventHandler<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.SkinChangeEventArgs> SkinChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.IOnSkinChangeListener, global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.IOnSkinChangeListenerImplementor>(
						ref weak_implementor_AddSkinChangeListener,
						__CreateIOnSkinChangeListenerImplementor,
						AddSkinChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.IOnSkinChangeListener, global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.IOnSkinChangeListenerImplementor>(
						ref weak_implementor_AddSkinChangeListener,
						global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.IOnSkinChangeListenerImplementor.__IsEmpty,
						__v => RemoveSkinChangeListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddSkinChangeListener;

		global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.IOnSkinChangeListenerImplementor __CreateIOnSkinChangeListenerImplementor ()
		{
			return new global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager.IOnSkinChangeListenerImplementor (this);
		}
#endregion
	}
}
