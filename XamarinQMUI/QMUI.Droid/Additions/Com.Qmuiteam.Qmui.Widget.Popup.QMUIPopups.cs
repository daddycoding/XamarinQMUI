using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Popup {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIPopups']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/popup/QMUIPopups", DoNotGenerateAcw=true)]
	public partial class QMUIPopups : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/popup/QMUIPopups", typeof (QMUIPopups));
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

		protected QMUIPopups (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIPopups']/constructor[@name='QMUIPopups' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIPopups ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIPopups']/method[@name='fullScreenPopup' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("fullScreenPopup", "(Landroid/content/Context;)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup FullScreenPopup (global::Android.Content.Context context)
		{
			const string __id = "fullScreenPopup.(Landroid/content/Context;)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIPopups']/method[@name='listPopup' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.widget.BaseAdapter'] and parameter[5][@type='android.widget.AdapterView.OnItemClickListener']]"
		[Register ("listPopup", "(Landroid/content/Context;IILandroid/widget/BaseAdapter;Landroid/widget/AdapterView$OnItemClickListener;)Lcom/qmuiteam/qmui/widget/popup/QMUIPopup;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIPopup ListPopup (global::Android.Content.Context context, int width, int maxHeight, global::Android.Widget.BaseAdapter adapter, global::Android.Widget.AdapterView.IOnItemClickListener onItemClickListener)
		{
			const string __id = "listPopup.(Landroid/content/Context;IILandroid/widget/BaseAdapter;Landroid/widget/AdapterView$OnItemClickListener;)Lcom/qmuiteam/qmui/widget/popup/QMUIPopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (maxHeight);
				__args [3] = new JniArgumentValue ((adapter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adapter).Handle);
				__args [4] = new JniArgumentValue ((onItemClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onItemClickListener).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIPopup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (adapter);
				global::System.GC.KeepAlive (onItemClickListener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIPopups']/method[@name='popup' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("popup", "(Landroid/content/Context;)Lcom/qmuiteam/qmui/widget/popup/QMUIPopup;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIPopup Popup (global::Android.Content.Context context)
		{
			const string __id = "popup.(Landroid/content/Context;)Lcom/qmuiteam/qmui/widget/popup/QMUIPopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIPopup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIPopups']/method[@name='popup' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("popup", "(Landroid/content/Context;I)Lcom/qmuiteam/qmui/widget/popup/QMUIPopup;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIPopup Popup (global::Android.Content.Context context, int width)
		{
			const string __id = "popup.(Landroid/content/Context;I)Lcom/qmuiteam/qmui/widget/popup/QMUIPopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (width);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIPopup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIPopups']/method[@name='popup' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("popup", "(Landroid/content/Context;II)Lcom/qmuiteam/qmui/widget/popup/QMUIPopup;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIPopup Popup (global::Android.Content.Context context, int width, int height)
		{
			const string __id = "popup.(Landroid/content/Context;II)Lcom/qmuiteam/qmui/widget/popup/QMUIPopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIPopup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIPopups']/method[@name='quickAction' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("quickAction", "(Landroid/content/Context;II)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction QuickAction (global::Android.Content.Context context, int actionWidth, int actionHeight)
		{
			const string __id = "quickAction.(Landroid/content/Context;II)Lcom/qmuiteam/qmui/widget/popup/QMUIQuickAction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (actionWidth);
				__args [2] = new JniArgumentValue (actionHeight);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIQuickAction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
