using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISeekBar']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUISeekBar", DoNotGenerateAcw=true)]
	public partial class QMUISeekBar : global::Com.Qmuiteam.Qmui.Widget.QMUISlider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUISeekBar", typeof (QMUISeekBar));
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

		protected QMUISeekBar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISeekBar']/constructor[@name='QMUISeekBar' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUISeekBar (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISeekBar']/constructor[@name='QMUISeekBar' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUISeekBar (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISeekBar']/constructor[@name='QMUISeekBar' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUISeekBar (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_getTickHeight;
#pragma warning disable 0169
		static Delegate GetGetTickHeightHandler ()
		{
			if (cb_getTickHeight == null)
				cb_getTickHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTickHeight);
			return cb_getTickHeight;
		}

		static int n_GetTickHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TickHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setTickHeight_I;
#pragma warning disable 0169
		static Delegate GetSetTickHeight_IHandler ()
		{
			if (cb_setTickHeight_I == null)
				cb_setTickHeight_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTickHeight_I);
			return cb_setTickHeight_I;
		}

		static void n_SetTickHeight_I (IntPtr jnienv, IntPtr native__this, int tickHeight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TickHeight = tickHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int TickHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISeekBar']/method[@name='getTickHeight' and count(parameter)=0]"
			[Register ("getTickHeight", "()I", "GetGetTickHeightHandler")]
			get {
				const string __id = "getTickHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISeekBar']/method[@name='setTickHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTickHeight", "(I)V", "GetSetTickHeight_IHandler")]
			set {
				const string __id = "setTickHeight.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_setTickWidth_I;
#pragma warning disable 0169
		static Delegate GetSetTickWidth_IHandler ()
		{
			if (cb_setTickWidth_I == null)
				cb_setTickWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTickWidth_I);
			return cb_setTickWidth_I;
		}

		static void n_SetTickWidth_I (IntPtr jnienv, IntPtr native__this, int tickWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISeekBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTickWidth (tickWidth);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISeekBar']/method[@name='setTickWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTickWidth", "(I)V", "GetSetTickWidth_IHandler")]
		public virtual unsafe void SetTickWidth (int tickWidth)
		{
			const string __id = "setTickWidth.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (tickWidth);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
