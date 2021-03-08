using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Layout {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/layout/QMUIPriorityLinearLayout", DoNotGenerateAcw=true)]
	public partial class QMUIPriorityLinearLayout : global::Com.Qmuiteam.Qmui.Layout.QMUILinearLayout {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout.LayoutParams']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/layout/QMUIPriorityLinearLayout$LayoutParams", DoNotGenerateAcw=true)]
		public partial class LayoutParams : global::Android.Widget.LinearLayout.LayoutParams {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout.LayoutParams']/field[@name='PRIORITY_DISPOSABLE']"
			[Register ("PRIORITY_DISPOSABLE")]
			public const int PriorityDisposable = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout.LayoutParams']/field[@name='PRIORITY_INCOMPRESSIBLE']"
			[Register ("PRIORITY_INCOMPRESSIBLE")]
			public const int PriorityIncompressible = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout.LayoutParams']/field[@name='PRIORITY_MINI_CONTENT_PROTECTION']"
			[Register ("PRIORITY_MINI_CONTENT_PROTECTION")]
			public const int PriorityMiniContentProtection = (int) 2;
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/layout/QMUIPriorityLinearLayout$LayoutParams", typeof (LayoutParams));
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

			protected LayoutParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout.LayoutParams']/constructor[@name='QMUIPriorityLinearLayout.LayoutParams' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
			[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
			public unsafe LayoutParams (global::Android.Content.Context c, global::Android.Util.IAttributeSet attrs)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
					__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (c);
					global::System.GC.KeepAlive (attrs);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout.LayoutParams']/constructor[@name='QMUIPriorityLinearLayout.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup.LayoutParams']]"
			[Register (".ctor", "(Landroid/view/ViewGroup$LayoutParams;)V", "")]
			public unsafe LayoutParams (global::Android.Views.ViewGroup.LayoutParams p)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/view/ViewGroup$LayoutParams;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout.LayoutParams']/constructor[@name='QMUIPriorityLinearLayout.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup.MarginLayoutParams']]"
			[Register (".ctor", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", "")]
			public unsafe LayoutParams (global::Android.Views.ViewGroup.MarginLayoutParams source)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/view/ViewGroup$MarginLayoutParams;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (source);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout.LayoutParams']/constructor[@name='QMUIPriorityLinearLayout.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.widget.LinearLayout.LayoutParams']]"
			[Register (".ctor", "(Landroid/widget/LinearLayout$LayoutParams;)V", "")]
			public unsafe LayoutParams (global::Android.Widget.LinearLayout.LayoutParams source)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/widget/LinearLayout$LayoutParams;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (source);
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout.LayoutParams']/constructor[@name='QMUIPriorityLinearLayout.LayoutParams' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe LayoutParams (int width, int height)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(II)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout.LayoutParams']/constructor[@name='QMUIPriorityLinearLayout.LayoutParams' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='float']]"
			[Register (".ctor", "(IIF)V", "")]
			public unsafe LayoutParams (int width, int height, float weight)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IIF)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					__args [2] = new JniArgumentValue (weight);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_getPriority_I;
#pragma warning disable 0169
			static Delegate GetGetPriority_IHandler ()
			{
				if (cb_getPriority_I == null)
					cb_getPriority_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetPriority_I);
				return cb_getPriority_I;
			}

			static int n_GetPriority_I (IntPtr jnienv, IntPtr native__this, int orientation)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIPriorityLinearLayout.LayoutParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetPriority (orientation);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout.LayoutParams']/method[@name='getPriority' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getPriority", "(I)I", "GetGetPriority_IHandler")]
			public virtual unsafe int GetPriority (int orientation)
			{
				const string __id = "getPriority.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (orientation);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_setMiniContentProtectionSize_I;
#pragma warning disable 0169
			static Delegate GetSetMiniContentProtectionSize_IHandler ()
			{
				if (cb_setMiniContentProtectionSize_I == null)
					cb_setMiniContentProtectionSize_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMiniContentProtectionSize_I);
				return cb_setMiniContentProtectionSize_I;
			}

			static void n_SetMiniContentProtectionSize_I (IntPtr jnienv, IntPtr native__this, int miniContentProtectionSize)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIPriorityLinearLayout.LayoutParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetMiniContentProtectionSize (miniContentProtectionSize);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout.LayoutParams']/method[@name='setMiniContentProtectionSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMiniContentProtectionSize", "(I)V", "GetSetMiniContentProtectionSize_IHandler")]
			public virtual unsafe void SetMiniContentProtectionSize (int miniContentProtectionSize)
			{
				const string __id = "setMiniContentProtectionSize.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (miniContentProtectionSize);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_setPriority_I;
#pragma warning disable 0169
			static Delegate GetSetPriority_IHandler ()
			{
				if (cb_setPriority_I == null)
					cb_setPriority_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetPriority_I);
				return cb_setPriority_I;
			}

			static void n_SetPriority_I (IntPtr jnienv, IntPtr native__this, int priority)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIPriorityLinearLayout.LayoutParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetPriority (priority);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout.LayoutParams']/method[@name='setPriority' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPriority", "(I)V", "GetSetPriority_IHandler")]
			public virtual unsafe void SetPriority (int priority)
			{
				const string __id = "setPriority.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (priority);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/layout/QMUIPriorityLinearLayout", typeof (QMUIPriorityLinearLayout));
		internal static new IntPtr class_ref {
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

		protected QMUIPriorityLinearLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout']/constructor[@name='QMUIPriorityLinearLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIPriorityLinearLayout (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout']/constructor[@name='QMUIPriorityLinearLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIPriorityLinearLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_dispatchSpaceToDisposableChildList_Ljava_util_ArrayList_III;
#pragma warning disable 0169
		static Delegate GetDispatchSpaceToDisposableChildList_Ljava_util_ArrayList_IIIHandler ()
		{
			if (cb_dispatchSpaceToDisposableChildList_Ljava_util_ArrayList_III == null)
				cb_dispatchSpaceToDisposableChildList_Ljava_util_ArrayList_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIII_V) n_DispatchSpaceToDisposableChildList_Ljava_util_ArrayList_III);
			return cb_dispatchSpaceToDisposableChildList_Ljava_util_ArrayList_III;
		}

		static void n_DispatchSpaceToDisposableChildList_Ljava_util_ArrayList_III (IntPtr jnienv, IntPtr native__this, IntPtr native_childList, int widthMeasureSpec, int heightMeasureSpec, int usefulSpace)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIPriorityLinearLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var childList = global::Android.Runtime.JavaList<global::Android.Views.View>.FromJniHandle (native_childList, JniHandleOwnership.DoNotTransfer);
			__this.DispatchSpaceToDisposableChildList (childList, widthMeasureSpec, heightMeasureSpec, usefulSpace);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout']/method[@name='dispatchSpaceToDisposableChildList' and count(parameter)=4 and parameter[1][@type='java.util.ArrayList&lt;android.view.View&gt;'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("dispatchSpaceToDisposableChildList", "(Ljava/util/ArrayList;III)V", "GetDispatchSpaceToDisposableChildList_Ljava_util_ArrayList_IIIHandler")]
		protected virtual unsafe void DispatchSpaceToDisposableChildList (global::System.Collections.Generic.IList<global::Android.Views.View> childList, int widthMeasureSpec, int heightMeasureSpec, int usefulSpace)
		{
			const string __id = "dispatchSpaceToDisposableChildList.(Ljava/util/ArrayList;III)V";
			IntPtr native_childList = global::Android.Runtime.JavaList<global::Android.Views.View>.ToLocalJniHandle (childList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_childList);
				__args [1] = new JniArgumentValue (widthMeasureSpec);
				__args [2] = new JniArgumentValue (heightMeasureSpec);
				__args [3] = new JniArgumentValue (usefulSpace);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_childList);
				global::System.GC.KeepAlive (childList);
			}
		}

		static Delegate cb_dispatchSpaceToMiniWidthChildList_Ljava_util_ArrayList_II;
#pragma warning disable 0169
		static Delegate GetDispatchSpaceToMiniWidthChildList_Ljava_util_ArrayList_IIHandler ()
		{
			if (cb_dispatchSpaceToMiniWidthChildList_Ljava_util_ArrayList_II == null)
				cb_dispatchSpaceToMiniWidthChildList_Ljava_util_ArrayList_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_DispatchSpaceToMiniWidthChildList_Ljava_util_ArrayList_II);
			return cb_dispatchSpaceToMiniWidthChildList_Ljava_util_ArrayList_II;
		}

		static void n_DispatchSpaceToMiniWidthChildList_Ljava_util_ArrayList_II (IntPtr jnienv, IntPtr native__this, IntPtr native_childList, int usefulSpace, int calculateTotalLength)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Layout.QMUIPriorityLinearLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var childList = global::Android.Runtime.JavaList<global::Android.Views.View>.FromJniHandle (native_childList, JniHandleOwnership.DoNotTransfer);
			__this.DispatchSpaceToMiniWidthChildList (childList, usefulSpace, calculateTotalLength);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.layout']/class[@name='QMUIPriorityLinearLayout']/method[@name='dispatchSpaceToMiniWidthChildList' and count(parameter)=3 and parameter[1][@type='java.util.ArrayList&lt;android.view.View&gt;'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("dispatchSpaceToMiniWidthChildList", "(Ljava/util/ArrayList;II)V", "GetDispatchSpaceToMiniWidthChildList_Ljava_util_ArrayList_IIHandler")]
		protected virtual unsafe void DispatchSpaceToMiniWidthChildList (global::System.Collections.Generic.IList<global::Android.Views.View> childList, int usefulSpace, int calculateTotalLength)
		{
			const string __id = "dispatchSpaceToMiniWidthChildList.(Ljava/util/ArrayList;II)V";
			IntPtr native_childList = global::Android.Runtime.JavaList<global::Android.Views.View>.ToLocalJniHandle (childList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_childList);
				__args [1] = new JniArgumentValue (usefulSpace);
				__args [2] = new JniArgumentValue (calculateTotalLength);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_childList);
				global::System.GC.KeepAlive (childList);
			}
		}

	}
}
