using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIDeviceHelper", DoNotGenerateAcw=true)]
	public partial class QMUIDeviceHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIDeviceHelper", typeof (QMUIDeviceHelper));
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

		protected QMUIDeviceHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/constructor[@name='QMUIDeviceHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIDeviceHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe bool IsEssentialPhone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isEssentialPhone' and count(parameter)=0]"
			[Register ("isEssentialPhone", "()Z", "")]
			get {
				const string __id = "isEssentialPhone.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsFlyme {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isFlyme' and count(parameter)=0]"
			[Register ("isFlyme", "()Z", "")]
			get {
				const string __id = "isFlyme.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsHuawei {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isHuawei' and count(parameter)=0]"
			[Register ("isHuawei", "()Z", "")]
			get {
				const string __id = "isHuawei.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsMIUI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isMIUI' and count(parameter)=0]"
			[Register ("isMIUI", "()Z", "")]
			get {
				const string __id = "isMIUI.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsMIUIV5 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isMIUIV5' and count(parameter)=0]"
			[Register ("isMIUIV5", "()Z", "")]
			get {
				const string __id = "isMIUIV5.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsMIUIV6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isMIUIV6' and count(parameter)=0]"
			[Register ("isMIUIV6", "()Z", "")]
			get {
				const string __id = "isMIUIV6.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsMIUIV7 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isMIUIV7' and count(parameter)=0]"
			[Register ("isMIUIV7", "()Z", "")]
			get {
				const string __id = "isMIUIV7.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsMIUIV8 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isMIUIV8' and count(parameter)=0]"
			[Register ("isMIUIV8", "()Z", "")]
			get {
				const string __id = "isMIUIV8.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsMIUIV9 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isMIUIV9' and count(parameter)=0]"
			[Register ("isMIUIV9", "()Z", "")]
			get {
				const string __id = "isMIUIV9.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsMeizu {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isMeizu' and count(parameter)=0]"
			[Register ("isMeizu", "()Z", "")]
			get {
				const string __id = "isMeizu.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsOppo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isOppo' and count(parameter)=0]"
			[Register ("isOppo", "()Z", "")]
			get {
				const string __id = "isOppo.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsVivo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isVivo' and count(parameter)=0]"
			[Register ("isVivo", "()Z", "")]
			get {
				const string __id = "isVivo.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsXiaomi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isXiaomi' and count(parameter)=0]"
			[Register ("isXiaomi", "()Z", "")]
			get {
				const string __id = "isXiaomi.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsZTKC2016 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isZTKC2016' and count(parameter)=0]"
			[Register ("isZTKC2016", "()Z", "")]
			get {
				const string __id = "isZTKC2016.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsZUKZ1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isZUKZ1' and count(parameter)=0]"
			[Register ("isZUKZ1", "()Z", "")]
			get {
				const string __id = "isZUKZ1.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isFloatWindowOpAllowed' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isFloatWindowOpAllowed", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsFloatWindowOpAllowed (global::Android.Content.Context context)
		{
			const string __id = "isFloatWindowOpAllowed.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isFlymeLowerThan' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isFlymeLowerThan", "(I)Z", "")]
		public static unsafe bool IsFlymeLowerThan (int majorVersion)
		{
			const string __id = "isFlymeLowerThan.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (majorVersion);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isFlymeLowerThan' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("isFlymeLowerThan", "(III)Z", "")]
		public static unsafe bool IsFlymeLowerThan (int majorVersion, int minorVersion, int patchVersion)
		{
			const string __id = "isFlymeLowerThan.(III)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (majorVersion);
				__args [1] = new JniArgumentValue (minorVersion);
				__args [2] = new JniArgumentValue (patchVersion);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDeviceHelper']/method[@name='isTablet' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isTablet", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsTablet (global::Android.Content.Context context)
		{
			const string __id = "isTablet.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
