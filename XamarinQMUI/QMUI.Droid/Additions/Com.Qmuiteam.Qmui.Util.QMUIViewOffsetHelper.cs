using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewOffsetHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIViewOffsetHelper", DoNotGenerateAcw=true)]
	public sealed partial class QMUIViewOffsetHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIViewOffsetHelper", typeof (QMUIViewOffsetHelper));
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

		internal QMUIViewOffsetHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewOffsetHelper']/constructor[@name='QMUIViewOffsetHelper' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public unsafe QMUIViewOffsetHelper (global::Android.Views.View view)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/View;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		public unsafe bool HorizontalOffsetEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewOffsetHelper']/method[@name='isHorizontalOffsetEnabled' and count(parameter)=0]"
			[Register ("isHorizontalOffsetEnabled", "()Z", "")]
			get {
				const string __id = "isHorizontalOffsetEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewOffsetHelper']/method[@name='setHorizontalOffsetEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHorizontalOffsetEnabled", "(Z)V", "")]
			set {
				const string __id = "setHorizontalOffsetEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int LayoutLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewOffsetHelper']/method[@name='getLayoutLeft' and count(parameter)=0]"
			[Register ("getLayoutLeft", "()I", "")]
			get {
				const string __id = "getLayoutLeft.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int LayoutTop {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewOffsetHelper']/method[@name='getLayoutTop' and count(parameter)=0]"
			[Register ("getLayoutTop", "()I", "")]
			get {
				const string __id = "getLayoutTop.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int LeftAndRightOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewOffsetHelper']/method[@name='getLeftAndRightOffset' and count(parameter)=0]"
			[Register ("getLeftAndRightOffset", "()I", "")]
			get {
				const string __id = "getLeftAndRightOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int TopAndBottomOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewOffsetHelper']/method[@name='getTopAndBottomOffset' and count(parameter)=0]"
			[Register ("getTopAndBottomOffset", "()I", "")]
			get {
				const string __id = "getTopAndBottomOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool VerticalOffsetEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewOffsetHelper']/method[@name='isVerticalOffsetEnabled' and count(parameter)=0]"
			[Register ("isVerticalOffsetEnabled", "()Z", "")]
			get {
				const string __id = "isVerticalOffsetEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewOffsetHelper']/method[@name='setVerticalOffsetEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVerticalOffsetEnabled", "(Z)V", "")]
			set {
				const string __id = "setVerticalOffsetEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewOffsetHelper']/method[@name='applyOffsets' and count(parameter)=0]"
		[Register ("applyOffsets", "()V", "")]
		public unsafe void ApplyOffsets ()
		{
			const string __id = "applyOffsets.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewOffsetHelper']/method[@name='onViewLayout' and count(parameter)=0]"
		[Register ("onViewLayout", "()V", "")]
		public unsafe void OnViewLayout ()
		{
			const string __id = "onViewLayout.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewOffsetHelper']/method[@name='onViewLayout' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onViewLayout", "(Z)V", "")]
		public unsafe void OnViewLayout (bool applyOffset)
		{
			const string __id = "onViewLayout.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (applyOffset);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewOffsetHelper']/method[@name='setLeftAndRightOffset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLeftAndRightOffset", "(I)Z", "")]
		public unsafe bool SetLeftAndRightOffset (int offset)
		{
			const string __id = "setLeftAndRightOffset.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewOffsetHelper']/method[@name='setOffset' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setOffset", "(II)Z", "")]
		public unsafe bool SetOffset (int leftOffset, int topOffset)
		{
			const string __id = "setOffset.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (leftOffset);
				__args [1] = new JniArgumentValue (topOffset);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIViewOffsetHelper']/method[@name='setTopAndBottomOffset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTopAndBottomOffset", "(I)Z", "")]
		public unsafe bool SetTopAndBottomOffset (int offset)
		{
			const string __id = "setTopAndBottomOffset.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
