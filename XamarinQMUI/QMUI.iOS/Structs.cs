using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
namespace QMUI.iOS
{

	[Native]
	public enum QMUICornerMask : nuint
	{
		MinXMinYCorner = 1 << 0,
		MaxXMinYCorner = 1 << 1,
		MinXMaxYCorner = 1 << 2,
		MaxXMaxYCorner = 1 << 3,
		AllCorner = MinXMinYCorner | MaxXMinYCorner | MinXMaxYCorner | MaxXMaxYCorner
	}

	[Native]
	public enum QMUITableViewCellPosition : nint
	{
		None = 0,
		FirstInSection = 1 << 0,
		MiddleInSection = 1 << 1,
		LastInSection = 1 << 2,
		SingleInSection = FirstInSection | LastInSection
	}

	[Native]
	public enum QMUIAlbumContentType : nuint
	{
		All,
		OnlyPhoto,
		OnlyVideo,
		OnlyAudio
	}

	[Native]
	public enum QMUIAlbumSortType : nuint
	{
		Positive,
		Reverse
	}

	[Native]
	public enum QMUIModalPresentationAnimationStyle : nuint
	{
		Fade,
		Popup,
		Slide
	}

	[Native]
	public enum QMUIAlertActionStyle : nint
	{
		Default = 0,
		Cancel,
		Destructive
	}

	[Native]
	public enum QMUIAlertControllerStyle : nint
	{
		ctionSheet = 0,
		lert
	}

	static class CFunctions
	{
		// CGFloat QMUI_Linear (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_Linear(nfloat t);

		// CGFloat QMUI_EaseInSine (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInSine(nfloat t);

		// CGFloat QMUI_EaseOutSine (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseOutSine(nfloat t);

		// CGFloat QMUI_EaseInOutSine (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInOutSine(nfloat t);

		// CGFloat QMUI_EaseInQuad (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInQuad(nfloat t);

		// CGFloat QMUI_EaseOutQuad (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseOutQuad(nfloat t);

		// CGFloat QMUI_EaseInOutQuad (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInOutQuad(nfloat t);

		// CGFloat QMUI_EaseInCubic (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInCubic(nfloat t);

		// CGFloat QMUI_EaseOutCubic (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseOutCubic(nfloat t);

		// CGFloat QMUI_EaseInOutCubic (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInOutCubic(nfloat t);

		// CGFloat QMUI_EaseInQuart (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInQuart(nfloat t);

		// CGFloat QMUI_EaseOutQuart (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseOutQuart(nfloat t);

		// CGFloat QMUI_EaseInOutQuart (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInOutQuart(nfloat t);

		// CGFloat QMUI_EaseInQuint (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInQuint(nfloat t);

		// CGFloat QMUI_EaseOutQuint (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseOutQuint(nfloat t);

		// CGFloat QMUI_EaseInOutQuint (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInOutQuint(nfloat t);

		// CGFloat QMUI_EaseInExpo (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInExpo(nfloat t);

		// CGFloat QMUI_EaseOutExpo (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseOutExpo(nfloat t);

		// CGFloat QMUI_EaseInOutExpo (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInOutExpo(nfloat t);

		// CGFloat QMUI_EaseInCirc (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInCirc(nfloat t);

		// CGFloat QMUI_EaseOutCirc (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseOutCirc(nfloat t);

		// CGFloat QMUI_EaseInOutCirc (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInOutCirc(nfloat t);

		// CGFloat QMUI_EaseInBack (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInBack(nfloat t);

		// CGFloat QMUI_EaseOutBack (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseOutBack(nfloat t);

		// CGFloat QMUI_EaseInOutBack (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInOutBack(nfloat t);

		// CGFloat QMUI_EaseInElastic (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInElastic(nfloat t);

		// CGFloat QMUI_EaseOutElastic (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseOutElastic(nfloat t);

		// CGFloat QMUI_EaseInOutElastic (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInOutElastic(nfloat t);

		// CGFloat QMUI_EaseOutBounce (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseOutBounce(nfloat t);

		// CGFloat QMUI_EaseInBounce (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInBounce(nfloat t);

		// CGFloat QMUI_EaseInOutBounce (CGFloat t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseInOutBounce(nfloat t);

		// CGFloat QMUI_EaseSpring (CGFloat t, CGFloat mass, CGFloat damping, CGFloat stiffness, CGFloat initialVelocity);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat QMUI_EaseSpring(nfloat t, nfloat mass, nfloat damping, nfloat stiffness, nfloat initialVelocity);

		// extern void QMUIImageWriteToSavedPhotosAlbumWithAlbumAssetsGroup (UIImage *image, QMUIAssetsGroup *albumAssetsGroup, QMUIWriteAssetCompletionBlock completionBlock);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern void QMUIImageWriteToSavedPhotosAlbumWithAlbumAssetsGroup(UIImage image, QMUIAssetsGroup albumAssetsGroup, QMUIWriteAssetCompletionBlock completionBlock);

		// extern void QMUISaveImageAtPathToSavedPhotosAlbumWithAlbumAssetsGroup (NSString *imagePath, QMUIAssetsGroup *albumAssetsGroup, QMUIWriteAssetCompletionBlock completionBlock);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern void QMUISaveImageAtPathToSavedPhotosAlbumWithAlbumAssetsGroup(NSString imagePath, QMUIAssetsGroup albumAssetsGroup, QMUIWriteAssetCompletionBlock completionBlock);

		// extern void QMUISaveVideoAtPathToSavedPhotosAlbumWithAlbumAssetsGroup (NSString *videoPath, QMUIAssetsGroup *albumAssetsGroup, QMUIWriteAssetCompletionBlock completionBlock);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern void QMUISaveVideoAtPathToSavedPhotosAlbumWithAlbumAssetsGroup(NSString videoPath, QMUIAssetsGroup albumAssetsGroup, QMUIWriteAssetCompletionBlock completionBlock);

		// void AddAccessibilityLabel (NSObject *obj, NSString *label);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern void AddAccessibilityLabel(NSObject obj, NSString label);

		// void AddAccessibilityHint (NSObject *obj, NSString *hint);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern void AddAccessibilityHint(NSObject obj, NSString hint);

		// SEL setterWithGetter (SEL getter);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern Selector setterWithGetter(Selector getter);

		// CGFloat removeFloatMin (CGFloat floatValue);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat removeFloatMin(nfloat floatValue);

		// CGFloat flatSpecificScale (CGFloat floatValue, CGFloat scale);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat flatSpecificScale(nfloat floatValue, nfloat scale);

		// CGFloat flat (CGFloat floatValue);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat flat(nfloat floatValue);

		// CGFloat floorInPixel (CGFloat floatValue);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat floorInPixel(nfloat floatValue);

		// BOOL between (CGFloat minimumValue, CGFloat value, CGFloat maximumValue);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool between(nfloat minimumValue, nfloat value, nfloat maximumValue);

		// BOOL betweenOrEqual (CGFloat minimumValue, CGFloat value, CGFloat maximumValue);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool betweenOrEqual(nfloat minimumValue, nfloat value, nfloat maximumValue);

		// CGFloat CGFloatToFixed (CGFloat value, NSUInteger precision);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat CGFloatToFixed(nfloat value, nuint precision);

		// NSInteger _RoundedIntegerFromCGFloat (CGFloat value, NSUInteger precision);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nint _RoundedIntegerFromCGFloat(nfloat value, nuint precision);

		// BOOL CGFloatEqualToFloatWithPrecision (CGFloat value1, CGFloat value2, NSUInteger precision);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool CGFloatEqualToFloatWithPrecision(nfloat value1, nfloat value2, nuint precision);

		// BOOL CGFloatEqualToFloat (CGFloat value1, CGFloat value2);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool CGFloatEqualToFloat(nfloat value1, nfloat value2);

		// BOOL CGFloatLessThanFloatWithPrecision (CGFloat value1, CGFloat value2, NSUInteger precision);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool CGFloatLessThanFloatWithPrecision(nfloat value1, nfloat value2, nuint precision);

		// BOOL CGFloatLessThanFloat (CGFloat value1, CGFloat value2);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool CGFloatLessThanFloat(nfloat value1, nfloat value2);

		// BOOL CGFloatLessThanOrEqualToFloatWithPrecision (CGFloat value1, CGFloat value2, NSUInteger precision);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool CGFloatLessThanOrEqualToFloatWithPrecision(nfloat value1, nfloat value2, nuint precision);

		// BOOL CGFloatLessThanOrEqualToFloat (CGFloat value1, CGFloat value2);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool CGFloatLessThanOrEqualToFloat(nfloat value1, nfloat value2);

		// BOOL CGFloatMoreThanFloatWithPrecision (CGFloat value1, CGFloat value2, NSUInteger precision);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool CGFloatMoreThanFloatWithPrecision(nfloat value1, nfloat value2, nuint precision);

		// BOOL CGFloatMoreThanFloat (CGFloat value1, CGFloat value2);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool CGFloatMoreThanFloat(nfloat value1, nfloat value2);

		// BOOL CGFloatMoreThanOrEqualToFloatWithPrecision (CGFloat value1, CGFloat value2, NSUInteger precision);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool CGFloatMoreThanOrEqualToFloatWithPrecision(nfloat value1, nfloat value2, nuint precision);

		// BOOL CGFloatMoreThanOrEqualToFloat (CGFloat value1, CGFloat value2);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool CGFloatMoreThanOrEqualToFloat(nfloat value1, nfloat value2);

		// CGFloat CGFloatGetCenter (CGFloat parent, CGFloat child);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat CGFloatGetCenter(nfloat parent, nfloat child);

		// CGFloat CGFloatSafeValue (CGFloat value);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat CGFloatSafeValue(nfloat value);

		// CGPoint CGPointUnion (CGPoint point1, CGPoint point2);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGPoint CGPointUnion(CGPoint point1, CGPoint point2);

		// CGPoint CGPointGetCenterWithRect (CGRect rect);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGPoint CGPointGetCenterWithRect(CGRect rect);

		// CGPoint CGPointGetCenterWithSize (CGSize size);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGPoint CGPointGetCenterWithSize(CGSize size);

		// CGPoint CGPointToFixed (CGPoint point, NSUInteger precision);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGPoint CGPointToFixed(CGPoint point, nuint precision);

		// CGPoint CGPointRemoveFloatMin (CGPoint point);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGPoint CGPointRemoveFloatMin(CGPoint point);

		// CGFloat UIEdgeInsetsGetHorizontalValue (UIEdgeInsets insets);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat UIEdgeInsetsGetHorizontalValue(UIEdgeInsets insets);

		// CGFloat UIEdgeInsetsGetVerticalValue (UIEdgeInsets insets);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat UIEdgeInsetsGetVerticalValue(UIEdgeInsets insets);

		// UIEdgeInsets UIEdgeInsetsConcat (UIEdgeInsets insets1, UIEdgeInsets insets2);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern UIEdgeInsets UIEdgeInsetsConcat(UIEdgeInsets insets1, UIEdgeInsets insets2);

		// UIEdgeInsets UIEdgeInsetsSetTop (UIEdgeInsets insets, CGFloat top);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern UIEdgeInsets UIEdgeInsetsSetTop(UIEdgeInsets insets, nfloat top);

		// UIEdgeInsets UIEdgeInsetsSetLeft (UIEdgeInsets insets, CGFloat left);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern UIEdgeInsets UIEdgeInsetsSetLeft(UIEdgeInsets insets, nfloat left);

		// UIEdgeInsets UIEdgeInsetsSetBottom (UIEdgeInsets insets, CGFloat bottom);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern UIEdgeInsets UIEdgeInsetsSetBottom(UIEdgeInsets insets, nfloat bottom);

		// UIEdgeInsets UIEdgeInsetsSetRight (UIEdgeInsets insets, CGFloat right);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern UIEdgeInsets UIEdgeInsetsSetRight(UIEdgeInsets insets, nfloat right);

		// UIEdgeInsets UIEdgeInsetsToFixed (UIEdgeInsets insets, NSUInteger precision);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern UIEdgeInsets UIEdgeInsetsToFixed(UIEdgeInsets insets, nuint precision);

		// UIEdgeInsets UIEdgeInsetsRemoveFloatMin (UIEdgeInsets insets);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern UIEdgeInsets UIEdgeInsetsRemoveFloatMin(UIEdgeInsets insets);

		// BOOL CGSizeIsNaN (CGSize size);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool CGSizeIsNaN(CGSize size);

		// BOOL CGSizeIsInf (CGSize size);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool CGSizeIsInf(CGSize size);

		// BOOL CGSizeIsEmpty (CGSize size);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool CGSizeIsEmpty(CGSize size);

		// BOOL CGSizeIsValidated (CGSize size);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool CGSizeIsValidated(CGSize size);

		// CGSize CGSizeFlatted (CGSize size);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGSize CGSizeFlatted(CGSize size);

		// CGSize CGSizeCeil (CGSize size);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGSize CGSizeCeil(CGSize size);

		// CGSize CGSizeFloor (CGSize size);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGSize CGSizeFloor(CGSize size);

		// CGSize CGSizeToFixed (CGSize size, NSUInteger precision);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGSize CGSizeToFixed(CGSize size, nuint precision);

		// CGSize CGSizeRemoveFloatMin (CGSize size);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGSize CGSizeRemoveFloatMin(CGSize size);

		// BOOL CGRectIsNaN (CGRect rect);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool CGRectIsNaN(CGRect rect);

		// BOOL CGRectIsInf (CGRect rect);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool CGRectIsInf(CGRect rect);

		// BOOL CGRectIsValidated (CGRect rect);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool CGRectIsValidated(CGRect rect);

		// CGRect CGRectSafeValue (CGRect rect);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectSafeValue(CGRect rect);

		// CGRect CGRectFlatMake (CGFloat x, CGFloat y, CGFloat width, CGFloat height);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectFlatMake(nfloat x, nfloat y, nfloat width, nfloat height);

		// CGRect CGRectFlatted (CGRect rect);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectFlatted(CGRect rect);

		// CGPoint CGPointApplyAffineTransformWithCoordinatePoint (CGPoint coordinatePoint, CGPoint targetPoint, CGAffineTransform t);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGPoint CGPointApplyAffineTransformWithCoordinatePoint(CGPoint coordinatePoint, CGPoint targetPoint, CGAffineTransform t);

		// CGRect CGRectApplyAffineTransformWithAnchorPoint (CGRect rect, CGAffineTransform t, CGPoint anchorPoint);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectApplyAffineTransformWithAnchorPoint(CGRect rect, CGAffineTransform t, CGPoint anchorPoint);

		// CGRect CGRectApplyScale (CGRect rect, CGFloat scale);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectApplyScale(CGRect rect, nfloat scale);

		// CGFloat CGRectGetMinXHorizontallyCenterInParentRect (CGRect parentRect, CGRect childRect);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat CGRectGetMinXHorizontallyCenterInParentRect(CGRect parentRect, CGRect childRect);

		// CGFloat CGRectGetMinYVerticallyCenterInParentRect (CGRect parentRect, CGRect childRect);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat CGRectGetMinYVerticallyCenterInParentRect(CGRect parentRect, CGRect childRect);

		// CGFloat CGRectGetMinYVerticallyCenter (CGRect referenceRect, CGRect layoutingRect);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat CGRectGetMinYVerticallyCenter(CGRect referenceRect, CGRect layoutingRect);

		// CGFloat CGRectGetMinXHorizontallyCenter (CGRect referenceRect, CGRect layoutingRect);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern nfloat CGRectGetMinXHorizontallyCenter(CGRect referenceRect, CGRect layoutingRect);

		// CGRect CGRectInsetEdges (CGRect rect, UIEdgeInsets insets);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectInsetEdges(CGRect rect, UIEdgeInsets insets);

		// CGRect CGRectMakeWithSize (CGSize size);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectMakeWithSize(CGSize size);

		// CGRect CGRectFloatTop (CGRect rect, CGFloat top);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectFloatTop(CGRect rect, nfloat top);

		// CGRect CGRectFloatBottom (CGRect rect, CGFloat bottom);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectFloatBottom(CGRect rect, nfloat bottom);

		// CGRect CGRectFloatRight (CGRect rect, CGFloat right);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectFloatRight(CGRect rect, nfloat right);

		// CGRect CGRectFloatLeft (CGRect rect, CGFloat left);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectFloatLeft(CGRect rect, nfloat left);

		// CGRect CGRectLimitRight (CGRect rect, CGFloat rightLimit);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectLimitRight(CGRect rect, nfloat rightLimit);

		// CGRect CGRectLimitLeft (CGRect rect, CGFloat leftLimit);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectLimitLeft(CGRect rect, nfloat leftLimit);

		// CGRect CGRectLimitMaxWidth (CGRect rect, CGFloat maxWidth);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectLimitMaxWidth(CGRect rect, nfloat maxWidth);

		// CGRect CGRectSetX (CGRect rect, CGFloat x);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectSetX(CGRect rect, nfloat x);

		// CGRect CGRectSetY (CGRect rect, CGFloat y);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectSetY(CGRect rect, nfloat y);

		// CGRect CGRectSetXY (CGRect rect, CGFloat x, CGFloat y);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectSetXY(CGRect rect, nfloat x, nfloat y);

		// CGRect CGRectSetWidth (CGRect rect, CGFloat width);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectSetWidth(CGRect rect, nfloat width);

		// CGRect CGRectSetHeight (CGRect rect, CGFloat height);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectSetHeight(CGRect rect, nfloat height);

		// CGRect CGRectSetSize (CGRect rect, CGSize size);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectSetSize(CGRect rect, CGSize size);

		// CGRect CGRectToFixed (CGRect rect, NSUInteger precision);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectToFixed(CGRect rect, nuint precision);

		// CGRect CGRectRemoveFloatMin (CGRect rect);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern CGRect CGRectRemoveFloatMin(CGRect rect);

		// BOOL NSContainingRanges (NSRange outerRange, NSRange innerRange);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool NSContainingRanges(NSRange outerRange, NSRange innerRange);

		// BOOL HasOverrideSuperclassMethod (Class targetClass, SEL targetSelector);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool HasOverrideSuperclassMethod(Class targetClass, Selector targetSelector);

		// BOOL ExchangeImplementationsInTwoClasses (Class _fromClass, SEL _originSelector, Class _toClass, SEL _newSelector);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool ExchangeImplementationsInTwoClasses(Class _fromClass, Selector _originSelector, Class _toClass, Selector _newSelector);

		// BOOL ExchangeImplementations (Class _class, SEL _originSelector, SEL _newSelector);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool ExchangeImplementations(Class _class, Selector _originSelector, Selector _newSelector);

		// BOOL OverrideImplementation (Class targetClass, SEL targetSelector, id (^implementationBlock)(Class, SEL, IMP (^)(void)));
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool OverrideImplementation(Class targetClass, Selector targetSelector, Func<Class, Selector, Func<IMP*>, NSObject> implementationBlock);

		// BOOL ExtendImplementationOfVoidMethodWithoutArguments (Class targetClass, SEL targetSelector, void (^implementationBlock)(__kindof NSObject *));
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern bool ExtendImplementationOfVoidMethodWithoutArguments(Class targetClass, Selector targetSelector, Action<NSObject> implementationBlock);

		// BOOL isCharTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isCharTypeEncoding(sbyte* typeEncoding);

		// BOOL isCharIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isCharIvar(Ivar* ivar);

		// BOOL isIntTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isIntTypeEncoding(sbyte* typeEncoding);

		// BOOL isIntIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isIntIvar(Ivar* ivar);

		// BOOL isShortTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isShortTypeEncoding(sbyte* typeEncoding);

		// BOOL isShortIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isShortIvar(Ivar* ivar);

		// BOOL isLongTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isLongTypeEncoding(sbyte* typeEncoding);

		// BOOL isLongIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isLongIvar(Ivar* ivar);

		// BOOL isLongLongTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isLongLongTypeEncoding(sbyte* typeEncoding);

		// BOOL isLongLongIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isLongLongIvar(Ivar* ivar);

		// BOOL isNSIntegerTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isNSIntegerTypeEncoding(sbyte* typeEncoding);

		// BOOL isNSIntegerIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isNSIntegerIvar(Ivar* ivar);

		// BOOL isUnsignedCharTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isUnsignedCharTypeEncoding(sbyte* typeEncoding);

		// BOOL isUnsignedCharIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isUnsignedCharIvar(Ivar* ivar);

		// BOOL isUnsignedIntTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isUnsignedIntTypeEncoding(sbyte* typeEncoding);

		// BOOL isUnsignedIntIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isUnsignedIntIvar(Ivar* ivar);

		// BOOL isUnsignedShortTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isUnsignedShortTypeEncoding(sbyte* typeEncoding);

		// BOOL isUnsignedShortIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isUnsignedShortIvar(Ivar* ivar);

		// BOOL isUnsignedLongTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isUnsignedLongTypeEncoding(sbyte* typeEncoding);

		// BOOL isUnsignedLongIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isUnsignedLongIvar(Ivar* ivar);

		// BOOL isUnsignedLongLongTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isUnsignedLongLongTypeEncoding(sbyte* typeEncoding);

		// BOOL isUnsignedLongLongIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isUnsignedLongLongIvar(Ivar* ivar);

		// BOOL isNSUIntegerTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isNSUIntegerTypeEncoding(sbyte* typeEncoding);

		// BOOL isNSUIntegerIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isNSUIntegerIvar(Ivar* ivar);

		// BOOL isFloatTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isFloatTypeEncoding(sbyte* typeEncoding);

		// BOOL isFloatIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isFloatIvar(Ivar* ivar);

		// BOOL isDoubleTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isDoubleTypeEncoding(sbyte* typeEncoding);

		// BOOL isDoubleIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isDoubleIvar(Ivar* ivar);

		// BOOL isCGFloatTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isCGFloatTypeEncoding(sbyte* typeEncoding);

		// BOOL isCGFloatIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isCGFloatIvar(Ivar* ivar);

		// BOOL isBOOLTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isBOOLTypeEncoding(sbyte* typeEncoding);

		// BOOL isBOOLIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isBOOLIvar(Ivar* ivar);

		// BOOL isVoidTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isVoidTypeEncoding(sbyte* typeEncoding);

		// BOOL isVoidIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isVoidIvar(Ivar* ivar);

		// BOOL isCharacterTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isCharacterTypeEncoding(sbyte* typeEncoding);

		// BOOL isCharacterIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isCharacterIvar(Ivar* ivar);

		// BOOL isObjectTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isObjectTypeEncoding(sbyte* typeEncoding);

		// BOOL isObjectIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isObjectIvar(Ivar* ivar);

		// BOOL isClassTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isClassTypeEncoding(sbyte* typeEncoding);

		// BOOL isClassIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isClassIvar(Ivar* ivar);

		// BOOL isSelectorTypeEncoding (const char *typeEncoding);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isSelectorTypeEncoding(sbyte* typeEncoding);

		// BOOL isSelectorIvar (Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool isSelectorIvar(Ivar* ivar);

		// char getCharIvarValue (id object, Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe sbyte getCharIvarValue(NSObject @object, Ivar* ivar);

		// int getIntIvarValue (id object, Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe int getIntIvarValue(NSObject @object, Ivar* ivar);

		// short getShortIvarValue (id object, Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe short getShortIvarValue(NSObject @object, Ivar* ivar);

		// long getLongIvarValue (id object, Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe nint getLongIvarValue(NSObject @object, Ivar* ivar);

		// long long getLongLongIvarValue (id object, Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe long getLongLongIvarValue(NSObject @object, Ivar* ivar);

		// unsigned char getUnsignedCharIvarValue (id object, Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe byte getUnsignedCharIvarValue(NSObject @object, Ivar* ivar);

		// unsigned int getUnsignedIntIvarValue (id object, Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe uint getUnsignedIntIvarValue(NSObject @object, Ivar* ivar);

		// unsigned short getUnsignedShortIvarValue (id object, Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe ushort getUnsignedShortIvarValue(NSObject @object, Ivar* ivar);

		// unsigned long getUnsignedLongIvarValue (id object, Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe nuint getUnsignedLongIvarValue(NSObject @object, Ivar* ivar);

		// unsigned long long getUnsignedLongLongIvarValue (id object, Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe ulong getUnsignedLongLongIvarValue(NSObject @object, Ivar* ivar);

		// float getFloatIvarValue (id object, Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe float getFloatIvarValue(NSObject @object, Ivar* ivar);

		// double getDoubleIvarValue (id object, Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe double getDoubleIvarValue(NSObject @object, Ivar* ivar);

		// BOOL getBOOLIvarValue (id object, Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool getBOOLIvarValue(NSObject @object, Ivar* ivar);

		// char * getCharacterIvarValue (id object, Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe sbyte* getCharacterIvarValue(NSObject @object, Ivar* ivar);

		// SEL getSelectorIvarValue (id object, Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe Selector getSelectorIvarValue(NSObject @object, Ivar* ivar);

		// id getObjectIvarValue (id object, Ivar ivar);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe NSObject getObjectIvarValue(NSObject @object, Ivar* ivar);

		// extern int qmui_getProjectClassList (classref_t **classes);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe int qmui_getProjectClassList(classref_t*** classes);

		// extern BOOL qmui_exists_dyld_image (const char *target_image_name);
		[DllImport("__Internal")]
		[Verify(PlatformInvoke)]
		static extern unsafe bool qmui_exists_dyld_image(sbyte* target_image_name);
	}

	[Native]
	public enum QMUIAnimationEasings : nint
	{
		Linear,
		EaseInSine,
		EaseOutSine,
		EaseInOutSine,
		EaseInQuad,
		EaseOutQuad,
		EaseInOutQuad,
		EaseInCubic,
		EaseOutCubic,
		EaseInOutCubic,
		EaseInQuart,
		EaseOutQuart,
		EaseInOutQuart,
		EaseInQuint,
		EaseOutQuint,
		EaseInOutQuint,
		EaseInExpo,
		EaseOutExpo,
		EaseInOutExpo,
		EaseInCirc,
		EaseOutCirc,
		EaseInOutCirc,
		EaseInBack,
		EaseOutBack,
		EaseInOutBack,
		EaseInElastic,
		EaseOutElastic,
		EaseInOutElastic,
		EaseInBounce,
		EaseOutBounce,
		EaseInOutBounce,
		Spring,
		SpringKeyboard
	}

	[Native]
	public enum QMUIAssetType : nuint
	{
		Unknow,
		Image,
		Video,
		Audio
	}

	[Native]
	public enum QMUIAssetSubType : nuint
	{
		Unknow,
		Image,
		LivePhoto,
		Gif
	}

	[Native]
	public enum QMUIAssetDownloadStatus : nuint
	{
		Succeed,
		Downloading,
		Canceled,
		Failed
	}

	[Native]
	public enum QMUIAssetAuthorizationStatus : nuint
	{
		NotDetermined,
		Authorized,
		NotAuthorized
	}

	[Native]
	public enum QMUILogLevel : nuint
	{
		Default,
		Info,
		Warn
	}

	[Native]
	public enum QMUIButtonImagePosition : nuint
	{
		Top,
		Left,
		Bottom,
		Right
	}

	[Native]
	public enum QMUICollectionViewPagingLayoutStyle : nint
	{
		Default,
		Scale,
		Rotation
	}

	[Native]
	public enum QMUIFillButtonColor : nuint
	{
		Blue,
		Red,
		Green,
		Gray,
		White
	}

	[Native]
	public enum QMUIGhostButtonColor : nuint
	{
		Blue,
		Red,
		Green,
		Gray,
		White
	}

	[Native]
	public enum QMUIImagePreviewMediaType : nuint
	{
		Image,
		LivePhoto,
		Video,
		Others
	}

	[Native]
	public enum QMUIImagePreviewViewControllerTransitioningStyle : nuint
	{
		Fade,
		Zoom
	}

	[Native]
	public enum QMUINavigationButtonType : nuint
	{
		Normal,
		Bold,
		Image,
		Back
	}

	[Native]
	public enum QMUINavigationTitleViewStyle : nint
	{
		Default,
		SubTitleVertical
	}

	[Native]
	public enum QMUINavigationTitleViewAccessoryType : nint
	{
		None,
		DisclosureIndicator
	}

	[Native]
	public enum QMUIPieProgressViewShape : nuint
	{
		Sector,
		Ring
	}

	[Native]
	public enum QMUIPopupContainerViewLayoutDirection : nuint
	{
		Above,
		Below,
		Left,
		Right
	}

	[Native]
	public enum QMUIStaticTableViewCellAccessoryType : nint
	{
		None,
		DisclosureIndicator,
		DetailDisclosureButton,
		Checkmark,
		DetailButton,
		Switch
	}

	[Native]
	public enum QMUITableViewHeaderFooterViewType : nuint
	{
		Unknow,
		Header,
		Footer
	}

	[Native]
	public enum QMUIToastViewPosition : nint
	{
		Top,
		Center,
		Bottom
	}

	[Native]
	public enum QMUIToastAnimationType : nint
	{
		Fade = 0,
		Zoom,
		Slide
	}

	[Native]
	public enum QMUIToolbarButtonType : nuint
	{
		Normal,
		Red,
		Image
	}

	[Native]
	public enum QMUICustomizeButtonPropType : nuint
	{
		Title,
		TitleColor,
		TitleShadowColor,
		Image,
		BackgroundImage,
		AttributedTitle
	}

	[Native]
	public enum QMUIFontWeight : nuint
	{
		Light,
		Normal,
		Bold
	}

	[Native]
	public enum QMUIImageShape : nint
	{
		Oval,
		Triangle,
		DisclosureIndicator,
		Checkmark,
		DetailButtonImage,
		NavBack,
		NavClose
	}

	[Native]
	public enum QMUIImageBorderPosition : nint
	{
		All = 0,
		Top = 1 << 0,
		Left = 1 << 1,
		Bottom = 1 << 2,
		Right = 1 << 3
	}

	[Native]
	public enum QMUIImageResizingMode : nint
	{
		ToFill = 0,
		AspectFit = 10,
		AspectFill = 20,
		AspectFillTop,
		AspectFillBottom
	}

	[Native]
	public enum QMUINavigationAction : nuint
	{
		Unknow,
		WillPush,
		DidPush,
		PushCompleted,
		WillPop,
		DidPop,
		PopCompleted,
		WillSet,
		DidSet,
		SetCompleted
	}

	[Native]
	public enum QMUIViewBorderPosition : nuint
	{
		None = 0,
		Top = 1 << 0,
		Left = 1 << 1,
		Bottom = 1 << 2,
		Right = 1 << 3
	}

	[Native]
	public enum QMUIViewBorderLocation : nuint
	{
		Inside,
		Center,
		Outside
	}

	[Native]
	public enum QMUIViewControllerVisibleState : nuint
	{
		Unknow = 1 << 0,
		ViewDidLoad = 1 << 1,
		WillAppear = 1 << 2,
		DidAppear = 1 << 3,
		WillDisappear = 1 << 4,
		DidDisappear = 1 << 5,
		Visible = WillAppear | DidAppear
	}

}

