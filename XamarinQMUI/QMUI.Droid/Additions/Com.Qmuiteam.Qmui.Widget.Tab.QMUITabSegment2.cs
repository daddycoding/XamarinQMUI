using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Tab {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment2']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUITabSegment2", DoNotGenerateAcw=true)]
	public partial class QMUITabSegment2 : global::Com.Qmuiteam.Qmui.Widget.Tab.QMUIBasicTabSegment {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment2.TabLayoutOnPageChangeListener']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/tab/QMUITabSegment2$TabLayoutOnPageChangeListener", DoNotGenerateAcw=true)]
		public partial class TabLayoutOnPageChangeListener : global::AndroidX.ViewPager2.Widget.ViewPager2.OnPageChangeCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUITabSegment2$TabLayoutOnPageChangeListener", typeof (TabLayoutOnPageChangeListener));
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

			protected TabLayoutOnPageChangeListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment2.TabLayoutOnPageChangeListener']/constructor[@name='QMUITabSegment2.TabLayoutOnPageChangeListener' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.tab.QMUITabSegment2']]"
			[Register (".ctor", "(Lcom/qmuiteam/qmui/widget/tab/QMUITabSegment2;)V", "")]
			public unsafe TabLayoutOnPageChangeListener (global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabSegment2 tabSegment)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/qmuiteam/qmui/widget/tab/QMUITabSegment2;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((tabSegment == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tabSegment).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (tabSegment);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/tab/QMUITabSegment2", typeof (QMUITabSegment2));
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

		protected QMUITabSegment2 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment2']/constructor[@name='QMUITabSegment2' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUITabSegment2 (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment2']/constructor[@name='QMUITabSegment2' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUITabSegment2 (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment2']/constructor[@name='QMUITabSegment2' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUITabSegment2 (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_setupWithViewPager_Landroidx_viewpager2_widget_ViewPager2_;
#pragma warning disable 0169
		static Delegate GetSetupWithViewPager_Landroidx_viewpager2_widget_ViewPager2_Handler ()
		{
			if (cb_setupWithViewPager_Landroidx_viewpager2_widget_ViewPager2_ == null)
				cb_setupWithViewPager_Landroidx_viewpager2_widget_ViewPager2_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetupWithViewPager_Landroidx_viewpager2_widget_ViewPager2_);
			return cb_setupWithViewPager_Landroidx_viewpager2_widget_ViewPager2_;
		}

		static void n_SetupWithViewPager_Landroidx_viewpager2_widget_ViewPager2_ (IntPtr jnienv, IntPtr native__this, IntPtr native_viewPager)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Tab.QMUITabSegment2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var viewPager = global::Java.Lang.Object.GetObject<global::AndroidX.ViewPager2.Widget.ViewPager2> (native_viewPager, JniHandleOwnership.DoNotTransfer);
			__this.SetupWithViewPager (viewPager);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.tab']/class[@name='QMUITabSegment2']/method[@name='setupWithViewPager' and count(parameter)=1 and parameter[1][@type='androidx.viewpager2.widget.ViewPager2']]"
		[Register ("setupWithViewPager", "(Landroidx/viewpager2/widget/ViewPager2;)V", "GetSetupWithViewPager_Landroidx_viewpager2_widget_ViewPager2_Handler")]
		public virtual unsafe void SetupWithViewPager (global::AndroidX.ViewPager2.Widget.ViewPager2 viewPager)
		{
			const string __id = "setupWithViewPager.(Landroidx/viewpager2/widget/ViewPager2;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((viewPager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPager).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (viewPager);
			}
		}

	}
}
