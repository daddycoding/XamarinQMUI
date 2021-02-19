using System;
using System;
using AVFoundation;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Photos;
using PhotosUI;
using QuartzCore;
using UIKit;
using ObjCRuntime;
using Foundation;
using UIKit;

namespace QMUI.iOS
{

    // @interface QMUI (CAAnimation)
    [Category]
    [BaseType(typeof(CAAnimation))]
    interface CAAnimation_QMUI
    {
        // @property (copy, nonatomic) void (^qmui_animationDidStartBlock)(__kindof CAAnimation *);
        [Export("qmui_animationDidStartBlock", ArgumentSemantic.Copy)]
        Action<CAAnimation> Qmui_animationDidStartBlock { get; set; }

        // @property (copy, nonatomic) void (^qmui_animationDidStopBlock)(__kindof CAAnimation *, BOOL);
        [Export("qmui_animationDidStopBlock", ArgumentSemantic.Copy)]
        Action<CAAnimation, bool> Qmui_animationDidStopBlock { get; set; }
    }

    // @interface QMUI (CALayer)
    [Category]
    [BaseType(typeof(CALayer))]
    interface CALayer_QMUI
    {
        // @property (readonly, assign, nonatomic) BOOL qmui_isRootLayerOfView;
        [Export("qmui_isRootLayerOfView")]
        bool Qmui_isRootLayerOfView { get; }

        // @property (assign, nonatomic) BOOL qmui_pause;
        [Export("qmui_pause")]
        bool Qmui_pause { get; set; }

        // @property (assign, nonatomic) QMUICornerMask qmui_maskedCorners;
        [Export("qmui_maskedCorners", ArgumentSemantic.Assign)]
        QMUICornerMask Qmui_maskedCorners { get; set; }

        // @property (readonly, assign, nonatomic) CGFloat qmui_originCornerRadius;
        [Export("qmui_originCornerRadius")]
        nfloat Qmui_originCornerRadius { get; }

        // -(void)qmui_sendSublayerToBack:(CALayer *)sublayer;
        [Export("qmui_sendSublayerToBack:")]
        void Qmui_sendSublayerToBack(CALayer sublayer);

        // -(void)qmui_bringSublayerToFront:(CALayer *)sublayer;
        [Export("qmui_bringSublayerToFront:")]
        void Qmui_bringSublayerToFront(CALayer sublayer);

        // -(void)qmui_removeDefaultAnimations;
        [Export("qmui_removeDefaultAnimations")]
        void Qmui_removeDefaultAnimations();

        // +(void)qmui_performWithoutAnimation:(void (^)(void))actionsWithoutAnimation;
        [Static]
        [Export("qmui_performWithoutAnimation:")]
        void Qmui_performWithoutAnimation(Action actionsWithoutAnimation);

        // +(CAShapeLayer *)qmui_separatorDashLayerWithLineLength:(NSInteger)lineLength lineSpacing:(NSInteger)lineSpacing lineWidth:(CGFloat)lineWidth lineColor:(CGColorRef)lineColor isHorizontal:(BOOL)isHorizontal;
        [Static]
        [Export("qmui_separatorDashLayerWithLineLength:lineSpacing:lineWidth:lineColor:isHorizontal:")]
        unsafe CAShapeLayer Qmui_separatorDashLayerWithLineLength(nint lineLength, nint lineSpacing, nfloat lineWidth, CGColorRef* lineColor, bool isHorizontal);

        // +(CAShapeLayer *)qmui_separatorDashLayerInHorizontal;
        [Static]
        [Export("qmui_separatorDashLayerInHorizontal")]
        [Verify(MethodToProperty)]
        CAShapeLayer Qmui_separatorDashLayerInHorizontal { get; }

        // +(CAShapeLayer *)qmui_separatorDashLayerInVertical;
        [Static]
        [Export("qmui_separatorDashLayerInVertical")]
        [Verify(MethodToProperty)]
        CAShapeLayer Qmui_separatorDashLayerInVertical { get; }

        // +(CALayer *)qmui_separatorLayer;
        [Static]
        [Export("qmui_separatorLayer")]
        [Verify(MethodToProperty)]
        CALayer Qmui_separatorLayer { get; }

        // +(CALayer *)qmui_separatorLayerForTableView;
        [Static]
        [Export("qmui_separatorLayerForTableView")]
        [Verify(MethodToProperty)]
        CALayer Qmui_separatorLayerForTableView { get; }
    }

    // @interface QMUI_DynamicColor (CALayer)
    [Category]
    [BaseType(typeof(CALayer))]
    interface CALayer_QMUI_DynamicColor
    {
        // -(void)qmui_setNeedsUpdateDynamicStyle __attribute__((objc_requires_super));
        [Export("qmui_setNeedsUpdateDynamicStyle")]
        [RequiresSuper]
        void Qmui_setNeedsUpdateDynamicStyle();
    }

    // @interface QMUIViewAnimation (CALayer)
    [Category]
    [BaseType(typeof(CALayer))]
    interface CALayer_QMUIViewAnimation
    {
        // @property (assign, nonatomic) BOOL qmui_viewAnimationEnabled;
        [Export("qmui_viewAnimationEnabled")]
        bool Qmui_viewAnimationEnabled { get; set; }
    }

    // @interface QMUI (NSArray)
    [Category]
    [BaseType(typeof(NSArray))]
    interface NSArray_QMUI
    {
        // +(instancetype _Nonnull)qmui_arrayWithObjects:(ObjectType _Nonnull)object, ...;
        [Static, Internal]
        [Export("qmui_arrayWithObjects:", IsVariadic = true)]
        NSArray Qmui_arrayWithObjects(NSObject @object, IntPtr varArgs);

        // -(void)qmui_enumerateNestedArrayWithBlock:(void (^ _Nonnull)(id _Nonnull, BOOL * _Nonnull))block;
        [Export("qmui_enumerateNestedArrayWithBlock:")]
        unsafe void Qmui_enumerateNestedArrayWithBlock(Action<NSObject, bool> block);

        // -(NSMutableArray * _Nonnull)qmui_mutableCopyNestedArray;
        [Export("qmui_mutableCopyNestedArray")]
        [Verify(MethodToProperty)]
        NSMutableArray Qmui_mutableCopyNestedArray { get; }

        // -(NSArray<ObjectType> * _Nonnull)qmui_filterWithBlock:(BOOL (^ _Nonnull)(ObjectType _Nonnull))block;
        [Export("qmui_filterWithBlock:")]
        NSObject[] Qmui_filterWithBlock(Func<NSObject, bool> block);

        // -(NSArray * _Nonnull)qmui_mapWithBlock:(id  _Nonnull (^ _Nonnull)(ObjectType _Nonnull))block;
        [Export("qmui_mapWithBlock:")]
        [Verify(StronglyTypedNSArray)]
        NSObject[] Qmui_mapWithBlock(Func<NSObject, NSObject> block);
    }

    // @interface QMUI (NSAttributedString)
    [Category]
    [BaseType(typeof(NSAttributedString))]
    interface NSAttributedString_QMUI
    {
        // -(NSUInteger)qmui_lengthWhenCountingNonASCIICharacterAsTwo;
        [Export("qmui_lengthWhenCountingNonASCIICharacterAsTwo")]
        [Verify(MethodToProperty)]
        nuint Qmui_lengthWhenCountingNonASCIICharacterAsTwo { get; }

        // +(instancetype)qmui_attributedStringWithImage:(UIImage *)image;
        [Static]
        [Export("qmui_attributedStringWithImage:")]
        NSAttributedString Qmui_attributedStringWithImage(UIImage image);

        // +(instancetype)qmui_attributedStringWithImage:(UIImage *)image baselineOffset:(CGFloat)offset leftMargin:(CGFloat)leftMargin rightMargin:(CGFloat)rightMargin;
        [Static]
        [Export("qmui_attributedStringWithImage:baselineOffset:leftMargin:rightMargin:")]
        NSAttributedString Qmui_attributedStringWithImage(UIImage image, nfloat offset, nfloat leftMargin, nfloat rightMargin);

        // +(instancetype)qmui_attributedStringWithFixedSpace:(CGFloat)width;
        [Static]
        [Export("qmui_attributedStringWithFixedSpace:")]
        NSAttributedString Qmui_attributedStringWithFixedSpace(nfloat width);
    }

    // @interface QMUI (NSMutableAttributedString)
    [Category]
    [BaseType(typeof(NSMutableAttributedString))]
    interface NSMutableAttributedString_QMUI
    {
    }

    // @interface QMUI (NSCharacterSet)
    [Category]
    [BaseType(typeof(NSCharacterSet))]
    interface NSCharacterSet_QMUI
    {
        // @property (readonly, copy, class) NSCharacterSet * qmui_URLUserInputQueryAllowedCharacterSet;
        [Static]
        [Export("qmui_URLUserInputQueryAllowedCharacterSet", ArgumentSemantic.Copy)]
        NSCharacterSet Qmui_URLUserInputQueryAllowedCharacterSet { get; }
    }

    // @interface QMUI (NSMethodSignature)
    [Category]
    [BaseType(typeof(NSMethodSignature))]
    interface NSMethodSignature_QMUI
    {
        // @property (readonly, nonatomic, class) NSMethodSignature * _Nullable qmui_avoidExceptionSignature;
        [Static]
        [NullAllowed, Export("qmui_avoidExceptionSignature")]
        NSMethodSignature Qmui_avoidExceptionSignature { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable qmui_typeString;
        [NullAllowed, Export("qmui_typeString")]
        string Qmui_typeString { get; }

        // @property (readonly, nonatomic) const char * _Nullable qmui_typeEncoding;
        [NullAllowed, Export("qmui_typeEncoding")]
        unsafe sbyte* Qmui_typeEncoding { get; }
    }

    // @interface QMUI (NSNumber)
    [Category]
    [BaseType(typeof(NSNumber))]
    interface NSNumber_QMUI
    {
        // @property (readonly, assign, nonatomic) CGFloat qmui_CGFloatValue;
        [Export("qmui_CGFloatValue")]
        nfloat Qmui_CGFloatValue { get; }
    }

    //// @interface QMUI (NSObject)
    //[Category]
    //[BaseType(typeof(NSObject))]
    //interface NSObject_QMUI
    //{
    //    // -(BOOL)qmui_hasOverrideMethod:(SEL _Nonnull)selector ofSuperclass:(Class _Nonnull)superclass;
    //    [Export("qmui_hasOverrideMethod:ofSuperclass:")]
    //    bool Qmui_hasOverrideMethod(Selector selector, Class superclass);

    //    // +(BOOL)qmui_hasOverrideMethod:(SEL _Nonnull)selector forClass:(Class _Nonnull)aClass ofSuperclass:(Class _Nonnull)superclass;
    //    [Static]
    //    [Export("qmui_hasOverrideMethod:forClass:ofSuperclass:")]
    //    bool Qmui_hasOverrideMethod(Selector selector, Class aClass, Class superclass);

    //    // -(id _Nullable)qmui_performSelectorToSuperclass:(SEL _Nonnull)aSelector;
    //    [Export("qmui_performSelectorToSuperclass:")]
    //    [return: NullAllowed]
    //    NSObject Qmui_performSelectorToSuperclass(Selector aSelector);

    //    // -(id _Nullable)qmui_performSelectorToSuperclass:(SEL _Nonnull)aSelector withObject:(id _Nullable)object;
    //    [Export("qmui_performSelectorToSuperclass:withObject:")]
    //    [return: NullAllowed]
    //    NSObject Qmui_performSelectorToSuperclass(Selector aSelector, [NullAllowed] NSObject @object);

    //    // -(void)qmui_performSelector:(SEL _Nonnull)selector withPrimitiveReturnValue:(void * _Nullable)returnValue;
    //    [Export("qmui_performSelector:withPrimitiveReturnValue:")]
    //    unsafe void Qmui_performSelector(Selector selector, [NullAllowed] void* returnValue);

    //    // -(id _Nullable)qmui_performSelector:(SEL _Nonnull)selector withArguments:(void * _Nullable)firstArgument, ...;
    //    [Internal]
    //    [Export("qmui_performSelector:withArguments:", IsVariadic = true)]
    //    [return: NullAllowed]
    //    unsafe NSObject Qmui_performSelector(Selector selector, [NullAllowed] void* firstArgument, IntPtr varArgs);

    //    // -(void)qmui_performSelector:(SEL _Nonnull)selector withPrimitiveReturnValue:(void * _Nullable)returnValue arguments:(void * _Nullable)firstArgument, ...;
    //    [Internal]
    //    [Export("qmui_performSelector:withPrimitiveReturnValue:arguments:", IsVariadic = true)]
    //    unsafe void Qmui_performSelector(Selector selector, [NullAllowed] void* returnValue, [NullAllowed] void* firstArgument, IntPtr varArgs);

    //    // -(void)qmui_enumrateIvarsUsingBlock:(void (^ _Nonnull)(Ivar _Nonnull, NSString * _Nonnull))block;
    //    [Export("qmui_enumrateIvarsUsingBlock:")]
    //    unsafe void Qmui_enumrateIvarsUsingBlock(Action<Ivar*, NSString> block);

    //    // +(void)qmui_enumrateIvarsOfClass:(Class _Nonnull)aClass includingInherited:(BOOL)includingInherited usingBlock:(void (^ _Nonnull)(Ivar _Nonnull, NSString * _Nonnull))block;
    //    [Static]
    //    [Export("qmui_enumrateIvarsOfClass:includingInherited:usingBlock:")]
    //    unsafe void Qmui_enumrateIvarsOfClass(Class aClass, bool includingInherited, Action<Ivar*, NSString> block);

    //    // -(void)qmui_enumratePropertiesUsingBlock:(void (^ _Nonnull)(objc_property_t _Nonnull, NSString * _Nonnull))block;
    //    [Export("qmui_enumratePropertiesUsingBlock:")]
    //    unsafe void Qmui_enumratePropertiesUsingBlock(Action<objc_property_t*, NSString> block);

    //    // +(void)qmui_enumratePropertiesOfClass:(Class _Nonnull)aClass includingInherited:(BOOL)includingInherited usingBlock:(void (^ _Nonnull)(objc_property_t _Nonnull, NSString * _Nonnull))block;
    //    [Static]
    //    [Export("qmui_enumratePropertiesOfClass:includingInherited:usingBlock:")]
    //    unsafe void Qmui_enumratePropertiesOfClass(Class aClass, bool includingInherited, Action<objc_property_t*, NSString> block);

    //    // -(void)qmui_enumrateInstanceMethodsUsingBlock:(void (^ _Nonnull)(Method _Nonnull, SEL _Nonnull))block;
    //    [Export("qmui_enumrateInstanceMethodsUsingBlock:")]
    //    unsafe void Qmui_enumrateInstanceMethodsUsingBlock(Action<Method*, Selector> block);

    //    // +(void)qmui_enumrateInstanceMethodsOfClass:(Class _Nonnull)aClass includingInherited:(BOOL)includingInherited usingBlock:(void (^ _Nonnull)(Method _Nonnull, SEL _Nonnull))block;
    //    [Static]
    //    [Export("qmui_enumrateInstanceMethodsOfClass:includingInherited:usingBlock:")]
    //    unsafe void Qmui_enumrateInstanceMethodsOfClass(Class aClass, bool includingInherited, Action<Method*, Selector> block);

    //    // +(void)qmui_enumerateProtocolMethods:(Protocol * _Nonnull)protocol usingBlock:(void (^ _Nonnull)(SEL _Nonnull))block;
    //    [Static]
    //    [Export("qmui_enumerateProtocolMethods:usingBlock:")]
    //    void Qmui_enumerateProtocolMethods(Protocol protocol, Action<Selector> block);
    //}

    // @interface QMUI_KeyValueCoding (NSObject)
    [Category]
    [BaseType(typeof(NSObject))]
    interface NSObject_QMUI_KeyValueCoding
    {
        // -(id _Nullable)qmui_valueForKey:(NSString * _Nonnull)key;
        [Export("qmui_valueForKey:")]
        [return: NullAllowed]
        NSObject Qmui_valueForKey(string key);

        // -(void)qmui_setValue:(id _Nullable)value forKey:(NSString * _Nonnull)key;
        [Export("qmui_setValue:forKey:")]
        void Qmui_setValue([NullAllowed] NSObject value, string key);

        // -(BOOL)qmui_canGetValueForKey:(NSString * _Nonnull)key;
        [Export("qmui_canGetValueForKey:")]
        bool Qmui_canGetValueForKey(string key);

        // -(BOOL)qmui_canSetValueForKey:(NSString * _Nonnull)key;
        [Export("qmui_canSetValueForKey:")]
        bool Qmui_canSetValueForKey(string key);
    }

    // @interface QMUI_DataBind (NSObject)
    [Category]
    [BaseType(typeof(NSObject))]
    interface NSObject_QMUI_DataBind
    {
        // -(void)qmui_bindObject:(id _Nullable)object forKey:(NSString * _Nonnull)key;
        [Export("qmui_bindObject:forKey:")]
        void Qmui_bindObject([NullAllowed] NSObject @object, string key);

        // -(void)qmui_bindObjectWeakly:(id _Nullable)object forKey:(NSString * _Nonnull)key;
        [Export("qmui_bindObjectWeakly:forKey:")]
        void Qmui_bindObjectWeakly([NullAllowed] NSObject @object, string key);

        // -(id _Nullable)qmui_getBoundObjectForKey:(NSString * _Nonnull)key;
        [Export("qmui_getBoundObjectForKey:")]
        [return: NullAllowed]
        NSObject Qmui_getBoundObjectForKey(string key);

        // -(void)qmui_bindDouble:(double)doubleValue forKey:(NSString * _Nonnull)key;
        [Export("qmui_bindDouble:forKey:")]
        void Qmui_bindDouble(double doubleValue, string key);

        // -(double)qmui_getBoundDoubleForKey:(NSString * _Nonnull)key;
        [Export("qmui_getBoundDoubleForKey:")]
        double Qmui_getBoundDoubleForKey(string key);

        // -(void)qmui_bindBOOL:(BOOL)boolValue forKey:(NSString * _Nonnull)key;
        [Export("qmui_bindBOOL:forKey:")]
        void Qmui_bindBOOL(bool boolValue, string key);

        // -(BOOL)qmui_getBoundBOOLForKey:(NSString * _Nonnull)key;
        [Export("qmui_getBoundBOOLForKey:")]
        bool Qmui_getBoundBOOLForKey(string key);

        // -(void)qmui_bindLong:(long)longValue forKey:(NSString * _Nonnull)key;
        [Export("qmui_bindLong:forKey:")]
        void Qmui_bindLong(nint longValue, string key);

        // -(long)qmui_getBoundLongForKey:(NSString * _Nonnull)key;
        [Export("qmui_getBoundLongForKey:")]
        nint Qmui_getBoundLongForKey(string key);

        // -(void)qmui_clearBindingForKey:(NSString * _Nonnull)key;
        [Export("qmui_clearBindingForKey:")]
        void Qmui_clearBindingForKey(string key);

        // -(void)qmui_clearAllBinding;
        [Export("qmui_clearAllBinding")]
        void Qmui_clearAllBinding();

        // -(NSArray<NSString *> * _Nonnull)qmui_allBindingKeys;
        [Export("qmui_allBindingKeys")]
        [Verify(MethodToProperty)]
        string[] Qmui_allBindingKeys { get; }

        // -(BOOL)qmui_hasBindingKey:(NSString * _Nonnull)key;
        [Export("qmui_hasBindingKey:")]
        bool Qmui_hasBindingKey(string key);
    }

    // @interface QMUI_Debug (NSObject)
    [Category]
    [BaseType(typeof(NSObject))]
    interface NSObject_QMUI_Debug
    {
        // -(NSString * _Nonnull)qmui_methodList;
        [Export("qmui_methodList")]
        [Verify(MethodToProperty)]
        string Qmui_methodList { get; }

        // -(NSString * _Nonnull)qmui_shortMethodList;
        [Export("qmui_shortMethodList")]
        [Verify(MethodToProperty)]
        string Qmui_shortMethodList { get; }

        // -(NSString * _Nonnull)qmui_ivarList;
        [Export("qmui_ivarList")]
        [Verify(MethodToProperty)]
        string Qmui_ivarList { get; }
    }

    // @interface QMUI_KVC (NSThread)
    [Category]
    [BaseType(typeof(NSThread))]
    interface NSThread_QMUI_KVC
    {
        // @property (assign, nonatomic) BOOL qmui_shouldIgnoreUIKVCAccessProhibited;
        [Export("qmui_shouldIgnoreUIKVCAccessProhibited")]
        bool Qmui_shouldIgnoreUIKVCAccessProhibited { get; set; }
    }

    // @interface QMUIMultipleDelegates (NSObject)
    [Category]
    [BaseType(typeof(NSObject))]
    interface NSObject_QMUIMultipleDelegates
    {
        // @property (assign, nonatomic) BOOL qmui_multipleDelegatesEnabled;
        [Export("qmui_multipleDelegatesEnabled")]
        bool Qmui_multipleDelegatesEnabled { get; set; }

        // -(void)qmui_registerDelegateSelector:(SEL)getter;
        [Export("qmui_registerDelegateSelector:")]
        void Qmui_registerDelegateSelector(Selector getter);

        // -(void)qmui_removeDelegate:(id)delegate;
        [Export("qmui_removeDelegate:")]
        void Qmui_removeDelegate(NSObject @delegate);
    }

    // @interface QMUI (NSMutableParagraphStyle)
    [Category]
    [BaseType(typeof(NSMutableParagraphStyle))]
    interface NSMutableParagraphStyle_QMUI
    {
        // +(instancetype)qmui_paragraphStyleWithLineHeight:(CGFloat)lineHeight;
        [Static]
        [Export("qmui_paragraphStyleWithLineHeight:")]
        NSMutableParagraphStyle Qmui_paragraphStyleWithLineHeight(nfloat lineHeight);

        // +(instancetype)qmui_paragraphStyleWithLineHeight:(CGFloat)lineHeight lineBreakMode:(NSLineBreakMode)lineBreakMode;
        [Static]
        [Export("qmui_paragraphStyleWithLineHeight:lineBreakMode:")]
        NSMutableParagraphStyle Qmui_paragraphStyleWithLineHeight(nfloat lineHeight, NSLineBreakMode lineBreakMode);

        // +(instancetype)qmui_paragraphStyleWithLineHeight:(CGFloat)lineHeight lineBreakMode:(NSLineBreakMode)lineBreakMode textAlignment:(NSTextAlignment)textAlignment;
        [Static]
        [Export("qmui_paragraphStyleWithLineHeight:lineBreakMode:textAlignment:")]
        NSMutableParagraphStyle Qmui_paragraphStyleWithLineHeight(nfloat lineHeight, NSLineBreakMode lineBreakMode, NSTextAlignment textAlignment);
    }

    // @interface QMUI (NSPointerArray)
    [Category]
    [BaseType(typeof(NSPointerArray))]
    interface NSPointerArray_QMUI
    {
        // -(NSUInteger)qmui_indexOfPointer:(void * _Nullable)pointer;
        [Export("qmui_indexOfPointer:")]
        unsafe nuint Qmui_indexOfPointer([NullAllowed] void* pointer);

        // -(BOOL)qmui_containsPointer:(void * _Nullable)pointer;
        [Export("qmui_containsPointer:")]
        unsafe bool Qmui_containsPointer([NullAllowed] void* pointer);
    }

    // @interface QMUI (NSString)
    [Category]
    [BaseType(typeof(NSString))]
    interface NSString_QMUI
    {
        // @property (readonly, copy) NSArray<NSString *> * _Nullable qmui_toArray;
        [NullAllowed, Export("qmui_toArray", ArgumentSemantic.Copy)]
        string[] Qmui_toArray { get; }

        // @property (readonly, copy) NSArray<NSString *> * _Nullable qmui_toTrimmedArray;
        [NullAllowed, Export("qmui_toTrimmedArray", ArgumentSemantic.Copy)]
        string[] Qmui_toTrimmedArray { get; }

        // @property (readonly, copy) NSString * _Nonnull qmui_trim;
        [Export("qmui_trim")]
        string Qmui_trim { get; }

        // @property (readonly, copy) NSString * _Nonnull qmui_trimAllWhiteSpace;
        [Export("qmui_trimAllWhiteSpace")]
        string Qmui_trimAllWhiteSpace { get; }

        // @property (readonly, copy) NSString * _Nonnull qmui_trimLineBreakCharacter;
        [Export("qmui_trimLineBreakCharacter")]
        string Qmui_trimLineBreakCharacter { get; }

        // @property (readonly, copy) NSString * _Nonnull qmui_md5;
        [Export("qmui_md5")]
        string Qmui_md5 { get; }

        // @property (readonly, copy) NSString * _Nullable qmui_stringByEncodingUserInputQuery;
        [NullAllowed, Export("qmui_stringByEncodingUserInputQuery")]
        string Qmui_stringByEncodingUserInputQuery { get; }

        // @property (readonly, copy) NSString * _Nullable qmui_capitalizedString;
        [NullAllowed, Export("qmui_capitalizedString")]
        string Qmui_capitalizedString { get; }

        // @property (readonly, copy) NSString * _Nullable qmui_removeMagicalChar;
        [NullAllowed, Export("qmui_removeMagicalChar")]
        string Qmui_removeMagicalChar { get; }

        // @property (readonly) NSUInteger qmui_lengthWhenCountingNonASCIICharacterAsTwo;
        [Export("qmui_lengthWhenCountingNonASCIICharacterAsTwo")]
        nuint Qmui_lengthWhenCountingNonASCIICharacterAsTwo { get; }

        // -(NSString * _Nonnull)qmui_substringAvoidBreakingUpCharacterSequencesFromIndex:(NSUInteger)index lessValue:(BOOL)lessValue countingNonASCIICharacterAsTwo:(BOOL)countingNonASCIICharacterAsTwo;
        [Export("qmui_substringAvoidBreakingUpCharacterSequencesFromIndex:lessValue:countingNonASCIICharacterAsTwo:")]
        string Qmui_substringAvoidBreakingUpCharacterSequencesFromIndex(nuint index, bool lessValue, bool countingNonASCIICharacterAsTwo);

        // -(NSString * _Nonnull)qmui_substringAvoidBreakingUpCharacterSequencesFromIndex:(NSUInteger)index;
        [Export("qmui_substringAvoidBreakingUpCharacterSequencesFromIndex:")]
        string Qmui_substringAvoidBreakingUpCharacterSequencesFromIndex(nuint index);

        // -(NSString * _Nonnull)qmui_substringAvoidBreakingUpCharacterSequencesToIndex:(NSUInteger)index lessValue:(BOOL)lessValue countingNonASCIICharacterAsTwo:(BOOL)countingNonASCIICharacterAsTwo;
        [Export("qmui_substringAvoidBreakingUpCharacterSequencesToIndex:lessValue:countingNonASCIICharacterAsTwo:")]
        string Qmui_substringAvoidBreakingUpCharacterSequencesToIndex(nuint index, bool lessValue, bool countingNonASCIICharacterAsTwo);

        // -(NSString * _Nonnull)qmui_substringAvoidBreakingUpCharacterSequencesToIndex:(NSUInteger)index;
        [Export("qmui_substringAvoidBreakingUpCharacterSequencesToIndex:")]
        string Qmui_substringAvoidBreakingUpCharacterSequencesToIndex(nuint index);

        // -(NSString * _Nonnull)qmui_substringAvoidBreakingUpCharacterSequencesWithRange:(NSRange)range lessValue:(BOOL)lessValue countingNonASCIICharacterAsTwo:(BOOL)countingNonASCIICharacterAsTwo;
        [Export("qmui_substringAvoidBreakingUpCharacterSequencesWithRange:lessValue:countingNonASCIICharacterAsTwo:")]
        string Qmui_substringAvoidBreakingUpCharacterSequencesWithRange(NSRange range, bool lessValue, bool countingNonASCIICharacterAsTwo);

        // -(NSString * _Nonnull)qmui_substringAvoidBreakingUpCharacterSequencesWithRange:(NSRange)range;
        [Export("qmui_substringAvoidBreakingUpCharacterSequencesWithRange:")]
        string Qmui_substringAvoidBreakingUpCharacterSequencesWithRange(NSRange range);

        // -(NSString * _Nonnull)qmui_stringByRemoveCharacterAtIndex:(NSUInteger)index;
        [Export("qmui_stringByRemoveCharacterAtIndex:")]
        string Qmui_stringByRemoveCharacterAtIndex(nuint index);

        // -(NSString * _Nonnull)qmui_stringByRemoveLastCharacter;
        [Export("qmui_stringByRemoveLastCharacter")]
        [Verify(MethodToProperty)]
        string Qmui_stringByRemoveLastCharacter { get; }

        // -(NSString * _Nonnull)qmui_stringMatchedByPattern:(NSString * _Nonnull)pattern;
        [Export("qmui_stringMatchedByPattern:")]
        string Qmui_stringMatchedByPattern(string pattern);

        // -(NSString * _Nonnull)qmui_stringByReplacingPattern:(NSString * _Nonnull)pattern withString:(NSString * _Nonnull)replacement;
        [Export("qmui_stringByReplacingPattern:withString:")]
        string Qmui_stringByReplacingPattern(string pattern, string replacement);

        // +(NSString * _Nonnull)qmui_hexStringWithInteger:(NSInteger)integer;
        [Static]
        [Export("qmui_hexStringWithInteger:")]
        string Qmui_hexStringWithInteger(nint integer);

        // +(NSString * _Nonnull)qmui_stringByConcat:(id _Nonnull)firstArgv, ...;
        [Static, Internal]
        [Export("qmui_stringByConcat:", IsVariadic = true)]
        string Qmui_stringByConcat(NSObject firstArgv, IntPtr varArgs);

        // +(NSString * _Nonnull)qmui_timeStringWithMinsAndSecsFromSecs:(double)seconds;
        [Static]
        [Export("qmui_timeStringWithMinsAndSecsFromSecs:")]
        string Qmui_timeStringWithMinsAndSecsFromSecs(double seconds);
    }

    // @interface QMUI_StringFormat (NSString)
    [Category]
    [BaseType(typeof(NSString))]
    interface NSString_QMUI_StringFormat
    {
        // +(instancetype _Nonnull)qmui_stringWithNSInteger:(NSInteger)integerValue;
        [Static]
        [Export("qmui_stringWithNSInteger:")]
        NSString Qmui_stringWithNSInteger(nint integerValue);

        // +(instancetype _Nonnull)qmui_stringWithCGFloat:(CGFloat)floatValue;
        [Static]
        [Export("qmui_stringWithCGFloat:")]
        NSString Qmui_stringWithCGFloat(nfloat floatValue);

        // +(instancetype _Nonnull)qmui_stringWithCGFloat:(CGFloat)floatValue decimal:(NSUInteger)decimal;
        [Static]
        [Export("qmui_stringWithCGFloat:decimal:")]
        NSString Qmui_stringWithCGFloat(nfloat floatValue, nuint @decimal);
    }

    // @interface QMUI (NSURL)
    [Category]
    [BaseType(typeof(NSUrl))]
    interface NSURL_QMUI
    {
        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * qmui_queryItems;
        [Export("qmui_queryItems", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> Qmui_queryItems { get; }
    }

    // @interface QMUINavigationController : UINavigationController
    [BaseType(typeof(UINavigationController))]
    interface QMUINavigationController
    {
        // -(void)didInitialize __attribute__((deprecated("使用 qmui_didInitialize 代替")));
        [Export("didInitialize")]
        void DidInitialize();
    }

    // @interface UISubclassingHooks (QMUINavigationController)
    [Category]
    [BaseType(typeof(QMUINavigationController))]
    interface QMUINavigationController_UISubclassingHooks
    {
        // -(void)willShowViewController:(UIViewController * _Nonnull)viewController animated:(BOOL)animated __attribute__((objc_requires_super));
        [Export("willShowViewController:animated:")]
        [RequiresSuper]
        void WillShowViewController(UIViewController viewController, bool animated);

        // -(void)didShowViewController:(UIViewController * _Nonnull)viewController animated:(BOOL)animated __attribute__((objc_requires_super));
        [Export("didShowViewController:animated:")]
        [RequiresSuper]
        void DidShowViewController(UIViewController viewController, bool animated);
    }

    // @protocol QMUINavigationControllerTransitionDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUINavigationControllerTransitionDelegate
    {
        // @optional -(void)navigationController:(QMUINavigationController * _Nonnull)navigationController poppingByInteractiveGestureRecognizer:(UIScreenEdgePanGestureRecognizer * _Nullable)gestureRecognizer viewControllerWillDisappear:(UIViewController * _Nullable)viewControllerWillDisappear viewControllerWillAppear:(UIViewController * _Nullable)viewControllerWillAppear;
        [Export("navigationController:poppingByInteractiveGestureRecognizer:viewControllerWillDisappear:viewControllerWillAppear:")]
        void NavigationController(QMUINavigationController navigationController, [NullAllowed] UIScreenEdgePanGestureRecognizer gestureRecognizer, [NullAllowed] UIViewController viewControllerWillDisappear, [NullAllowed] UIViewController viewControllerWillAppear);

        // @optional -(void)willPopInNavigationControllerWithAnimated:(BOOL)animated;
        [Export("willPopInNavigationControllerWithAnimated:")]
        void WillPopInNavigationControllerWithAnimated(bool animated);

        // @optional -(void)didPopInNavigationControllerWithAnimated:(BOOL)animated;
        [Export("didPopInNavigationControllerWithAnimated:")]
        void DidPopInNavigationControllerWithAnimated(bool animated);

        // @optional -(void)viewControllerKeepingAppearWhenSetViewControllersWithAnimated:(BOOL)animated;
        [Export("viewControllerKeepingAppearWhenSetViewControllersWithAnimated:")]
        void ViewControllerKeepingAppearWhenSetViewControllersWithAnimated(bool animated);
    }

    // @protocol QMUINavigationControllerAppearanceDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUINavigationControllerAppearanceDelegate
    {
        // @optional -(UIColor * _Nullable)titleViewTintColor;
        [NullAllowed, Export("titleViewTintColor")]
        [Verify(MethodToProperty)]
        UIColor TitleViewTintColor { get; }

        // @optional -(UIImage * _Nullable)navigationBarBackgroundImage;
        [NullAllowed, Export("navigationBarBackgroundImage")]
        [Verify(MethodToProperty)]
        UIImage NavigationBarBackgroundImage { get; }

        // @optional -(UIImage * _Nullable)navigationBarShadowImage;
        [NullAllowed, Export("navigationBarShadowImage")]
        [Verify(MethodToProperty)]
        UIImage NavigationBarShadowImage { get; }

        // @optional -(UIColor * _Nullable)navigationBarBarTintColor;
        [NullAllowed, Export("navigationBarBarTintColor")]
        [Verify(MethodToProperty)]
        UIColor NavigationBarBarTintColor { get; }

        // @optional -(UIBarStyle)navigationBarStyle;
        [Export("navigationBarStyle")]
        [Verify(MethodToProperty)]
        UIBarStyle NavigationBarStyle { get; }

        // @optional -(UIColor * _Nullable)navigationBarTintColor;
        [NullAllowed, Export("navigationBarTintColor")]
        [Verify(MethodToProperty)]
        UIColor NavigationBarTintColor { get; }

        // @optional -(NSString * _Nullable)backBarButtonItemTitleWithPreviousViewController:(UIViewController * _Nullable)viewController;
        [Export("backBarButtonItemTitleWithPreviousViewController:")]
        [return: NullAllowed]
        string BackBarButtonItemTitleWithPreviousViewController([NullAllowed] UIViewController viewController);
    }

    // @protocol QMUICustomNavigationBarTransitionDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUICustomNavigationBarTransitionDelegate
    {
        // @optional -(BOOL)preferredNavigationBarHidden;
        [Export("preferredNavigationBarHidden")]
        [Verify(MethodToProperty)]
        bool PreferredNavigationBarHidden { get; }

        // @optional -(BOOL)shouldCustomizeNavigationBarTransitionIfHideable;
        [Export("shouldCustomizeNavigationBarTransitionIfHideable")]
        [Verify(MethodToProperty)]
        bool ShouldCustomizeNavigationBarTransitionIfHideable { get; }

        // @optional -(NSString * _Nullable)customNavigationBarTransitionKey;
        [NullAllowed, Export("customNavigationBarTransitionKey")]
        [Verify(MethodToProperty)]
        string CustomNavigationBarTransitionKey { get; }

        // @optional -(BOOL)shouldCustomizeNavigationBarTransitionIfUsingCustomTransitionForOperation:(UINavigationControllerOperation)operation fromViewController:(UIViewController * _Nullable)fromVC toViewController:(UIViewController * _Nullable)toVc;
        [Export("shouldCustomizeNavigationBarTransitionIfUsingCustomTransitionForOperation:fromViewController:toViewController:")]
        bool FromViewController(UINavigationControllerOperation operation, [NullAllowed] UIViewController fromVC, [NullAllowed] UIViewController toVc);

        // @optional -(UIColor * _Nullable)containerViewBackgroundColorWhenTransitioning;
        [NullAllowed, Export("containerViewBackgroundColorWhenTransitioning")]
        [Verify(MethodToProperty)]
        UIColor ContainerViewBackgroundColorWhenTransitioning { get; }
    }

    // @protocol QMUINavigationControllerDelegate <UINavigationControllerDelegate, QMUINavigationControllerTransitionDelegate, QMUINavigationControllerAppearanceDelegate, QMUICustomNavigationBarTransitionDelegate>
    [Protocol, Model]
    interface QMUINavigationControllerDelegate : IUINavigationControllerDelegate, IQMUINavigationControllerTransitionDelegate, IQMUINavigationControllerAppearanceDelegate, IQMUICustomNavigationBarTransitionDelegate
    {
    }

    // @interface QMUIKeyboardManager : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIKeyboardManager
    {
        // -(instancetype)initWithDelegate:(id<QMUIKeyboardManagerDelegate>)delegate __attribute__((objc_designated_initializer));
        [Export("initWithDelegate:")]
        [DesignatedInitializer]
        IntPtr Constructor(QMUIKeyboardManagerDelegate @delegate);

        [Wrap("WeakDelegate")]
        QMUIKeyboardManagerDelegate Delegate { get; }

        // @property (readonly, nonatomic, weak) id<QMUIKeyboardManagerDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; }

        // @property (assign, nonatomic) BOOL delegateEnabled;
        [Export("delegateEnabled")]
        bool DelegateEnabled { get; set; }

        // @property (assign, nonatomic) BOOL ignoreApplicationState __attribute__((annotate("ui_appearance_selector")));
        [Export("ignoreApplicationState")]
        bool IgnoreApplicationState { get; set; }

        // +(instancetype)appearance;
        [Static]
        [Export("appearance")]
        QMUIKeyboardManager Appearance();

        // -(BOOL)addTargetResponder:(UIResponder *)targetResponder;
        [Export("addTargetResponder:")]
        bool AddTargetResponder(UIResponder targetResponder);

        // -(NSArray<UIResponder *> *)allTargetResponders;
        [Export("allTargetResponders")]
        [Verify(MethodToProperty)]
        UIResponder[] AllTargetResponders { get; }

        // -(BOOL)removeTargetResponder:(UIResponder *)targetResponder;
        [Export("removeTargetResponder:")]
        bool RemoveTargetResponder(UIResponder targetResponder);

        // +(CGRect)convertKeyboardRect:(CGRect)rect toView:(UIView *)view;
        [Static]
        [Export("convertKeyboardRect:toView:")]
        CGRect ConvertKeyboardRect(CGRect rect, UIView view);

        // +(CGFloat)distanceFromMinYToBottomInView:(UIView *)view keyboardRect:(CGRect)rect;
        [Static]
        [Export("distanceFromMinYToBottomInView:keyboardRect:")]
        nfloat DistanceFromMinYToBottomInView(UIView view, CGRect rect);

        // +(void)animateWithAnimated:(BOOL)animated keyboardUserInfo:(QMUIKeyboardUserInfo *)keyboardUserInfo animations:(void (^)(void))animations completion:(void (^)(BOOL))completion;
        [Static]
        [Export("animateWithAnimated:keyboardUserInfo:animations:completion:")]
        void AnimateWithAnimated(bool animated, QMUIKeyboardUserInfo keyboardUserInfo, Action animations, Action<bool> completion);

        // +(void)handleKeyboardNotificationWithUserInfo:(QMUIKeyboardUserInfo *)keyboardUserInfo showBlock:(void (^)(QMUIKeyboardUserInfo *))showBlock hideBlock:(void (^)(QMUIKeyboardUserInfo *))hideBlock;
        [Static]
        [Export("handleKeyboardNotificationWithUserInfo:showBlock:hideBlock:")]
        void HandleKeyboardNotificationWithUserInfo(QMUIKeyboardUserInfo keyboardUserInfo, Action<QMUIKeyboardUserInfo> showBlock, Action<QMUIKeyboardUserInfo> hideBlock);

        // +(UIView *)keyboardView;
        [Static]
        [Export("keyboardView")]
        [Verify(MethodToProperty)]
        UIView KeyboardView { get; }

        // +(UIWindow *)keyboardWindow;
        [Static]
        [Export("keyboardWindow")]
        [Verify(MethodToProperty)]
        UIWindow KeyboardWindow { get; }

        // +(BOOL)isKeyboardVisible;
        [Static]
        [Export("isKeyboardVisible")]
        [Verify(MethodToProperty)]
        bool IsKeyboardVisible { get; }

        // +(CGRect)currentKeyboardFrame;
        [Static]
        [Export("currentKeyboardFrame")]
        [Verify(MethodToProperty)]
        CGRect CurrentKeyboardFrame { get; }

        // +(CGFloat)visibleKeyboardHeight;
        [Static]
        [Export("visibleKeyboardHeight")]
        [Verify(MethodToProperty)]
        nfloat VisibleKeyboardHeight { get; }
    }

    // @interface QMUIKeyboardUserInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIKeyboardUserInfo
    {
        // @property (readonly, nonatomic, weak) QMUIKeyboardManager * keyboardManager;
        [Export("keyboardManager", ArgumentSemantic.Weak)]
        QMUIKeyboardManager KeyboardManager { get; }

        // @property (readonly, nonatomic, strong) NSNotification * notification;
        [Export("notification", ArgumentSemantic.Strong)]
        NSNotification Notification { get; }

        // @property (readonly, nonatomic, strong) NSDictionary * originUserInfo;
        [Export("originUserInfo", ArgumentSemantic.Strong)]
        NSDictionary OriginUserInfo { get; }

        // @property (readonly, nonatomic, weak) UIResponder * targetResponder;
        [Export("targetResponder", ArgumentSemantic.Weak)]
        UIResponder TargetResponder { get; }

        // @property (readonly, assign, nonatomic) CGFloat width;
        [Export("width")]
        nfloat Width { get; }

        // @property (readonly, assign, nonatomic) CGFloat height;
        [Export("height")]
        nfloat Height { get; }

        // -(CGFloat)heightInView:(UIView *)view;
        [Export("heightInView:")]
        nfloat HeightInView(UIView view);

        // @property (readonly, assign, nonatomic) CGRect beginFrame;
        [Export("beginFrame", ArgumentSemantic.Assign)]
        CGRect BeginFrame { get; }

        // @property (readonly, assign, nonatomic) CGRect endFrame;
        [Export("endFrame", ArgumentSemantic.Assign)]
        CGRect EndFrame { get; }

        // @property (readonly, assign, nonatomic) NSTimeInterval animationDuration;
        [Export("animationDuration")]
        double AnimationDuration { get; }

        // @property (readonly, assign, nonatomic) UIViewAnimationCurve animationCurve;
        [Export("animationCurve", ArgumentSemantic.Assign)]
        UIViewAnimationCurve AnimationCurve { get; }

        // @property (readonly, assign, nonatomic) UIViewAnimationOptions animationOptions;
        [Export("animationOptions", ArgumentSemantic.Assign)]
        UIViewAnimationOptions AnimationOptions { get; }
    }

    // @protocol QMUIKeyboardManagerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIKeyboardManagerDelegate
    {
        // @optional -(void)keyboardWillShowWithUserInfo:(QMUIKeyboardUserInfo *)keyboardUserInfo;
        [Export("keyboardWillShowWithUserInfo:")]
        void KeyboardWillShowWithUserInfo(QMUIKeyboardUserInfo keyboardUserInfo);

        // @optional -(void)keyboardWillHideWithUserInfo:(QMUIKeyboardUserInfo *)keyboardUserInfo;
        [Export("keyboardWillHideWithUserInfo:")]
        void KeyboardWillHideWithUserInfo(QMUIKeyboardUserInfo keyboardUserInfo);

        // @optional -(void)keyboardWillChangeFrameWithUserInfo:(QMUIKeyboardUserInfo *)keyboardUserInfo;
        [Export("keyboardWillChangeFrameWithUserInfo:")]
        void KeyboardWillChangeFrameWithUserInfo(QMUIKeyboardUserInfo keyboardUserInfo);

        // @optional -(void)keyboardDidShowWithUserInfo:(QMUIKeyboardUserInfo *)keyboardUserInfo;
        [Export("keyboardDidShowWithUserInfo:")]
        void KeyboardDidShowWithUserInfo(QMUIKeyboardUserInfo keyboardUserInfo);

        // @optional -(void)keyboardDidHideWithUserInfo:(QMUIKeyboardUserInfo *)keyboardUserInfo;
        [Export("keyboardDidHideWithUserInfo:")]
        void KeyboardDidHideWithUserInfo(QMUIKeyboardUserInfo keyboardUserInfo);

        // @optional -(void)keyboardDidChangeFrameWithUserInfo:(QMUIKeyboardUserInfo *)keyboardUserInfo;
        [Export("keyboardDidChangeFrameWithUserInfo:")]
        void KeyboardDidChangeFrameWithUserInfo(QMUIKeyboardUserInfo keyboardUserInfo);
    }

    // @interface KeyboardManager (UIResponder)
    [Category]
    [BaseType(typeof(UIResponder))]
    interface UIResponder_KeyboardManager
    {
        // @property (nonatomic, strong) QMUIKeyboardManager * qmui_keyboardManager;
        [Export("qmui_keyboardManager", ArgumentSemantic.Strong)]
        QMUIKeyboardManager Qmui_keyboardManager { get; set; }
    }

    // @interface QMUI_KeyboardManager (UITextField)
    [Category]
    [BaseType(typeof(UITextField))]
    interface UITextField_QMUI_KeyboardManager
    {
        // @property (copy, nonatomic) void (^qmui_keyboardWillShowNotificationBlock)(QMUIKeyboardUserInfo *);
        [Export("qmui_keyboardWillShowNotificationBlock", ArgumentSemantic.Copy)]
        Action<QMUIKeyboardUserInfo> Qmui_keyboardWillShowNotificationBlock { get; set; }

        // @property (copy, nonatomic) void (^qmui_keyboardWillHideNotificationBlock)(QMUIKeyboardUserInfo *);
        [Export("qmui_keyboardWillHideNotificationBlock", ArgumentSemantic.Copy)]
        Action<QMUIKeyboardUserInfo> Qmui_keyboardWillHideNotificationBlock { get; set; }

        // @property (copy, nonatomic) void (^qmui_keyboardWillChangeFrameNotificationBlock)(QMUIKeyboardUserInfo *);
        [Export("qmui_keyboardWillChangeFrameNotificationBlock", ArgumentSemantic.Copy)]
        Action<QMUIKeyboardUserInfo> Qmui_keyboardWillChangeFrameNotificationBlock { get; set; }

        // @property (copy, nonatomic) void (^qmui_keyboardDidShowNotificationBlock)(QMUIKeyboardUserInfo *);
        [Export("qmui_keyboardDidShowNotificationBlock", ArgumentSemantic.Copy)]
        Action<QMUIKeyboardUserInfo> Qmui_keyboardDidShowNotificationBlock { get; set; }

        // @property (copy, nonatomic) void (^qmui_keyboardDidHideNotificationBlock)(QMUIKeyboardUserInfo *);
        [Export("qmui_keyboardDidHideNotificationBlock", ArgumentSemantic.Copy)]
        Action<QMUIKeyboardUserInfo> Qmui_keyboardDidHideNotificationBlock { get; set; }

        // @property (copy, nonatomic) void (^qmui_keyboardDidChangeFrameNotificationBlock)(QMUIKeyboardUserInfo *);
        [Export("qmui_keyboardDidChangeFrameNotificationBlock", ArgumentSemantic.Copy)]
        Action<QMUIKeyboardUserInfo> Qmui_keyboardDidChangeFrameNotificationBlock { get; set; }
    }

    // @interface QMUI_KeyboardManager (UITextView)
    [Category]
    [BaseType(typeof(UITextView))]
    interface UITextView_QMUI_KeyboardManager
    {
        // @property (copy, nonatomic) void (^qmui_keyboardWillShowNotificationBlock)(QMUIKeyboardUserInfo *);
        [Export("qmui_keyboardWillShowNotificationBlock", ArgumentSemantic.Copy)]
        Action<QMUIKeyboardUserInfo> Qmui_keyboardWillShowNotificationBlock { get; set; }

        // @property (copy, nonatomic) void (^qmui_keyboardWillHideNotificationBlock)(QMUIKeyboardUserInfo *);
        [Export("qmui_keyboardWillHideNotificationBlock", ArgumentSemantic.Copy)]
        Action<QMUIKeyboardUserInfo> Qmui_keyboardWillHideNotificationBlock { get; set; }

        // @property (copy, nonatomic) void (^qmui_keyboardWillChangeFrameNotificationBlock)(QMUIKeyboardUserInfo *);
        [Export("qmui_keyboardWillChangeFrameNotificationBlock", ArgumentSemantic.Copy)]
        Action<QMUIKeyboardUserInfo> Qmui_keyboardWillChangeFrameNotificationBlock { get; set; }

        // @property (copy, nonatomic) void (^qmui_keyboardDidShowNotificationBlock)(QMUIKeyboardUserInfo *);
        [Export("qmui_keyboardDidShowNotificationBlock", ArgumentSemantic.Copy)]
        Action<QMUIKeyboardUserInfo> Qmui_keyboardDidShowNotificationBlock { get; set; }

        // @property (copy, nonatomic) void (^qmui_keyboardDidHideNotificationBlock)(QMUIKeyboardUserInfo *);
        [Export("qmui_keyboardDidHideNotificationBlock", ArgumentSemantic.Copy)]
        Action<QMUIKeyboardUserInfo> Qmui_keyboardDidHideNotificationBlock { get; set; }

        // @property (copy, nonatomic) void (^qmui_keyboardDidChangeFrameNotificationBlock)(QMUIKeyboardUserInfo *);
        [Export("qmui_keyboardDidChangeFrameNotificationBlock", ArgumentSemantic.Copy)]
        Action<QMUIKeyboardUserInfo> Qmui_keyboardDidChangeFrameNotificationBlock { get; set; }
    }

    // @interface QMUICommonViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface QMUICommonViewController
    {
        // -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
        [Export("initWithNibName:bundle:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(void)didInitialize __attribute__((objc_requires_super));
        [Export("didInitialize")]
        [RequiresSuper]
        void DidInitialize();

        // @property (readonly, nonatomic, strong) QMUINavigationTitleView * _Nullable titleView;
        [NullAllowed, Export("titleView", ArgumentSemantic.Strong)]
        QMUINavigationTitleView TitleView { get; }

        // @property (assign, nonatomic) UIInterfaceOrientationMask supportedOrientationMask;
        [Export("supportedOrientationMask", ArgumentSemantic.Assign)]
        UIInterfaceOrientationMask SupportedOrientationMask { get; set; }

        // @property (nonatomic, strong) QMUIEmptyView * _Nullable emptyView;
        [NullAllowed, Export("emptyView", ArgumentSemantic.Strong)]
        QMUIEmptyView EmptyView { get; set; }

        // @property (readonly, getter = isEmptyViewShowing, assign, nonatomic) BOOL emptyViewShowing;
        [Export("emptyViewShowing")]
        bool EmptyViewShowing { [Bind("isEmptyViewShowing")] get; }

        // -(void)showEmptyView;
        [Export("showEmptyView")]
        void ShowEmptyView();

        // -(void)showEmptyViewWithLoading;
        [Export("showEmptyViewWithLoading")]
        void ShowEmptyViewWithLoading();

        // -(void)showEmptyViewWithText:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText buttonTitle:(NSString * _Nullable)buttonTitle buttonAction:(SEL _Nullable)action;
        [Export("showEmptyViewWithText:detailText:buttonTitle:buttonAction:")]
        void ShowEmptyViewWithText([NullAllowed] string text, [NullAllowed] string detailText, [NullAllowed] string buttonTitle, [NullAllowed] Selector action);

        // -(void)showEmptyViewWithImage:(UIImage * _Nullable)image text:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText buttonTitle:(NSString * _Nullable)buttonTitle buttonAction:(SEL _Nullable)action;
        [Export("showEmptyViewWithImage:text:detailText:buttonTitle:buttonAction:")]
        void ShowEmptyViewWithImage([NullAllowed] UIImage image, [NullAllowed] string text, [NullAllowed] string detailText, [NullAllowed] string buttonTitle, [NullAllowed] Selector action);

        // -(void)showEmptyViewWithLoading:(BOOL)showLoading image:(UIImage * _Nullable)image text:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText buttonTitle:(NSString * _Nullable)buttonTitle buttonAction:(SEL _Nullable)action;
        [Export("showEmptyViewWithLoading:image:text:detailText:buttonTitle:buttonAction:")]
        void ShowEmptyViewWithLoading(bool showLoading, [NullAllowed] UIImage image, [NullAllowed] string text, [NullAllowed] string detailText, [NullAllowed] string buttonTitle, [NullAllowed] Selector action);

        // -(void)hideEmptyView;
        [Export("hideEmptyView")]
        void HideEmptyView();

        // -(BOOL)layoutEmptyView;
        [Export("layoutEmptyView")]
        [Verify(MethodToProperty)]
        bool LayoutEmptyView { get; }
    }

    // @interface QMUISubclassingHooks (QMUICommonViewController)
    [Category]
    [BaseType(typeof(QMUICommonViewController))]
    interface QMUICommonViewController_QMUISubclassingHooks
    {
        // -(void)initSubviews __attribute__((objc_requires_super));
        [Export("initSubviews")]
        [RequiresSuper]
        void InitSubviews();

        // -(void)setupNavigationItems __attribute__((objc_requires_super));
        [Export("setupNavigationItems")]
        [RequiresSuper]
        void SetupNavigationItems();

        // -(void)setupToolbarItems __attribute__((objc_requires_super));
        [Export("setupToolbarItems")]
        [RequiresSuper]
        void SetupToolbarItems();

        // -(void)contentSizeCategoryDidChanged:(NSNotification * _Nonnull)notification;
        [Export("contentSizeCategoryDidChanged:")]
        void ContentSizeCategoryDidChanged(NSNotification notification);
    }

    // @interface QMUINavigationController (QMUICommonViewController) <QMUINavigationControllerDelegate>
    [Category]
    [BaseType(typeof(QMUICommonViewController))]
    interface QMUICommonViewController_QMUINavigationController : IQMUINavigationControllerDelegate
    {
        // -(void)updateNavigationBarAppearance;
        [Export("updateNavigationBarAppearance")]
        void UpdateNavigationBarAppearance();
    }

    // @interface QMUIKeyboard (QMUICommonViewController)
    [Category]
    [BaseType(typeof(QMUICommonViewController))]
    interface QMUICommonViewController_QMUIKeyboard
    {
        // @property (readonly, nonatomic, strong) UITapGestureRecognizer * _Nullable hideKeyboardTapGestureRecognizer;
        [NullAllowed, Export("hideKeyboardTapGestureRecognizer", ArgumentSemantic.Strong)]
        UITapGestureRecognizer HideKeyboardTapGestureRecognizer { get; }

        // @property (readonly, nonatomic, strong) QMUIKeyboardManager * _Nullable hideKeyboardManager;
        [NullAllowed, Export("hideKeyboardManager", ArgumentSemantic.Strong)]
        QMUIKeyboardManager HideKeyboardManager { get; }

        // -(BOOL)shouldHideKeyboardWhenTouchInView:(UIView * _Nullable)view;
        [Export("shouldHideKeyboardWhenTouchInView:")]
        bool ShouldHideKeyboardWhenTouchInView([NullAllowed] UIView view);
    }

    // @protocol QMUICellHeightCache_UITableViewDataSource
    [Protocol, Model]
    interface QMUICellHeightCache_UITableViewDataSource
    {
        // @optional -(__kindof UITableViewCell * _Nullable)qmui_tableView:(UITableView * _Nullable)tableView cellWithIdentifier:(NSString * _Nonnull)identifier;
        [Export("qmui_tableView:cellWithIdentifier:")]
        UITableViewCell CellWithIdentifier([NullAllowed] UITableView tableView, string identifier);
    }

    // @protocol QMUICellHeightKeyCache_UITableViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUICellHeightKeyCache_UITableViewDelegate
    {
        // @optional -(id<NSCopying> _Nonnull)qmui_tableView:(UITableView * _Nonnull)tableView cacheKeyForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("qmui_tableView:cacheKeyForRowAtIndexPath:")]
        NSCopying CacheKeyForRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);
    }

    // @protocol QMUITableViewDelegate <UITableViewDelegate, QMUICellHeightKeyCache_UITableViewDelegate>
    [Protocol, Model]
    interface QMUITableViewDelegate : IUITableViewDelegate, IQMUICellHeightKeyCache_UITableViewDelegate
    {
        // @optional -(BOOL)tableView:(QMUITableView * _Nonnull)tableView touchesShouldCancelInContentView:(UIView * _Nonnull)view;
        [Export("tableView:touchesShouldCancelInContentView:")]
        bool TouchesShouldCancelInContentView(QMUITableView tableView, UIView view);
    }

    // @protocol QMUITableViewDataSource <UITableViewDataSource, QMUICellHeightCache_UITableViewDataSource>
    [Protocol, Model]
    interface QMUITableViewDataSource : IUITableViewDataSource, IQMUICellHeightCache_UITableViewDataSource
    {
    }

    // @interface QMUITableView : UITableView
    [BaseType(typeof(UITableView))]
    interface QMUITableView
    {
        [Wrap("WeakDelegate")]
        QMUITableViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<QMUITableViewDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, weak) id<QMUITableViewDataSource> dataSource;
        [Export("dataSource", ArgumentSemantic.Weak)]
        QMUITableViewDataSource DataSource { get; set; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull QMUICommonTableViewControllerSectionHeaderIdentifier;
        [Field("QMUICommonTableViewControllerSectionHeaderIdentifier", "__Internal")]
        NSString QMUICommonTableViewControllerSectionHeaderIdentifier { get; }

        // extern NSString *const _Nonnull QMUICommonTableViewControllerSectionFooterIdentifier;
        [Field("QMUICommonTableViewControllerSectionFooterIdentifier", "__Internal")]
        NSString QMUICommonTableViewControllerSectionFooterIdentifier { get; }
    }

    // @interface QMUICommonTableViewController : QMUICommonViewController <QMUITableViewDelegate, QMUITableViewDataSource>
    [BaseType(typeof(QMUICommonViewController))]
    interface QMUICommonTableViewController : IQMUITableViewDelegate, IQMUITableViewDataSource
    {
        // -(instancetype _Nonnull)initWithStyle:(UITableViewStyle)style __attribute__((objc_designated_initializer));
        [Export("initWithStyle:")]
        [DesignatedInitializer]
        IntPtr Constructor(UITableViewStyle style);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // -(void)didInitializeWithStyle:(UITableViewStyle)style __attribute__((objc_requires_super));
        [Export("didInitializeWithStyle:")]
        [RequiresSuper]
        void DidInitializeWithStyle(UITableViewStyle style);

        // @property (readonly, assign, nonatomic) UITableViewStyle style;
        [Export("style", ArgumentSemantic.Assign)]
        UITableViewStyle Style { get; }

        // @property (nonatomic, strong) __kindof QMUITableView * _Null_unspecified tableView __attribute__((iboutlet));
        [Export("tableView", ArgumentSemantic.Strong)]
        QMUITableView TableView { get; set; }

        // -(void)hideTableHeaderViewInitialIfCanWithAnimated:(BOOL)animated force:(BOOL)force;
        [Export("hideTableHeaderViewInitialIfCanWithAnimated:force:")]
        void HideTableHeaderViewInitialIfCanWithAnimated(bool animated, bool force);
    }

    // @interface QMUISubclassingHooks (QMUICommonTableViewController)
    [Category]
    [BaseType(typeof(QMUICommonTableViewController))]
    interface QMUICommonTableViewController_QMUISubclassingHooks
    {
        // -(void)initTableView;
        [Export("initTableView")]
        void InitTableView();

        // -(void)layoutTableView;
        [Export("layoutTableView")]
        void LayoutTableView();

        // -(BOOL)shouldHideTableHeaderViewInitial;
        [Export("shouldHideTableHeaderViewInitial")]
        [Verify(MethodToProperty)]
        bool ShouldHideTableHeaderViewInitial { get; }
    }

    // @interface QMUI (UITableView)
    [Category]
    [BaseType(typeof(UITableView))]
    interface UITableView_QMUI
    {
        // -(void)qmui_styledAsQMUITableView;
        [Export("qmui_styledAsQMUITableView")]
        void Qmui_styledAsQMUITableView();

        // -(NSIndexPath * _Nullable)qmui_indexPathForRowAtView:(UIView * _Nullable)view;
        [Export("qmui_indexPathForRowAtView:")]
        [return: NullAllowed]
        NSIndexPath Qmui_indexPathForRowAtView([NullAllowed] UIView view);

        // -(NSInteger)qmui_indexForSectionHeaderAtView:(UIView * _Nullable)view;
        [Export("qmui_indexForSectionHeaderAtView:")]
        nint Qmui_indexForSectionHeaderAtView([NullAllowed] UIView view);

        // @property (readonly, nonatomic) NSArray<NSNumber *> * _Nullable qmui_indexForVisibleSectionHeaders;
        [NullAllowed, Export("qmui_indexForVisibleSectionHeaders")]
        NSNumber[] Qmui_indexForVisibleSectionHeaders { get; }

        // @property (readonly, nonatomic) NSInteger qmui_indexOfPinnedSectionHeader;
        [Export("qmui_indexOfPinnedSectionHeader")]
        nint Qmui_indexOfPinnedSectionHeader { get; }

        // -(BOOL)qmui_isHeaderPinnedForSection:(NSInteger)section;
        [Export("qmui_isHeaderPinnedForSection:")]
        bool Qmui_isHeaderPinnedForSection(nint section);

        // -(BOOL)qmui_cellVisibleAtIndexPath:(NSIndexPath * _Nullable)indexPath;
        [Export("qmui_cellVisibleAtIndexPath:")]
        bool Qmui_cellVisibleAtIndexPath([NullAllowed] NSIndexPath indexPath);

        // -(QMUITableViewCellPosition)qmui_positionForRowAtIndexPath:(NSIndexPath * _Nullable)indexPath;
        [Export("qmui_positionForRowAtIndexPath:")]
        QMUITableViewCellPosition Qmui_positionForRowAtIndexPath([NullAllowed] NSIndexPath indexPath);

        // -(void)qmui_clearsSelection;
        [Export("qmui_clearsSelection")]
        void Qmui_clearsSelection();

        // -(void)qmui_scrollToRowFittingOffsetY:(CGFloat)offsetY atIndexPath:(NSIndexPath * _Nonnull)indexPath animated:(BOOL)animated;
        [Export("qmui_scrollToRowFittingOffsetY:atIndexPath:animated:")]
        void Qmui_scrollToRowFittingOffsetY(nfloat offsetY, NSIndexPath indexPath, bool animated);

        // @property (readonly, assign, nonatomic) CGFloat qmui_validContentWidth;
        [Export("qmui_validContentWidth")]
        nfloat Qmui_validContentWidth { get; }

        // @property (readonly, assign, nonatomic) CGSize qmui_realContentSize;
        [Export("qmui_realContentSize", ArgumentSemantic.Assign)]
        CGSize Qmui_realContentSize { get; }

        // -(BOOL)qmui_canScroll;
        [Export("qmui_canScroll")]
        [Verify(MethodToProperty)]
        bool Qmui_canScroll { get; }

        // -(void)qmui_performBatchUpdates:(void (^ _Nullable)(void))updates completion:(void (^ _Nullable)(BOOL))completion;
        [Export("qmui_performBatchUpdates:completion:")]
        void Qmui_performBatchUpdates([NullAllowed] Action updates, [NullAllowed] Action<bool> completion);
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const UITableViewStyle QMUITableViewStyleInsetGrouped;
        [Field("QMUITableViewStyleInsetGrouped", "__Internal")]
        UITableViewStyle QMUITableViewStyleInsetGrouped { get; }
    }

    // @interface QMUI_InsetGrouped (UITableView)
    [Category]
    [BaseType(typeof(UITableView))]
    interface UITableView_QMUI_InsetGrouped
    {
        // @property (readonly, assign, nonatomic) UITableViewStyle qmui_style;
        [Export("qmui_style", ArgumentSemantic.Assign)]
        UITableViewStyle Qmui_style { get; }

        // @property (assign, nonatomic) CGFloat qmui_insetGroupedCornerRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("qmui_insetGroupedCornerRadius")]
        nfloat Qmui_insetGroupedCornerRadius { get; set; }

        // @property (assign, nonatomic) CGFloat qmui_insetGroupedHorizontalInset __attribute__((annotate("ui_appearance_selector")));
        [Export("qmui_insetGroupedHorizontalInset")]
        nfloat Qmui_insetGroupedHorizontalInset { get; set; }
    }

    // @interface QMUITableViewCell : UITableViewCell
    [BaseType(typeof(UITableViewCell))]
    interface QMUITableViewCell
    {
        // @property (readonly, assign, nonatomic) UITableViewCellStyle style;
        [Export("style", ArgumentSemantic.Assign)]
        UITableViewCellStyle Style { get; }

        // @property (assign, nonatomic) UIEdgeInsets imageEdgeInsets;
        [Export("imageEdgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets ImageEdgeInsets { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets textLabelEdgeInsets;
        [Export("textLabelEdgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets TextLabelEdgeInsets { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets detailTextLabelEdgeInsets;
        [Export("detailTextLabelEdgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets DetailTextLabelEdgeInsets { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets accessoryEdgeInsets;
        [Export("accessoryEdgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets AccessoryEdgeInsets { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets accessoryHitTestEdgeInsets;
        [Export("accessoryHitTestEdgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets AccessoryHitTestEdgeInsets { get; set; }

        // @property (getter = isEnabled, assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { [Bind("isEnabled")] get; set; }

        // @property (nonatomic, weak) __kindof UITableView * _Nullable parentTableView;
        [Export("parentTableView", ArgumentSemantic.Weak)]
        UITableView ParentTableView { get; set; }

        // @property (readonly, assign, nonatomic) QMUITableViewCellPosition cellPosition;
        [Export("cellPosition", ArgumentSemantic.Assign)]
        QMUITableViewCellPosition CellPosition { get; }

        // -(instancetype _Nullable)initForTableView:(UITableView * _Nullable)tableView withStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nonnull)reuseIdentifier;
        [Export("initForTableView:withStyle:reuseIdentifier:")]
        IntPtr Constructor([NullAllowed] UITableView tableView, UITableViewCellStyle style, string reuseIdentifier);

        // -(instancetype _Nullable)initForTableView:(UITableView * _Nullable)tableView withReuseIdentifier:(NSString * _Nonnull)reuseIdentifier;
        [Export("initForTableView:withReuseIdentifier:")]
        IntPtr Constructor([NullAllowed] UITableView tableView, string reuseIdentifier);
    }

    // @interface QMUISubclassingHooks (QMUITableViewCell)
    [Category]
    [BaseType(typeof(QMUITableViewCell))]
    interface QMUITableViewCell_QMUISubclassingHooks
    {
        // -(void)didInitializeWithStyle:(UITableViewCellStyle)style __attribute__((objc_requires_super));
        [Export("didInitializeWithStyle:")]
        [RequiresSuper]
        void DidInitializeWithStyle(UITableViewCellStyle style);

        // -(void)updateCellAppearanceWithIndexPath:(NSIndexPath * _Nullable)indexPath __attribute__((objc_requires_super));
        [Export("updateCellAppearanceWithIndexPath:")]
        [RequiresSuper]
        void UpdateCellAppearanceWithIndexPath([NullAllowed] NSIndexPath indexPath);
    }

    // @interface QMUIAssetsGroup : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIAssetsGroup
    {
        // -(instancetype)initWithPHCollection:(PHAssetCollection *)phAssetCollection;
        [Export("initWithPHCollection:")]
        IntPtr Constructor(PHAssetCollection phAssetCollection);

        // -(instancetype)initWithPHCollection:(PHAssetCollection *)phAssetCollection fetchAssetsOptions:(PHFetchOptions *)pHFetchOptions;
        [Export("initWithPHCollection:fetchAssetsOptions:")]
        IntPtr Constructor(PHAssetCollection phAssetCollection, PHFetchOptions pHFetchOptions);

        // @property (readonly, nonatomic, strong) PHAssetCollection * phAssetCollection;
        [Export("phAssetCollection", ArgumentSemantic.Strong)]
        PHAssetCollection PhAssetCollection { get; }

        // @property (readonly, nonatomic, strong) PHFetchResult * phFetchResult;
        [Export("phFetchResult", ArgumentSemantic.Strong)]
        PHFetchResult PhFetchResult { get; }

        // -(NSString *)name;
        [Export("name")]
        [Verify(MethodToProperty)]
        string Name { get; }

        // -(NSInteger)numberOfAssets;
        [Export("numberOfAssets")]
        [Verify(MethodToProperty)]
        nint NumberOfAssets { get; }

        // -(UIImage *)posterImageWithSize:(CGSize)size;
        [Export("posterImageWithSize:")]
        UIImage PosterImageWithSize(CGSize size);

        // -(void)enumerateAssetsWithOptions:(QMUIAlbumSortType)albumSortType usingBlock:(void (^)(QMUIAsset *))enumerationBlock;
        [Export("enumerateAssetsWithOptions:usingBlock:")]
        void EnumerateAssetsWithOptions(QMUIAlbumSortType albumSortType, Action<QMUIAsset> enumerationBlock);

        // -(void)enumerateAssetsUsingBlock:(void (^)(QMUIAsset *))enumerationBlock;
        [Export("enumerateAssetsUsingBlock:")]
        void EnumerateAssetsUsingBlock(Action<QMUIAsset> enumerationBlock);
    }

    // @protocol QMUIAlbumViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIAlbumViewControllerDelegate
    {
        // @required -(QMUIImagePickerViewController * _Nonnull)imagePickerViewControllerForAlbumViewController:(QMUIAlbumViewController * _Nonnull)albumViewController;
        [Abstract]
        [Export("imagePickerViewControllerForAlbumViewController:")]
        QMUIImagePickerViewController ImagePickerViewControllerForAlbumViewController(QMUIAlbumViewController albumViewController);

        // @optional -(void)albumViewControllerDidCancel:(QMUIAlbumViewController * _Nonnull)albumViewController;
        [Export("albumViewControllerDidCancel:")]
        void AlbumViewControllerDidCancel(QMUIAlbumViewController albumViewController);

        // @optional -(void)albumViewControllerWillStartLoading:(QMUIAlbumViewController * _Nonnull)albumViewController;
        [Export("albumViewControllerWillStartLoading:")]
        void AlbumViewControllerWillStartLoading(QMUIAlbumViewController albumViewController);

        // @optional -(void)albumViewControllerWillFinishLoading:(QMUIAlbumViewController * _Nonnull)albumViewController;
        [Export("albumViewControllerWillFinishLoading:")]
        void AlbumViewControllerWillFinishLoading(QMUIAlbumViewController albumViewController);
    }

    // @interface QMUIAlbumTableViewCell : QMUITableViewCell
    [BaseType(typeof(QMUITableViewCell))]
    interface QMUIAlbumTableViewCell
    {
        // @property (assign, nonatomic) CGFloat albumImageSize __attribute__((annotate("ui_appearance_selector")));
        [Export("albumImageSize")]
        nfloat AlbumImageSize { get; set; }

        // @property (assign, nonatomic) CGFloat albumImageMarginLeft __attribute__((annotate("ui_appearance_selector")));
        [Export("albumImageMarginLeft")]
        nfloat AlbumImageMarginLeft { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets albumNameInsets __attribute__((annotate("ui_appearance_selector")));
        [Export("albumNameInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets AlbumNameInsets { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable albumNameFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("albumNameFont", ArgumentSemantic.Strong)]
        UIFont AlbumNameFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable albumNameColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("albumNameColor", ArgumentSemantic.Strong)]
        UIColor AlbumNameColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable albumAssetsNumberFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("albumAssetsNumberFont", ArgumentSemantic.Strong)]
        UIFont AlbumAssetsNumberFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable albumAssetsNumberColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("albumAssetsNumberColor", ArgumentSemantic.Strong)]
        UIColor AlbumAssetsNumberColor { get; set; }
    }

    // @interface QMUIAlbumViewController : QMUICommonTableViewController
    [BaseType(typeof(QMUICommonTableViewController))]
    interface QMUIAlbumViewController
    {
        [Wrap("WeakAlbumViewControllerDelegate")]
        [NullAllowed]
        QMUIAlbumViewControllerDelegate AlbumViewControllerDelegate { get; set; }

        // @property (nonatomic, weak) id<QMUIAlbumViewControllerDelegate> _Nullable albumViewControllerDelegate;
        [NullAllowed, Export("albumViewControllerDelegate", ArgumentSemantic.Weak)]
        NSObject WeakAlbumViewControllerDelegate { get; set; }

        // @property (assign, nonatomic) CGFloat albumTableViewCellHeight __attribute__((annotate("ui_appearance_selector")));
        [Export("albumTableViewCellHeight")]
        nfloat AlbumTableViewCellHeight { get; set; }

        // @property (assign, nonatomic) QMUIAlbumContentType contentType;
        [Export("contentType", ArgumentSemantic.Assign)]
        QMUIAlbumContentType ContentType { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable tipTextWhenNoPhotosAuthorization;
        [NullAllowed, Export("tipTextWhenNoPhotosAuthorization")]
        string TipTextWhenNoPhotosAuthorization { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable tipTextWhenPhotosEmpty;
        [NullAllowed, Export("tipTextWhenPhotosEmpty")]
        string TipTextWhenPhotosEmpty { get; set; }

        // @property (assign, nonatomic) BOOL shouldShowDefaultLoadingView;
        [Export("shouldShowDefaultLoadingView")]
        bool ShouldShowDefaultLoadingView { get; set; }

        // -(void)pickLastAlbumGroupDirectlyIfCan;
        [Export("pickLastAlbumGroupDirectlyIfCan")]
        void PickLastAlbumGroupDirectlyIfCan();
    }

    // @interface UIAppearance (QMUIAlbumViewController)
    [Category]
    [BaseType(typeof(QMUIAlbumViewController))]
    interface QMUIAlbumViewController_UIAppearance
    {
        // +(instancetype _Nonnull)appearance;
        [Static]
        [Export("appearance")]
        QMUIAlbumViewController Appearance();
    }

    // @protocol QMUIModalPresentationContentViewControllerProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIModalPresentationContentViewControllerProtocol
    {
        // @optional -(CGSize)preferredContentSizeInModalPresentationViewController:(QMUIModalPresentationViewController * _Nonnull)controller keyboardHeight:(CGFloat)keyboardHeight limitSize:(CGSize)limitSize;
        [Export("preferredContentSizeInModalPresentationViewController:keyboardHeight:limitSize:")]
        CGSize KeyboardHeight(QMUIModalPresentationViewController controller, nfloat keyboardHeight, CGSize limitSize);
    }

    // @protocol QMUIModalPresentationViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIModalPresentationViewControllerDelegate
    {
        // @optional -(BOOL)shouldHideModalPresentationViewController:(QMUIModalPresentationViewController * _Nonnull)controller;
        [Export("shouldHideModalPresentationViewController:")]
        bool ShouldHideModalPresentationViewController(QMUIModalPresentationViewController controller);

        // @optional -(void)willHideModalPresentationViewController:(QMUIModalPresentationViewController * _Nonnull)controller;
        [Export("willHideModalPresentationViewController:")]
        void WillHideModalPresentationViewController(QMUIModalPresentationViewController controller);

        // @optional -(void)didHideModalPresentationViewController:(QMUIModalPresentationViewController * _Nonnull)controller;
        [Export("didHideModalPresentationViewController:")]
        void DidHideModalPresentationViewController(QMUIModalPresentationViewController controller);
    }

    // @interface QMUIModalPresentationViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface QMUIModalPresentationViewController
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        QMUIModalPresentationViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<QMUIModalPresentationViewControllerDelegate> _Nullable delegate __attribute__((iboutlet));
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable contentView __attribute__((iboutlet));
        [NullAllowed, Export("contentView", ArgumentSemantic.Strong)]
        UIView ContentView { get; set; }

        // @property (nonatomic, strong) UIViewController<QMUIModalPresentationContentViewControllerProtocol> * _Nullable contentViewController __attribute__((iboutlet));
        [NullAllowed, Export("contentViewController", ArgumentSemantic.Strong)]
        QMUIModalPresentationContentViewControllerProtocol ContentViewController { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets contentViewMargins __attribute__((annotate("ui_appearance_selector")));
        [Export("contentViewMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets ContentViewMargins { get; set; }

        // @property (assign, nonatomic) CGFloat maximumContentViewWidth __attribute__((annotate("ui_appearance_selector")));
        [Export("maximumContentViewWidth")]
        nfloat MaximumContentViewWidth { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable dimmingView __attribute__((iboutlet));
        [NullAllowed, Export("dimmingView", ArgumentSemantic.Strong)]
        UIView DimmingView { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) willHideByDimmingViewTappedBlock;
        [NullAllowed, Export("willHideByDimmingViewTappedBlock", ArgumentSemantic.Copy)]
        Action WillHideByDimmingViewTappedBlock { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) didHideByDimmingViewTappedBlock;
        [NullAllowed, Export("didHideByDimmingViewTappedBlock", ArgumentSemantic.Copy)]
        Action DidHideByDimmingViewTappedBlock { get; set; }

        // @property (getter = isModal, assign, nonatomic) BOOL modal;
        [Export("modal")]
        bool Modal { [Bind("isModal")] get; set; }

        // @property (readonly, getter = isVisible, assign, nonatomic) BOOL visible;
        [Export("visible")]
        bool Visible { [Bind("isVisible")] get; }

        // @property (assign, nonatomic) UIInterfaceOrientationMask supportedOrientationMask;
        [Export("supportedOrientationMask", ArgumentSemantic.Assign)]
        UIInterfaceOrientationMask SupportedOrientationMask { get; set; }

        // @property (assign, nonatomic) QMUIModalPresentationAnimationStyle animationStyle __attribute__((annotate("ui_appearance_selector")));
        [Export("animationStyle", ArgumentSemantic.Assign)]
        QMUIModalPresentationAnimationStyle AnimationStyle { get; set; }

        // @property (readonly, getter = isShownInWindowMode, assign, nonatomic) BOOL shownInWindowMode;
        [Export("shownInWindowMode")]
        bool ShownInWindowMode { [Bind("isShownInWindowMode")] get; }

        // @property (readonly, getter = isShownInPresentedMode, assign, nonatomic) BOOL shownInPresentedMode;
        [Export("shownInPresentedMode")]
        bool ShownInPresentedMode { [Bind("isShownInPresentedMode")] get; }

        // @property (readonly, getter = isShownInSubviewMode, assign, nonatomic) BOOL shownInSubviewMode;
        [Export("shownInSubviewMode")]
        bool ShownInSubviewMode { [Bind("isShownInSubviewMode")] get; }

        // @property (assign, nonatomic) BOOL onlyRespondsToKeyboardEventFromDescendantViews;
        [Export("onlyRespondsToKeyboardEventFromDescendantViews")]
        bool OnlyRespondsToKeyboardEventFromDescendantViews { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(CGRect, CGFloat, CGRect) layoutBlock;
        [NullAllowed, Export("layoutBlock", ArgumentSemantic.Copy)]
        Action<CGRect, nfloat, CGRect> LayoutBlock { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(UIView * _Nullable, CGRect, CGFloat, CGRect, void (^ _Nonnull)(BOOL)) showingAnimation;
        [NullAllowed, Export("showingAnimation", ArgumentSemantic.Copy)]
        Action<UIView, CGRect, nfloat, CGRect, Action<bool>> ShowingAnimation { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(UIView * _Nullable, CGRect, CGFloat, void (^ _Nonnull)(BOOL)) hidingAnimation;
        [NullAllowed, Export("hidingAnimation", ArgumentSemantic.Copy)]
        Action<UIView, CGRect, nfloat, Action<bool>> HidingAnimation { get; set; }

        // -(void)updateLayout;
        [Export("updateLayout")]
        void UpdateLayout();

        // -(void)showWithAnimated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
        [Export("showWithAnimated:completion:")]
        void ShowWithAnimated(bool animated, [NullAllowed] Action<bool> completion);

        // -(void)hideWithAnimated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
        [Export("hideWithAnimated:completion:")]
        void HideWithAnimated(bool animated, [NullAllowed] Action<bool> completion);

        // -(void)showInView:(UIView * _Nonnull)view animated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
        [Export("showInView:animated:completion:")]
        void ShowInView(UIView view, bool animated, [NullAllowed] Action<bool> completion);

        // -(void)hideInView:(UIView * _Nonnull)view animated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
        [Export("hideInView:animated:completion:")]
        void HideInView(UIView view, bool animated, [NullAllowed] Action<bool> completion);
    }

    // @protocol QMUIModalPresentationComponentProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIModalPresentationComponentProtocol
    {
        // @required -(void)hideModalPresentationComponent;
        [Abstract]
        [Export("hideModalPresentationComponent")]
        void HideModalPresentationComponent();
    }

    // @interface Manager (QMUIModalPresentationViewController)
    [Category]
    [BaseType(typeof(QMUIModalPresentationViewController))]
    interface QMUIModalPresentationViewController_Manager
    {
        // +(BOOL)isAnyModalPresentationViewControllerVisible;
        [Static]
        [Export("isAnyModalPresentationViewControllerVisible")]
        [Verify(MethodToProperty)]
        bool IsAnyModalPresentationViewControllerVisible { get; }

        // +(BOOL)hideAllVisibleModalPresentationViewControllerIfCan;
        [Static]
        [Export("hideAllVisibleModalPresentationViewControllerIfCan")]
        [Verify(MethodToProperty)]
        bool HideAllVisibleModalPresentationViewControllerIfCan { get; }
    }

    // @interface UIAppearance (QMUIModalPresentationViewController)
    [Category]
    [BaseType(typeof(QMUIModalPresentationViewController))]
    interface QMUIModalPresentationViewController_UIAppearance
    {
        // +(instancetype _Nonnull)appearance;
        [Static]
        [Export("appearance")]
        QMUIModalPresentationViewController Appearance();
    }

    // @interface QMUIModalPresentationWindow : UIWindow
    [BaseType(typeof(UIWindow))]
    interface QMUIModalPresentationWindow
    {
    }

    // @interface QMUIModalPresentationViewController (UIViewController)
    [Category]
    [BaseType(typeof(UIViewController))]
    interface UIViewController_QMUIModalPresentationViewController
    {
        // @property (readonly, nonatomic, weak) QMUIModalPresentationViewController * _Nullable qmui_modalPresentationViewController;
        [NullAllowed, Export("qmui_modalPresentationViewController", ArgumentSemantic.Weak)]
        QMUIModalPresentationViewController Qmui_modalPresentationViewController { get; }
    }

    // @protocol QMUIAlertControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIAlertControllerDelegate
    {
        // @optional -(void)willShowAlertController:(QMUIAlertController * _Nonnull)alertController;
        [Export("willShowAlertController:")]
        void WillShowAlertController(QMUIAlertController alertController);

        // @optional -(void)willHideAlertController:(QMUIAlertController * _Nonnull)alertController;
        [Export("willHideAlertController:")]
        void WillHideAlertController(QMUIAlertController alertController);

        // @optional -(void)didShowAlertController:(QMUIAlertController * _Nonnull)alertController;
        [Export("didShowAlertController:")]
        void DidShowAlertController(QMUIAlertController alertController);

        // @optional -(void)didHideAlertController:(QMUIAlertController * _Nonnull)alertController;
        [Export("didHideAlertController:")]
        void DidHideAlertController(QMUIAlertController alertController);

        // @optional -(BOOL)shouldHideAlertController:(QMUIAlertController * _Nonnull)alertController;
        [Export("shouldHideAlertController:")]
        bool ShouldHideAlertController(QMUIAlertController alertController);
    }

    // @interface QMUIAlertAction : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIAlertAction
    {
        // +(instancetype _Nonnull)actionWithTitle:(NSString * _Nullable)title style:(QMUIAlertActionStyle)style handler:(void (^ _Nullable)(__kindof QMUIAlertController * _Nonnull, QMUIAlertAction * _Nonnull))handler;
        [Static]
        [Export("actionWithTitle:style:handler:")]
        QMUIAlertAction ActionWithTitle([NullAllowed] string title, QMUIAlertActionStyle style, [NullAllowed] Action<QMUIAlertController, QMUIAlertAction> handler);

        // @property (readonly, nonatomic, strong) QMUIButton * _Nonnull button;
        [Export("button", ArgumentSemantic.Strong)]
        QMUIButton Button { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; }

        // @property (readonly, assign, nonatomic) QMUIAlertActionStyle style;
        [Export("style", ArgumentSemantic.Assign)]
        QMUIAlertActionStyle Style { get; }

        // @property (getter = isEnabled, assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { [Bind("isEnabled")] get; set; }

        // @property (nonatomic, strong) NSDictionary<NSAttributedStringKey,id> * _Nullable buttonAttributes;
        [NullAllowed, Export("buttonAttributes", ArgumentSemantic.Strong)]
        NSDictionary<NSString, NSObject> ButtonAttributes { get; set; }

        // @property (nonatomic, strong) NSDictionary<NSAttributedStringKey,id> * _Nullable buttonDisabledAttributes;
        [NullAllowed, Export("buttonDisabledAttributes", ArgumentSemantic.Strong)]
        NSDictionary<NSString, NSObject> ButtonDisabledAttributes { get; set; }
    }

    // @interface QMUIAlertController : UIViewController <QMUIModalPresentationComponentProtocol>
    [BaseType(typeof(UIViewController))]
    interface QMUIAlertController : IQMUIModalPresentationComponentProtocol
    {
        // @property (assign, nonatomic) UIEdgeInsets alertContentMargin __attribute__((annotate("ui_appearance_selector")));
        [Export("alertContentMargin", ArgumentSemantic.Assign)]
        UIEdgeInsets AlertContentMargin { get; set; }

        // @property (assign, nonatomic) CGFloat alertContentMaximumWidth __attribute__((annotate("ui_appearance_selector")));
        [Export("alertContentMaximumWidth")]
        nfloat AlertContentMaximumWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable alertSeparatorColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("alertSeparatorColor", ArgumentSemantic.Strong)]
        UIColor AlertSeparatorColor { get; set; }

        // @property (nonatomic, strong) NSDictionary<NSAttributedStringKey,id> * _Nullable alertTitleAttributes __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("alertTitleAttributes", ArgumentSemantic.Strong)]
        NSDictionary<NSString, NSObject> AlertTitleAttributes { get; set; }

        // @property (nonatomic, strong) NSDictionary<NSAttributedStringKey,id> * _Nullable alertMessageAttributes __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("alertMessageAttributes", ArgumentSemantic.Strong)]
        NSDictionary<NSString, NSObject> AlertMessageAttributes { get; set; }

        // @property (nonatomic, strong) NSDictionary<NSAttributedStringKey,id> * _Nullable alertButtonAttributes __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("alertButtonAttributes", ArgumentSemantic.Strong)]
        NSDictionary<NSString, NSObject> AlertButtonAttributes { get; set; }

        // @property (nonatomic, strong) NSDictionary<NSAttributedStringKey,id> * _Nullable alertButtonDisabledAttributes __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("alertButtonDisabledAttributes", ArgumentSemantic.Strong)]
        NSDictionary<NSString, NSObject> AlertButtonDisabledAttributes { get; set; }

        // @property (nonatomic, strong) NSDictionary<NSAttributedStringKey,id> * _Nullable alertCancelButtonAttributes __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("alertCancelButtonAttributes", ArgumentSemantic.Strong)]
        NSDictionary<NSString, NSObject> AlertCancelButtonAttributes { get; set; }

        // @property (nonatomic, strong) NSDictionary<NSAttributedStringKey,id> * _Nullable alertDestructiveButtonAttributes __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("alertDestructiveButtonAttributes", ArgumentSemantic.Strong)]
        NSDictionary<NSString, NSObject> AlertDestructiveButtonAttributes { get; set; }

        // @property (assign, nonatomic) CGFloat alertContentCornerRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("alertContentCornerRadius")]
        nfloat AlertContentCornerRadius { get; set; }

        // @property (assign, nonatomic) CGFloat alertButtonHeight __attribute__((annotate("ui_appearance_selector")));
        [Export("alertButtonHeight")]
        nfloat AlertButtonHeight { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable alertHeaderBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("alertHeaderBackgroundColor", ArgumentSemantic.Strong)]
        UIColor AlertHeaderBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable alertButtonBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("alertButtonBackgroundColor", ArgumentSemantic.Strong)]
        UIColor AlertButtonBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable alertButtonHighlightBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("alertButtonHighlightBackgroundColor", ArgumentSemantic.Strong)]
        UIColor AlertButtonHighlightBackgroundColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets alertHeaderInsets __attribute__((annotate("ui_appearance_selector")));
        [Export("alertHeaderInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets AlertHeaderInsets { get; set; }

        // @property (assign, nonatomic) CGFloat alertTitleMessageSpacing __attribute__((annotate("ui_appearance_selector")));
        [Export("alertTitleMessageSpacing")]
        nfloat AlertTitleMessageSpacing { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable alertTextFieldFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("alertTextFieldFont", ArgumentSemantic.Strong)]
        UIFont AlertTextFieldFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable alertTextFieldTextColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("alertTextFieldTextColor", ArgumentSemantic.Strong)]
        UIColor AlertTextFieldTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable alertTextFieldBorderColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("alertTextFieldBorderColor", ArgumentSemantic.Strong)]
        UIColor AlertTextFieldBorderColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets alertTextFieldTextInsets __attribute__((annotate("ui_appearance_selector")));
        [Export("alertTextFieldTextInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets AlertTextFieldTextInsets { get; set; }

        // @property (copy, nonatomic) UIEdgeInsets (^ _Nonnull)(__kindof QMUIAlertController * _Nonnull, NSInteger) alertTextFieldMarginBlock;
        [Export("alertTextFieldMarginBlock", ArgumentSemantic.Copy)]
        Func<QMUIAlertController, nint, UIEdgeInsets> AlertTextFieldMarginBlock { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets sheetContentMargin __attribute__((annotate("ui_appearance_selector")));
        [Export("sheetContentMargin", ArgumentSemantic.Assign)]
        UIEdgeInsets SheetContentMargin { get; set; }

        // @property (assign, nonatomic) CGFloat sheetContentMaximumWidth __attribute__((annotate("ui_appearance_selector")));
        [Export("sheetContentMaximumWidth")]
        nfloat SheetContentMaximumWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable sheetSeparatorColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("sheetSeparatorColor", ArgumentSemantic.Strong)]
        UIColor SheetSeparatorColor { get; set; }

        // @property (copy, nonatomic) NSDictionary<NSAttributedStringKey,id> * _Nullable sheetTitleAttributes __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("sheetTitleAttributes", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> SheetTitleAttributes { get; set; }

        // @property (copy, nonatomic) NSDictionary<NSAttributedStringKey,id> * _Nullable sheetMessageAttributes __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("sheetMessageAttributes", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> SheetMessageAttributes { get; set; }

        // @property (copy, nonatomic) NSDictionary<NSAttributedStringKey,id> * _Nullable sheetButtonAttributes __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("sheetButtonAttributes", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> SheetButtonAttributes { get; set; }

        // @property (copy, nonatomic) NSDictionary<NSAttributedStringKey,id> * _Nullable sheetButtonDisabledAttributes __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("sheetButtonDisabledAttributes", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> SheetButtonDisabledAttributes { get; set; }

        // @property (copy, nonatomic) NSDictionary<NSAttributedStringKey,id> * _Nullable sheetCancelButtonAttributes __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("sheetCancelButtonAttributes", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> SheetCancelButtonAttributes { get; set; }

        // @property (copy, nonatomic) NSDictionary<NSAttributedStringKey,id> * _Nullable sheetDestructiveButtonAttributes __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("sheetDestructiveButtonAttributes", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> SheetDestructiveButtonAttributes { get; set; }

        // @property (assign, nonatomic) CGFloat sheetCancelButtonMarginTop __attribute__((annotate("ui_appearance_selector")));
        [Export("sheetCancelButtonMarginTop")]
        nfloat SheetCancelButtonMarginTop { get; set; }

        // @property (assign, nonatomic) CGFloat sheetContentCornerRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("sheetContentCornerRadius")]
        nfloat SheetContentCornerRadius { get; set; }

        // @property (assign, nonatomic) CGFloat sheetButtonHeight __attribute__((annotate("ui_appearance_selector")));
        [Export("sheetButtonHeight")]
        nfloat SheetButtonHeight { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable sheetHeaderBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("sheetHeaderBackgroundColor", ArgumentSemantic.Strong)]
        UIColor SheetHeaderBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable sheetButtonBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("sheetButtonBackgroundColor", ArgumentSemantic.Strong)]
        UIColor SheetButtonBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable sheetButtonHighlightBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("sheetButtonHighlightBackgroundColor", ArgumentSemantic.Strong)]
        UIColor SheetButtonHighlightBackgroundColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets sheetHeaderInsets __attribute__((annotate("ui_appearance_selector")));
        [Export("sheetHeaderInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets SheetHeaderInsets { get; set; }

        // @property (assign, nonatomic) CGFloat sheetTitleMessageSpacing __attribute__((annotate("ui_appearance_selector")));
        [Export("sheetTitleMessageSpacing")]
        nfloat SheetTitleMessageSpacing { get; set; }

        // @property (assign, nonatomic) CGFloat sheetButtonColumnCount __attribute__((annotate("ui_appearance_selector")));
        [Export("sheetButtonColumnCount")]
        nfloat SheetButtonColumnCount { get; set; }

        // -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title message:(NSString * _Nullable)message preferredStyle:(QMUIAlertControllerStyle)preferredStyle;
        [Export("initWithTitle:message:preferredStyle:")]
        IntPtr Constructor([NullAllowed] string title, [NullAllowed] string message, QMUIAlertControllerStyle preferredStyle);

        // +(instancetype _Nonnull)alertControllerWithTitle:(NSString * _Nullable)title message:(NSString * _Nullable)message preferredStyle:(QMUIAlertControllerStyle)preferredStyle;
        [Static]
        [Export("alertControllerWithTitle:message:preferredStyle:")]
        QMUIAlertController AlertControllerWithTitle([NullAllowed] string title, [NullAllowed] string message, QMUIAlertControllerStyle preferredStyle);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        QMUIAlertControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<QMUIAlertControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(void)addAction:(QMUIAlertAction * _Nonnull)action;
        [Export("addAction:")]
        void AddAction(QMUIAlertAction action);

        // -(void)addCancelAction;
        [Export("addCancelAction")]
        void AddCancelAction();

        // -(void)addTextFieldWithConfigurationHandler:(void (^ _Nullable)(QMUITextField * _Nonnull))configurationHandler;
        [Export("addTextFieldWithConfigurationHandler:")]
        void AddTextFieldWithConfigurationHandler([NullAllowed] Action<QMUITextField> configurationHandler);

        // @property (assign, nonatomic) BOOL shouldManageTextFieldsReturnEventAutomatically;
        [Export("shouldManageTextFieldsReturnEventAutomatically")]
        bool ShouldManageTextFieldsReturnEventAutomatically { get; set; }

        // -(void)addCustomView:(UIView * _Nullable)view;
        [Export("addCustomView:")]
        void AddCustomView([NullAllowed] UIView view);

        // -(void)showWithAnimated:(BOOL)animated;
        [Export("showWithAnimated:")]
        void ShowWithAnimated(bool animated);

        // -(void)hideWithAnimated:(BOOL)animated;
        [Export("hideWithAnimated:")]
        void HideWithAnimated(bool animated);

        // @property (readonly, copy, nonatomic) NSArray<QMUIAlertAction *> * _Nullable actions;
        [NullAllowed, Export("actions", ArgumentSemantic.Copy)]
        QMUIAlertAction[] Actions { get; }

        // @property (readonly, copy, nonatomic) NSArray<QMUITextField *> * _Nullable textFields;
        [NullAllowed, Export("textFields", ArgumentSemantic.Copy)]
        QMUITextField[] TextFields { get; }

        // @property (readonly, nonatomic, strong) UIView * _Nullable customView;
        [NullAllowed, Export("customView", ArgumentSemantic.Strong)]
        UIView CustomView { get; }

        // @property (copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable message;
        [NullAllowed, Export("message")]
        string Message { get; set; }

        // @property (readonly, assign, nonatomic) QMUIAlertControllerStyle preferredStyle;
        [Export("preferredStyle", ArgumentSemantic.Assign)]
        QMUIAlertControllerStyle PreferredStyle { get; }

        // @property (readonly, nonatomic, strong) QMUIModalPresentationViewController * _Nullable modalPresentationViewController;
        [NullAllowed, Export("modalPresentationViewController", ArgumentSemantic.Strong)]
        QMUIModalPresentationViewController ModalPresentationViewController { get; }

        // @property (nonatomic, strong) UIView * _Null_unspecified mainVisualEffectView;
        [Export("mainVisualEffectView", ArgumentSemantic.Strong)]
        UIView MainVisualEffectView { get; set; }

        // @property (nonatomic, strong) UIView * _Null_unspecified cancelButtonVisualEffectView;
        [Export("cancelButtonVisualEffectView", ArgumentSemantic.Strong)]
        UIView CancelButtonVisualEffectView { get; set; }

        // @property (assign, nonatomic) BOOL orderActionsByAddedOrdered;
        [Export("orderActionsByAddedOrdered")]
        bool OrderActionsByAddedOrdered { get; set; }

        // @property (assign, nonatomic) BOOL shouldRespondMaskViewTouch;
        [Export("shouldRespondMaskViewTouch")]
        bool ShouldRespondMaskViewTouch { get; set; }

        // @property (assign, nonatomic) BOOL isExtendBottomLayout __attribute__((annotate("ui_appearance_selector")));
        [Export("isExtendBottomLayout")]
        bool IsExtendBottomLayout { get; set; }
    }

    // @interface UIAppearance (QMUIAlertController)
    [Category]
    [BaseType(typeof(QMUIAlertController))]
    interface QMUIAlertController_UIAppearance
    {
        // +(instancetype _Nonnull)appearance;
        [Static]
        [Export("appearance")]
        QMUIAlertController Appearance();
    }

    // @interface Manager (QMUIAlertController)
    [Category]
    [BaseType(typeof(QMUIAlertController))]
    interface QMUIAlertController_Manager
    {
        // +(BOOL)isAnyAlertControllerVisible;
        [Static]
        [Export("isAnyAlertControllerVisible")]
        [Verify(MethodToProperty)]
        bool IsAnyAlertControllerVisible { get; }
    }

    // @interface QMUIAnimationHelper : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIAnimationHelper
    {
        // +(id)interpolateFromValue:(id)fromValue toValue:(id)toValue time:(CGFloat)time easing:(QMUIAnimationEasings)easing;
        [Static]
        [Export("interpolateFromValue:toValue:time:easing:")]
        NSObject InterpolateFromValue(NSObject fromValue, NSObject toValue, nfloat time, QMUIAnimationEasings easing);

        // +(id)interpolateSpringFromValue:(id)fromValue toValue:(id)toValue time:(CGFloat)time mass:(CGFloat)mass damping:(CGFloat)damping stiffness:(CGFloat)stiffness initialVelocity:(CGFloat)initialVelocity easing:(QMUIAnimationEasings)easing;
        [Static]
        [Export("interpolateSpringFromValue:toValue:time:mass:damping:stiffness:initialVelocity:easing:")]
        NSObject InterpolateSpringFromValue(NSObject fromValue, NSObject toValue, nfloat time, nfloat mass, nfloat damping, nfloat stiffness, nfloat initialVelocity, QMUIAnimationEasings easing);
    }

    // @interface QMUIAppearance : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIAppearance
    {
        // +(id _Nonnull)appearanceForClass:(Class _Nonnull)aClass;
        [Static]
        [Export("appearanceForClass:")]
        NSObject AppearanceForClass(Class aClass);
    }

    // @interface QMUIAppearnace (NSObject)
    [Category]
    [BaseType(typeof(NSObject))]
    interface NSObject_QMUIAppearnace
    {
        // -(void)qmui_applyAppearance;
        [Export("qmui_applyAppearance")]
        void Qmui_applyAppearance();
    }

    // @interface QMUIAsset : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIAsset
    {
        // @property (readonly, assign, nonatomic) QMUIAssetType assetType;
        [Export("assetType", ArgumentSemantic.Assign)]
        QMUIAssetType AssetType { get; }

        // @property (readonly, assign, nonatomic) QMUIAssetSubType assetSubType;
        [Export("assetSubType", ArgumentSemantic.Assign)]
        QMUIAssetSubType AssetSubType { get; }

        // -(instancetype)initWithPHAsset:(PHAsset *)phAsset;
        [Export("initWithPHAsset:")]
        IntPtr Constructor(PHAsset phAsset);

        // @property (readonly, nonatomic, strong) PHAsset * phAsset;
        [Export("phAsset", ArgumentSemantic.Strong)]
        PHAsset PhAsset { get; }

        // @property (readonly, assign, nonatomic) QMUIAssetDownloadStatus downloadStatus;
        [Export("downloadStatus", ArgumentSemantic.Assign)]
        QMUIAssetDownloadStatus DownloadStatus { get; }

        // @property (assign, nonatomic) double downloadProgress;
        [Export("downloadProgress")]
        double DownloadProgress { get; set; }

        // @property (assign, nonatomic) NSInteger requestID;
        [Export("requestID")]
        nint RequestID { get; set; }

        // @property (readonly, copy, nonatomic) NSString * identifier;
        [Export("identifier")]
        string Identifier { get; }

        // -(UIImage *)originImage;
        [Export("originImage")]
        [Verify(MethodToProperty)]
        UIImage OriginImage { get; }

        // -(UIImage *)thumbnailWithSize:(CGSize)size;
        [Export("thumbnailWithSize:")]
        UIImage ThumbnailWithSize(CGSize size);

        // -(UIImage *)previewImage;
        [Export("previewImage")]
        [Verify(MethodToProperty)]
        UIImage PreviewImage { get; }

        // -(NSInteger)requestOriginImageWithCompletion:(void (^)(UIImage *, NSDictionary<NSString *,id> *))completion withProgressHandler:(PHAssetImageProgressHandler)phProgressHandler;
        [Export("requestOriginImageWithCompletion:withProgressHandler:")]
        nint RequestOriginImageWithCompletion(Action<UIImage, NSDictionary<NSString, NSObject>> completion, PHAssetImageProgressHandler phProgressHandler);

        // -(NSInteger)requestThumbnailImageWithSize:(CGSize)size completion:(void (^)(UIImage *, NSDictionary<NSString *,id> *))completion;
        [Export("requestThumbnailImageWithSize:completion:")]
        nint RequestThumbnailImageWithSize(CGSize size, Action<UIImage, NSDictionary<NSString, NSObject>> completion);

        // -(NSInteger)requestPreviewImageWithCompletion:(void (^)(UIImage *, NSDictionary<NSString *,id> *))completion withProgressHandler:(PHAssetImageProgressHandler)phProgressHandler;
        [Export("requestPreviewImageWithCompletion:withProgressHandler:")]
        nint RequestPreviewImageWithCompletion(Action<UIImage, NSDictionary<NSString, NSObject>> completion, PHAssetImageProgressHandler phProgressHandler);

        // -(NSInteger)requestLivePhotoWithCompletion:(void (^)(PHLivePhoto *, NSDictionary<NSString *,id> *))completion withProgressHandler:(PHAssetImageProgressHandler)phProgressHandler;
        [Export("requestLivePhotoWithCompletion:withProgressHandler:")]
        nint RequestLivePhotoWithCompletion(Action<PHLivePhoto, NSDictionary<NSString, NSObject>> completion, PHAssetImageProgressHandler phProgressHandler);

        // -(NSInteger)requestPlayerItemWithCompletion:(void (^)(AVPlayerItem *, NSDictionary<NSString *,id> *))completion withProgressHandler:(PHAssetVideoProgressHandler)phProgressHandler;
        [Export("requestPlayerItemWithCompletion:withProgressHandler:")]
        nint RequestPlayerItemWithCompletion(Action<AVPlayerItem, NSDictionary<NSString, NSObject>> completion, PHAssetVideoProgressHandler phProgressHandler);

        // -(void)requestImageData:(void (^)(NSData *, NSDictionary<NSString *,id> *, BOOL, BOOL))completion;
        [Export("requestImageData:")]
        void RequestImageData(Action<NSData, NSDictionary<NSString, NSObject>, bool, bool> completion);

        // -(UIImageOrientation)imageOrientation;
        [Export("imageOrientation")]
        [Verify(MethodToProperty)]
        UIImageOrientation ImageOrientation { get; }

        // -(void)updateDownloadStatusWithDownloadResult:(BOOL)succeed;
        [Export("updateDownloadStatusWithDownloadResult:")]
        void UpdateDownloadStatusWithDownloadResult(bool succeed);

        // -(void)assetSize:(void (^)(long long))completion;
        [Export("assetSize:")]
        void AssetSize(Action<long> completion);

        // -(NSTimeInterval)duration;
        [Export("duration")]
        [Verify(MethodToProperty)]
        double Duration { get; }
    }

    // typedef void (^QMUIWriteAssetCompletionBlock)(QMUIAsset *, NSError *);
    delegate void QMUIWriteAssetCompletionBlock(QMUIAsset arg0, NSError arg1);

    // @interface QMUIAssetsManager : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIAssetsManager
    {
        // +(instancetype)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        QMUIAssetsManager SharedInstance();

        // +(QMUIAssetAuthorizationStatus)authorizationStatus;
        [Static]
        [Export("authorizationStatus")]
        [Verify(MethodToProperty)]
        QMUIAssetAuthorizationStatus AuthorizationStatus { get; }

        // +(void)requestAuthorization:(void (^)(QMUIAssetAuthorizationStatus))handler;
        [Static]
        [Export("requestAuthorization:")]
        void RequestAuthorization(Action<QMUIAssetAuthorizationStatus> handler);

        // -(void)enumerateAllAlbumsWithAlbumContentType:(QMUIAlbumContentType)contentType showEmptyAlbum:(BOOL)showEmptyAlbum showSmartAlbumIfSupported:(BOOL)showSmartAlbumIfSupported usingBlock:(void (^)(QMUIAssetsGroup *))enumerationBlock;
        [Export("enumerateAllAlbumsWithAlbumContentType:showEmptyAlbum:showSmartAlbumIfSupported:usingBlock:")]
        void EnumerateAllAlbumsWithAlbumContentType(QMUIAlbumContentType contentType, bool showEmptyAlbum, bool showSmartAlbumIfSupported, Action<QMUIAssetsGroup> enumerationBlock);

        // -(void)enumerateAllAlbumsWithAlbumContentType:(QMUIAlbumContentType)contentType usingBlock:(void (^)(QMUIAssetsGroup *))enumerationBlock;
        [Export("enumerateAllAlbumsWithAlbumContentType:usingBlock:")]
        void EnumerateAllAlbumsWithAlbumContentType(QMUIAlbumContentType contentType, Action<QMUIAssetsGroup> enumerationBlock);

        // -(void)saveImageWithImageRef:(CGImageRef)imageRef albumAssetsGroup:(QMUIAssetsGroup *)albumAssetsGroup orientation:(UIImageOrientation)orientation completionBlock:(QMUIWriteAssetCompletionBlock)completionBlock;
        [Export("saveImageWithImageRef:albumAssetsGroup:orientation:completionBlock:")]
        unsafe void SaveImageWithImageRef(CGImageRef* imageRef, QMUIAssetsGroup albumAssetsGroup, UIImageOrientation orientation, QMUIWriteAssetCompletionBlock completionBlock);

        // -(void)saveImageWithImagePathURL:(NSURL *)imagePathURL albumAssetsGroup:(QMUIAssetsGroup *)albumAssetsGroup completionBlock:(QMUIWriteAssetCompletionBlock)completionBlock;
        [Export("saveImageWithImagePathURL:albumAssetsGroup:completionBlock:")]
        void SaveImageWithImagePathURL(NSUrl imagePathURL, QMUIAssetsGroup albumAssetsGroup, QMUIWriteAssetCompletionBlock completionBlock);

        // -(void)saveVideoWithVideoPathURL:(NSURL *)videoPathURL albumAssetsGroup:(QMUIAssetsGroup *)albumAssetsGroup completionBlock:(QMUIWriteAssetCompletionBlock)completionBlock;
        [Export("saveVideoWithVideoPathURL:albumAssetsGroup:completionBlock:")]
        void SaveVideoWithVideoPathURL(NSUrl videoPathURL, QMUIAssetsGroup albumAssetsGroup, QMUIWriteAssetCompletionBlock completionBlock);

        // -(PHCachingImageManager *)phCachingImageManager;
        [Export("phCachingImageManager")]
        [Verify(MethodToProperty)]
        PHCachingImageManager PhCachingImageManager { get; }
    }

    // @interface QMUI (PHPhotoLibrary)
    [Category]
    [BaseType(typeof(PHPhotoLibrary))]
    interface PHPhotoLibrary_QMUI
    {
        // +(PHFetchOptions *)createFetchOptionsWithAlbumContentType:(QMUIAlbumContentType)contentType;
        [Static]
        [Export("createFetchOptionsWithAlbumContentType:")]
        PHFetchOptions CreateFetchOptionsWithAlbumContentType(QMUIAlbumContentType contentType);

        // +(NSArray<PHAssetCollection *> *)fetchAllAlbumsWithAlbumContentType:(QMUIAlbumContentType)contentType showEmptyAlbum:(BOOL)showEmptyAlbum showSmartAlbum:(BOOL)showSmartAlbum;
        [Static]
        [Export("fetchAllAlbumsWithAlbumContentType:showEmptyAlbum:showSmartAlbum:")]
        PHAssetCollection[] FetchAllAlbumsWithAlbumContentType(QMUIAlbumContentType contentType, bool showEmptyAlbum, bool showSmartAlbum);

        // +(PHAsset *)fetchLatestAssetWithAssetCollection:(PHAssetCollection *)assetCollection;
        [Static]
        [Export("fetchLatestAssetWithAssetCollection:")]
        PHAsset FetchLatestAssetWithAssetCollection(PHAssetCollection assetCollection);

        // -(void)addImageToAlbum:(CGImageRef)imageRef albumAssetCollection:(PHAssetCollection *)albumAssetCollection orientation:(UIImageOrientation)orientation completionHandler:(void (^)(BOOL, NSDate *, NSError *))completionHandler;
        [Export("addImageToAlbum:albumAssetCollection:orientation:completionHandler:")]
        unsafe void AddImageToAlbum(CGImageRef* imageRef, PHAssetCollection albumAssetCollection, UIImageOrientation orientation, Action<bool, NSDate, NSError> completionHandler);

        // -(void)addImageToAlbum:(NSURL *)imagePathURL albumAssetCollection:(PHAssetCollection *)albumAssetCollection completionHandler:(void (^)(BOOL, NSDate *, NSError *))completionHandler;
        [Export("addImageToAlbum:albumAssetCollection:completionHandler:")]
        void AddImageToAlbum(NSUrl imagePathURL, PHAssetCollection albumAssetCollection, Action<bool, NSDate, NSError> completionHandler);

        // -(void)addVideoToAlbum:(NSURL *)videoPathURL albumAssetCollection:(PHAssetCollection *)albumAssetCollection completionHandler:(void (^)(BOOL, NSDate *, NSError *))completionHandler;
        [Export("addVideoToAlbum:albumAssetCollection:completionHandler:")]
        void AddVideoToAlbum(NSUrl videoPathURL, PHAssetCollection albumAssetCollection, Action<bool, NSDate, NSError> completionHandler);
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const CGPoint QMUIBadgeInvalidateOffset;
        [Field("QMUIBadgeInvalidateOffset", "__Internal")]
        CGPoint QMUIBadgeInvalidateOffset { get; }
    }

    // @interface QMUIHelper : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIHelper
    {
        // +(instancetype _Nonnull)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        QMUIHelper SharedInstance();

        // +(BOOL)executeBlock:(void (^ _Nonnull)(void))block oncePerIdentifier:(NSString * _Nonnull)identifier;
        [Static]
        [Export("executeBlock:oncePerIdentifier:")]
        bool ExecuteBlock(Action block, string identifier);

        // +(CALayerContentsGravity _Nonnull)layerContentsGravityWithContentMode:(UIViewContentMode)contentMode;
        [Static]
        [Export("layerContentsGravityWithContentMode:")]
        string LayerContentsGravityWithContentMode(UIViewContentMode contentMode);
    }

    // @interface Bundle (QMUIHelper)
    [Category]
    [BaseType(typeof(QMUIHelper))]
    interface QMUIHelper_Bundle
    {
        // +(UIImage * _Nullable)imageWithName:(NSString * _Nonnull)name;
        [Static]
        [Export("imageWithName:")]
        [return: NullAllowed]
        UIImage ImageWithName(string name);
    }

    // @interface SystemVersion (QMUIHelper)
    [Category]
    [BaseType(typeof(QMUIHelper))]
    interface QMUIHelper_SystemVersion
    {
        // +(NSInteger)numbericOSVersion;
        [Static]
        [Export("numbericOSVersion")]
        [Verify(MethodToProperty)]
        nint NumbericOSVersion { get; }

        // +(NSComparisonResult)compareSystemVersion:(NSString * _Nonnull)currentVersion toVersion:(NSString * _Nonnull)targetVersion;
        [Static]
        [Export("compareSystemVersion:toVersion:")]
        NSComparisonResult CompareSystemVersion(string currentVersion, string targetVersion);

        // +(BOOL)isCurrentSystemAtLeastVersion:(NSString * _Nonnull)targetVersion;
        [Static]
        [Export("isCurrentSystemAtLeastVersion:")]
        bool IsCurrentSystemAtLeastVersion(string targetVersion);

        // +(BOOL)isCurrentSystemLowerThanVersion:(NSString * _Nonnull)targetVersion;
        [Static]
        [Export("isCurrentSystemLowerThanVersion:")]
        bool IsCurrentSystemLowerThanVersion(string targetVersion);
    }

    // @interface DynamicType (QMUIHelper)
    [Category]
    [BaseType(typeof(QMUIHelper))]
    interface QMUIHelper_DynamicType
    {
        // +(NSNumber * _Nonnull)preferredContentSizeLevel;
        [Static]
        [Export("preferredContentSizeLevel")]
        [Verify(MethodToProperty)]
        NSNumber PreferredContentSizeLevel { get; }

        // +(CGFloat)heightForDynamicTypeCell:(NSArray * _Nonnull)heights;
        [Static]
        [Export("heightForDynamicTypeCell:")]
        [Verify(StronglyTypedNSArray)]
        nfloat HeightForDynamicTypeCell(NSObject[] heights);
    }

    // @interface Keyboard (QMUIHelper)
    [Category]
    [BaseType(typeof(QMUIHelper))]
    interface QMUIHelper_Keyboard
    {
        // +(BOOL)isKeyboardVisible;
        [Static]
        [Export("isKeyboardVisible")]
        [Verify(MethodToProperty)]
        bool IsKeyboardVisible { get; }

        // +(CGFloat)lastKeyboardHeightInApplicationWindowWhenVisible;
        [Static]
        [Export("lastKeyboardHeightInApplicationWindowWhenVisible")]
        [Verify(MethodToProperty)]
        nfloat LastKeyboardHeightInApplicationWindowWhenVisible { get; }

        // +(CGRect)keyboardRectWithNotification:(NSNotification * _Nullable)notification;
        [Static]
        [Export("keyboardRectWithNotification:")]
        CGRect KeyboardRectWithNotification([NullAllowed] NSNotification notification);

        // +(CGFloat)keyboardHeightWithNotification:(NSNotification * _Nullable)notification;
        [Static]
        [Export("keyboardHeightWithNotification:")]
        nfloat KeyboardHeightWithNotification([NullAllowed] NSNotification notification);

        // +(CGFloat)keyboardHeightWithNotification:(NSNotification * _Nullable)notification inView:(UIView * _Nullable)view;
        [Static]
        [Export("keyboardHeightWithNotification:inView:")]
        nfloat KeyboardHeightWithNotification([NullAllowed] NSNotification notification, [NullAllowed] UIView view);

        // +(NSTimeInterval)keyboardAnimationDurationWithNotification:(NSNotification * _Nullable)notification;
        [Static]
        [Export("keyboardAnimationDurationWithNotification:")]
        double KeyboardAnimationDurationWithNotification([NullAllowed] NSNotification notification);

        // +(UIViewAnimationCurve)keyboardAnimationCurveWithNotification:(NSNotification * _Nullable)notification;
        [Static]
        [Export("keyboardAnimationCurveWithNotification:")]
        UIViewAnimationCurve KeyboardAnimationCurveWithNotification([NullAllowed] NSNotification notification);

        // +(UIViewAnimationOptions)keyboardAnimationOptionsWithNotification:(NSNotification * _Nullable)notification;
        [Static]
        [Export("keyboardAnimationOptionsWithNotification:")]
        UIViewAnimationOptions KeyboardAnimationOptionsWithNotification([NullAllowed] NSNotification notification);
    }

    // @interface AudioSession (QMUIHelper)
    [Category]
    [BaseType(typeof(QMUIHelper))]
    interface QMUIHelper_AudioSession
    {
        // +(void)redirectAudioRouteWithSpeaker:(BOOL)speaker temporary:(BOOL)temporary;
        [Static]
        [Export("redirectAudioRouteWithSpeaker:temporary:")]
        void RedirectAudioRouteWithSpeaker(bool speaker, bool temporary);

        // +(void)setAudioSessionCategory:(NSString * _Nullable)category;
        [Static]
        [Export("setAudioSessionCategory:")]
        void SetAudioSessionCategory([NullAllowed] string category);
    }

    // @interface UIGraphic (QMUIHelper)
    [Category]
    [BaseType(typeof(QMUIHelper))]
    interface QMUIHelper_UIGraphic
    {
        // @property (readonly, nonatomic, class) CGFloat pixelOne;
        [Static]
        [Export("pixelOne")]
        nfloat PixelOne { get; }

        // +(void)inspectContextSize:(CGSize)size;
        [Static]
        [Export("inspectContextSize:")]
        void InspectContextSize(CGSize size);

        // +(void)inspectContextIfInvalidatedInDebugMode:(CGContextRef _Nonnull)context;
        [Static]
        [Export("inspectContextIfInvalidatedInDebugMode:")]
        void InspectContextIfInvalidatedInDebugMode(CGContextRef context);

        // +(BOOL)inspectContextIfInvalidatedInReleaseMode:(CGContextRef _Nonnull)context;
        [Static]
        [Export("inspectContextIfInvalidatedInReleaseMode:")]
        bool InspectContextIfInvalidatedInReleaseMode(CGContextRef context);
    }

    // @interface Device (QMUIHelper)
    [Category]
    [BaseType(typeof(QMUIHelper))]
    interface QMUIHelper_Device
    {
        // @property (readonly, nonatomic, class) NSString * _Nonnull deviceModel;
        [Static]
        [Export("deviceModel")]
        string DeviceModel { get; }

        // @property (readonly, nonatomic, class) NSString * _Nonnull deviceName;
        [Static]
        [Export("deviceName")]
        string DeviceName { get; }

        // @property (readonly, nonatomic, class) BOOL isIPad;
        [Static]
        [Export("isIPad")]
        bool IsIPad { get; }

        // @property (readonly, nonatomic, class) BOOL isIPod;
        [Static]
        [Export("isIPod")]
        bool IsIPod { get; }

        // @property (readonly, nonatomic, class) BOOL isIPhone;
        [Static]
        [Export("isIPhone")]
        bool IsIPhone { get; }

        // @property (readonly, nonatomic, class) BOOL isSimulator;
        [Static]
        [Export("isSimulator")]
        bool IsSimulator { get; }

        // @property (readonly, nonatomic, class) BOOL isMac;
        [Static]
        [Export("isMac")]
        bool IsMac { get; }

        // @property (readonly, nonatomic, class) BOOL isNotchedScreen;
        [Static]
        [Export("isNotchedScreen")]
        bool IsNotchedScreen { get; }

        // @property (readonly, nonatomic, class) BOOL isRegularScreen;
        [Static]
        [Export("isRegularScreen")]
        bool IsRegularScreen { get; }

        // @property (readonly, nonatomic, class) BOOL is67InchScreen;
        [Static]
        [Export("is67InchScreen")]
        bool Is67InchScreen { get; }

        // @property (readonly, nonatomic, class) BOOL is65InchScreen;
        [Static]
        [Export("is65InchScreen")]
        bool Is65InchScreen { get; }

        // @property (readonly, nonatomic, class) BOOL is61InchScreenAndiPhone12;
        [Static]
        [Export("is61InchScreenAndiPhone12")]
        bool Is61InchScreenAndiPhone12 { get; }

        // @property (readonly, nonatomic, class) BOOL is61InchScreen;
        [Static]
        [Export("is61InchScreen")]
        bool Is61InchScreen { get; }

        // @property (readonly, nonatomic, class) BOOL is58InchScreen;
        [Static]
        [Export("is58InchScreen")]
        bool Is58InchScreen { get; }

        // @property (readonly, nonatomic, class) BOOL is55InchScreen;
        [Static]
        [Export("is55InchScreen")]
        bool Is55InchScreen { get; }

        // @property (readonly, nonatomic, class) BOOL is54InchScreen;
        [Static]
        [Export("is54InchScreen")]
        bool Is54InchScreen { get; }

        // @property (readonly, nonatomic, class) BOOL is47InchScreen;
        [Static]
        [Export("is47InchScreen")]
        bool Is47InchScreen { get; }

        // @property (readonly, nonatomic, class) BOOL is40InchScreen;
        [Static]
        [Export("is40InchScreen")]
        bool Is40InchScreen { get; }

        // @property (readonly, nonatomic, class) BOOL is35InchScreen;
        [Static]
        [Export("is35InchScreen")]
        bool Is35InchScreen { get; }

        // @property (readonly, nonatomic, class) CGSize screenSizeFor67Inch;
        [Static]
        [Export("screenSizeFor67Inch")]
        CGSize ScreenSizeFor67Inch { get; }

        // @property (readonly, nonatomic, class) CGSize screenSizeFor65Inch;
        [Static]
        [Export("screenSizeFor65Inch")]
        CGSize ScreenSizeFor65Inch { get; }

        // @property (readonly, nonatomic, class) CGSize screenSizeFor61InchAndiPhone12;
        [Static]
        [Export("screenSizeFor61InchAndiPhone12")]
        CGSize ScreenSizeFor61InchAndiPhone12 { get; }

        // @property (readonly, nonatomic, class) CGSize screenSizeFor61Inch;
        [Static]
        [Export("screenSizeFor61Inch")]
        CGSize ScreenSizeFor61Inch { get; }

        // @property (readonly, nonatomic, class) CGSize screenSizeFor58Inch;
        [Static]
        [Export("screenSizeFor58Inch")]
        CGSize ScreenSizeFor58Inch { get; }

        // @property (readonly, nonatomic, class) CGSize screenSizeFor55Inch;
        [Static]
        [Export("screenSizeFor55Inch")]
        CGSize ScreenSizeFor55Inch { get; }

        // @property (readonly, nonatomic, class) CGSize screenSizeFor54Inch;
        [Static]
        [Export("screenSizeFor54Inch")]
        CGSize ScreenSizeFor54Inch { get; }

        // @property (readonly, nonatomic, class) CGSize screenSizeFor47Inch;
        [Static]
        [Export("screenSizeFor47Inch")]
        CGSize ScreenSizeFor47Inch { get; }

        // @property (readonly, nonatomic, class) CGSize screenSizeFor40Inch;
        [Static]
        [Export("screenSizeFor40Inch")]
        CGSize ScreenSizeFor40Inch { get; }

        // @property (readonly, nonatomic, class) CGSize screenSizeFor35Inch;
        [Static]
        [Export("screenSizeFor35Inch")]
        CGSize ScreenSizeFor35Inch { get; }

        // @property (readonly, nonatomic, class) CGFloat preferredLayoutAsSimilarScreenWidthForIPad;
        [Static]
        [Export("preferredLayoutAsSimilarScreenWidthForIPad")]
        nfloat PreferredLayoutAsSimilarScreenWidthForIPad { get; }

        // @property (readonly, nonatomic, class) UIEdgeInsets safeAreaInsetsForDeviceWithNotch;
        [Static]
        [Export("safeAreaInsetsForDeviceWithNotch")]
        UIEdgeInsets SafeAreaInsetsForDeviceWithNotch { get; }

        // @property (readonly, nonatomic, class) BOOL isHighPerformanceDevice;
        [Static]
        [Export("isHighPerformanceDevice")]
        bool IsHighPerformanceDevice { get; }

        // @property (readonly, nonatomic, class) BOOL isZoomedMode;
        [Static]
        [Export("isZoomedMode")]
        bool IsZoomedMode { get; }

        // @property (readonly, nonatomic, class) CGSize applicationSize;
        [Static]
        [Export("applicationSize")]
        CGSize ApplicationSize { get; }
    }

    // @interface UIApplication (QMUIHelper)
    [Category]
    [BaseType(typeof(QMUIHelper))]
    interface QMUIHelper_UIApplication
    {
        // +(void)dimmedApplicationWindow;
        [Static]
        [Export("dimmedApplicationWindow")]
        void DimmedApplicationWindow();

        // +(void)resetDimmedApplicationWindow;
        [Static]
        [Export("resetDimmedApplicationWindow")]
        void ResetDimmedApplicationWindow();

        // @property (readonly, nonatomic, class) UIStatusBarStyle statusBarStyleDarkContent;
        [Static]
        [Export("statusBarStyleDarkContent")]
        UIStatusBarStyle StatusBarStyleDarkContent { get; }
    }

    // @interface Animation (QMUIHelper)
    [Category]
    [BaseType(typeof(QMUIHelper))]
    interface QMUIHelper_Animation
    {
        // +(void)executeAnimationBlock:(void (^ _Nonnull)(void))animationBlock completionBlock:(void (^ _Nullable)(void))completionBlock;
        [Static]
        [Export("executeAnimationBlock:completionBlock:")]
        void ExecuteAnimationBlock(Action animationBlock, [NullAllowed] Action completionBlock);
    }

    // @interface QMUILogItem : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUILogItem
    {
        // @property (assign, nonatomic) QMUILogLevel level;
        [Export("level", ArgumentSemantic.Assign)]
        QMUILogLevel Level { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull levelDisplayString;
        [Export("levelDisplayString")]
        string LevelDisplayString { get; }

        // @property (copy, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull logString;
        [Export("logString")]
        string LogString { get; set; }

        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // +(instancetype _Nonnull)logItemWithLevel:(QMUILogLevel)level name:(NSString * _Nullable)name logString:(NSString * _Nonnull)logString, ... __attribute__((format(NSString, 3, 4)));
        [Static, Internal]
        [Export("logItemWithLevel:name:logString:", IsVariadic = true)]
        QMUILogItem LogItemWithLevel(QMUILogLevel level, [NullAllowed] string name, string logString, IntPtr varArgs);
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull QMUILoggerAllNamesKeyInUserDefaults;
        [Field("QMUILoggerAllNamesKeyInUserDefaults", "__Internal")]
        NSString QMUILoggerAllNamesKeyInUserDefaults { get; }
    }

    // @interface QMUILogNameManager : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUILogNameManager
    {
        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSNumber *> * _Nullable allNames;
        [NullAllowed, Export("allNames", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSNumber> AllNames { get; }

        // -(BOOL)containsLogName:(NSString * _Nullable)logName;
        [Export("containsLogName:")]
        bool ContainsLogName([NullAllowed] string logName);

        // -(void)setEnabled:(BOOL)enabled forLogName:(NSString * _Nullable)logName;
        [Export("setEnabled:forLogName:")]
        void SetEnabled(bool enabled, [NullAllowed] string logName);

        // -(BOOL)enabledForLogName:(NSString * _Nullable)logName;
        [Export("enabledForLogName:")]
        bool EnabledForLogName([NullAllowed] string logName);

        // -(void)removeLogName:(NSString * _Nullable)logName;
        [Export("removeLogName:")]
        void RemoveLogName([NullAllowed] string logName);

        // -(void)removeAllNames;
        [Export("removeAllNames")]
        void RemoveAllNames();
    }

    // @protocol QMUILoggerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUILoggerDelegate
    {
        // @optional -(void)printQMUILogWithFile:(NSString * _Nonnull)file line:(int)line func:(NSString * _Nullable)func logItem:(QMUILogItem * _Nullable)logItem defaultString:(NSString * _Nullable)defaultString;
        [Export("printQMUILogWithFile:line:func:logItem:defaultString:")]
        void PrintQMUILogWithFile(string file, int line, [NullAllowed] string func, [NullAllowed] QMUILogItem logItem, [NullAllowed] string defaultString);

        // @optional -(void)QMUILogName:(NSString * _Nonnull)logName didChangeEnabled:(BOOL)enabled;
        [Export("QMUILogName:didChangeEnabled:")]
        void QMUILogName(string logName, bool enabled);

        // @optional -(void)QMUILogNameDidRemove:(NSString * _Nonnull)logName;
        [Export("QMUILogNameDidRemove:")]
        void QMUILogNameDidRemove(string logName);
    }

    // @interface QMUILogger : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUILogger
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        QMUILoggerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<QMUILoggerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) QMUILogNameManager * _Nonnull logNameManager;
        [Export("logNameManager", ArgumentSemantic.Strong)]
        QMUILogNameManager LogNameManager { get; set; }

        // +(instancetype _Nonnull)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        QMUILogger SharedInstance();

        // -(void)printLogWithFile:(const char * _Nullable)file line:(int)line func:(const char * _Nonnull)func logItem:(QMUILogItem * _Nullable)logItem;
        [Export("printLogWithFile:line:func:logItem:")]
        unsafe void PrintLogWithFile([NullAllowed] sbyte* file, int line, sbyte* func, [NullAllowed] QMUILogItem logItem);
    }

    // @interface QMUIPropertyDescriptor : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIPropertyDescriptor
    {
        // @property (nonatomic, strong) NSString * name;
        [Export("name", ArgumentSemantic.Strong)]
        string Name { get; set; }

        // @property (assign, nonatomic) SEL getter;
        [Export("getter", ArgumentSemantic.Assign)]
        Selector Getter { get; set; }

        // @property (assign, nonatomic) SEL setter;
        [Export("setter", ArgumentSemantic.Assign)]
        Selector Setter { get; set; }

        // @property (assign, nonatomic) BOOL isAtomic;
        [Export("isAtomic")]
        bool IsAtomic { get; set; }

        // @property (assign, nonatomic) BOOL isNonatomic;
        [Export("isNonatomic")]
        bool IsNonatomic { get; set; }

        // @property (assign, nonatomic) BOOL isAssign;
        [Export("isAssign")]
        bool IsAssign { get; set; }

        // @property (assign, nonatomic) BOOL isWeak;
        [Export("isWeak")]
        bool IsWeak { get; set; }

        // @property (assign, nonatomic) BOOL isStrong;
        [Export("isStrong")]
        bool IsStrong { get; set; }

        // @property (assign, nonatomic) BOOL isCopy;
        [Export("isCopy")]
        bool IsCopy { get; set; }

        // @property (assign, nonatomic) BOOL isReadonly;
        [Export("isReadonly")]
        bool IsReadonly { get; set; }

        // @property (assign, nonatomic) BOOL isReadwrite;
        [Export("isReadwrite")]
        bool IsReadwrite { get; set; }

        // @property (copy, nonatomic) NSString * type;
        [Export("type")]
        string Type { get; set; }

        // +(instancetype)descriptorWithProperty:(objc_property_t)property;
        [Static]
        [Export("descriptorWithProperty:")]
        QMUIPropertyDescriptor DescriptorWithProperty(objc_property_t property);
    }

    // @interface QMUIWeakObjectContainer : NSProxy
    [BaseType(typeof(NSProxy))]
    interface QMUIWeakObjectContainer
    {
        // -(instancetype _Nonnull)initWithObject:(id _Nonnull)object;
        [Export("initWithObject:")]
        IntPtr Constructor(NSObject @object);

        // +(instancetype _Nonnull)containerWithObject:(id _Nonnull)object;
        [Static]
        [Export("containerWithObject:")]
        QMUIWeakObjectContainer ContainerWithObject(NSObject @object);

        // @property (nonatomic, weak) id _Nullable object;
        [NullAllowed, Export("object", ArgumentSemantic.Weak)]
        NSObject Object { get; set; }
    }

    // @protocol QMUIConfigurationTemplateProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIConfigurationTemplateProtocol
    {
        // @required -(void)applyConfigurationTemplate;
        [Abstract]
        [Export("applyConfigurationTemplate")]
        void ApplyConfigurationTemplate();

        // @optional -(BOOL)shouldApplyTemplateAutomatically;
        [Export("shouldApplyTemplateAutomatically")]
        [Verify(MethodToProperty)]
        bool ShouldApplyTemplateAutomatically { get; }
    }

    // @interface QMUIConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIConfiguration
    {
        // @property (readonly, assign, nonatomic) BOOL active;
        [Export("active")]
        bool Active { get; }

        // @property (nonatomic, strong) UIColor * _Nonnull clearColor;
        [Export("clearColor", ArgumentSemantic.Strong)]
        UIColor ClearColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull whiteColor;
        [Export("whiteColor", ArgumentSemantic.Strong)]
        UIColor WhiteColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull blackColor;
        [Export("blackColor", ArgumentSemantic.Strong)]
        UIColor BlackColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull grayColor;
        [Export("grayColor", ArgumentSemantic.Strong)]
        UIColor GrayColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull grayDarkenColor;
        [Export("grayDarkenColor", ArgumentSemantic.Strong)]
        UIColor GrayDarkenColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull grayLightenColor;
        [Export("grayLightenColor", ArgumentSemantic.Strong)]
        UIColor GrayLightenColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull redColor;
        [Export("redColor", ArgumentSemantic.Strong)]
        UIColor RedColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull greenColor;
        [Export("greenColor", ArgumentSemantic.Strong)]
        UIColor GreenColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull blueColor;
        [Export("blueColor", ArgumentSemantic.Strong)]
        UIColor BlueColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull yellowColor;
        [Export("yellowColor", ArgumentSemantic.Strong)]
        UIColor YellowColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull linkColor;
        [Export("linkColor", ArgumentSemantic.Strong)]
        UIColor LinkColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull disabledColor;
        [Export("disabledColor", ArgumentSemantic.Strong)]
        UIColor DisabledColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
        [NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull maskDarkColor;
        [Export("maskDarkColor", ArgumentSemantic.Strong)]
        UIColor MaskDarkColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull maskLightColor;
        [Export("maskLightColor", ArgumentSemantic.Strong)]
        UIColor MaskLightColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull separatorColor;
        [Export("separatorColor", ArgumentSemantic.Strong)]
        UIColor SeparatorColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull separatorDashedColor;
        [Export("separatorDashedColor", ArgumentSemantic.Strong)]
        UIColor SeparatorDashedColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull placeholderColor;
        [Export("placeholderColor", ArgumentSemantic.Strong)]
        UIColor PlaceholderColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull testColorRed;
        [Export("testColorRed", ArgumentSemantic.Strong)]
        UIColor TestColorRed { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull testColorGreen;
        [Export("testColorGreen", ArgumentSemantic.Strong)]
        UIColor TestColorGreen { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull testColorBlue;
        [Export("testColorBlue", ArgumentSemantic.Strong)]
        UIColor TestColorBlue { get; set; }

        // @property (assign, nonatomic) CGFloat controlHighlightedAlpha;
        [Export("controlHighlightedAlpha")]
        nfloat ControlHighlightedAlpha { get; set; }

        // @property (assign, nonatomic) CGFloat controlDisabledAlpha;
        [Export("controlDisabledAlpha")]
        nfloat ControlDisabledAlpha { get; set; }

        // @property (assign, nonatomic) CGFloat buttonHighlightedAlpha;
        [Export("buttonHighlightedAlpha")]
        nfloat ButtonHighlightedAlpha { get; set; }

        // @property (assign, nonatomic) CGFloat buttonDisabledAlpha;
        [Export("buttonDisabledAlpha")]
        nfloat ButtonDisabledAlpha { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable buttonTintColor;
        [NullAllowed, Export("buttonTintColor", ArgumentSemantic.Strong)]
        UIColor ButtonTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull ghostButtonColorBlue;
        [Export("ghostButtonColorBlue", ArgumentSemantic.Strong)]
        UIColor GhostButtonColorBlue { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull ghostButtonColorRed;
        [Export("ghostButtonColorRed", ArgumentSemantic.Strong)]
        UIColor GhostButtonColorRed { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull ghostButtonColorGreen;
        [Export("ghostButtonColorGreen", ArgumentSemantic.Strong)]
        UIColor GhostButtonColorGreen { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull ghostButtonColorGray;
        [Export("ghostButtonColorGray", ArgumentSemantic.Strong)]
        UIColor GhostButtonColorGray { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull ghostButtonColorWhite;
        [Export("ghostButtonColorWhite", ArgumentSemantic.Strong)]
        UIColor GhostButtonColorWhite { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull fillButtonColorBlue;
        [Export("fillButtonColorBlue", ArgumentSemantic.Strong)]
        UIColor FillButtonColorBlue { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull fillButtonColorRed;
        [Export("fillButtonColorRed", ArgumentSemantic.Strong)]
        UIColor FillButtonColorRed { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull fillButtonColorGreen;
        [Export("fillButtonColorGreen", ArgumentSemantic.Strong)]
        UIColor FillButtonColorGreen { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull fillButtonColorGray;
        [Export("fillButtonColorGray", ArgumentSemantic.Strong)]
        UIColor FillButtonColorGray { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull fillButtonColorWhite;
        [Export("fillButtonColorWhite", ArgumentSemantic.Strong)]
        UIColor FillButtonColorWhite { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable textFieldTextColor;
        [NullAllowed, Export("textFieldTextColor", ArgumentSemantic.Strong)]
        UIColor TextFieldTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable textFieldTintColor;
        [NullAllowed, Export("textFieldTintColor", ArgumentSemantic.Strong)]
        UIColor TextFieldTintColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets textFieldTextInsets;
        [Export("textFieldTextInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets TextFieldTextInsets { get; set; }

        // @property (assign, nonatomic) UIKeyboardAppearance keyboardAppearance;
        [Export("keyboardAppearance", ArgumentSemantic.Assign)]
        UIKeyboardAppearance KeyboardAppearance { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable switchOnTintColor;
        [NullAllowed, Export("switchOnTintColor", ArgumentSemantic.Strong)]
        UIColor SwitchOnTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable switchOffTintColor;
        [NullAllowed, Export("switchOffTintColor", ArgumentSemantic.Strong)]
        UIColor SwitchOffTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable switchTintColor;
        [NullAllowed, Export("switchTintColor", ArgumentSemantic.Strong)]
        UIColor SwitchTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable switchThumbTintColor;
        [NullAllowed, Export("switchThumbTintColor", ArgumentSemantic.Strong)]
        UIColor SwitchThumbTintColor { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable switchOnImage;
        [NullAllowed, Export("switchOnImage", ArgumentSemantic.Strong)]
        UIImage SwitchOnImage { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable switchOffImage;
        [NullAllowed, Export("switchOffImage", ArgumentSemantic.Strong)]
        UIImage SwitchOffImage { get; set; }

        // @property (copy, nonatomic) NSArray<Class<UIAppearanceContainer>> * _Nullable navBarContainerClasses;
        [NullAllowed, Export("navBarContainerClasses", ArgumentSemantic.Copy)]
        UIAppearanceContainer[] NavBarContainerClasses { get; set; }

        // @property (assign, nonatomic) CGFloat navBarHighlightedAlpha;
        [Export("navBarHighlightedAlpha")]
        nfloat NavBarHighlightedAlpha { get; set; }

        // @property (assign, nonatomic) CGFloat navBarDisabledAlpha;
        [Export("navBarDisabledAlpha")]
        nfloat NavBarDisabledAlpha { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable navBarButtonFont;
        [NullAllowed, Export("navBarButtonFont", ArgumentSemantic.Strong)]
        UIFont NavBarButtonFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable navBarButtonFontBold;
        [NullAllowed, Export("navBarButtonFontBold", ArgumentSemantic.Strong)]
        UIFont NavBarButtonFontBold { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable navBarBackgroundImage;
        [NullAllowed, Export("navBarBackgroundImage", ArgumentSemantic.Strong)]
        UIImage NavBarBackgroundImage { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable navBarShadowImage;
        [NullAllowed, Export("navBarShadowImage", ArgumentSemantic.Strong)]
        UIImage NavBarShadowImage { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable navBarShadowImageColor;
        [NullAllowed, Export("navBarShadowImageColor", ArgumentSemantic.Strong)]
        UIColor NavBarShadowImageColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable navBarBarTintColor;
        [NullAllowed, Export("navBarBarTintColor", ArgumentSemantic.Strong)]
        UIColor NavBarBarTintColor { get; set; }

        // @property (assign, nonatomic) UIBarStyle navBarStyle;
        [Export("navBarStyle", ArgumentSemantic.Assign)]
        UIBarStyle NavBarStyle { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable navBarTintColor;
        [NullAllowed, Export("navBarTintColor", ArgumentSemantic.Strong)]
        UIColor NavBarTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable navBarTitleColor;
        [NullAllowed, Export("navBarTitleColor", ArgumentSemantic.Strong)]
        UIColor NavBarTitleColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable navBarTitleFont;
        [NullAllowed, Export("navBarTitleFont", ArgumentSemantic.Strong)]
        UIFont NavBarTitleFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable navBarLargeTitleColor;
        [NullAllowed, Export("navBarLargeTitleColor", ArgumentSemantic.Strong)]
        UIColor NavBarLargeTitleColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable navBarLargeTitleFont;
        [NullAllowed, Export("navBarLargeTitleFont", ArgumentSemantic.Strong)]
        UIFont NavBarLargeTitleFont { get; set; }

        // @property (assign, nonatomic) UIOffset navBarBackButtonTitlePositionAdjustment;
        [Export("navBarBackButtonTitlePositionAdjustment", ArgumentSemantic.Assign)]
        UIOffset NavBarBackButtonTitlePositionAdjustment { get; set; }

        // @property (assign, nonatomic) BOOL sizeNavBarBackIndicatorImageAutomatically;
        [Export("sizeNavBarBackIndicatorImageAutomatically")]
        bool SizeNavBarBackIndicatorImageAutomatically { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable navBarBackIndicatorImage;
        [NullAllowed, Export("navBarBackIndicatorImage", ArgumentSemantic.Strong)]
        UIImage NavBarBackIndicatorImage { get; set; }

        // @property (nonatomic, strong) UIImage * _Nonnull navBarCloseButtonImage;
        [Export("navBarCloseButtonImage", ArgumentSemantic.Strong)]
        UIImage NavBarCloseButtonImage { get; set; }

        // @property (assign, nonatomic) CGFloat navBarLoadingMarginRight;
        [Export("navBarLoadingMarginRight")]
        nfloat NavBarLoadingMarginRight { get; set; }

        // @property (assign, nonatomic) CGFloat navBarAccessoryViewMarginLeft;
        [Export("navBarAccessoryViewMarginLeft")]
        nfloat NavBarAccessoryViewMarginLeft { get; set; }

        // @property (assign, nonatomic) UIActivityIndicatorViewStyle navBarActivityIndicatorViewStyle;
        [Export("navBarActivityIndicatorViewStyle", ArgumentSemantic.Assign)]
        UIActivityIndicatorViewStyle NavBarActivityIndicatorViewStyle { get; set; }

        // @property (nonatomic, strong) UIImage * _Nonnull navBarAccessoryViewTypeDisclosureIndicatorImage;
        [Export("navBarAccessoryViewTypeDisclosureIndicatorImage", ArgumentSemantic.Strong)]
        UIImage NavBarAccessoryViewTypeDisclosureIndicatorImage { get; set; }

        // @property (copy, nonatomic) NSArray<Class<UIAppearanceContainer>> * _Nullable tabBarContainerClasses;
        [NullAllowed, Export("tabBarContainerClasses", ArgumentSemantic.Copy)]
        UIAppearanceContainer[] TabBarContainerClasses { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable tabBarBackgroundImage;
        [NullAllowed, Export("tabBarBackgroundImage", ArgumentSemantic.Strong)]
        UIImage TabBarBackgroundImage { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tabBarBarTintColor;
        [NullAllowed, Export("tabBarBarTintColor", ArgumentSemantic.Strong)]
        UIColor TabBarBarTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tabBarShadowImageColor;
        [NullAllowed, Export("tabBarShadowImageColor", ArgumentSemantic.Strong)]
        UIColor TabBarShadowImageColor { get; set; }

        // @property (assign, nonatomic) UIBarStyle tabBarStyle;
        [Export("tabBarStyle", ArgumentSemantic.Assign)]
        UIBarStyle TabBarStyle { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable tabBarItemTitleFont;
        [NullAllowed, Export("tabBarItemTitleFont", ArgumentSemantic.Strong)]
        UIFont TabBarItemTitleFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable tabBarItemTitleFontSelected;
        [NullAllowed, Export("tabBarItemTitleFontSelected", ArgumentSemantic.Strong)]
        UIFont TabBarItemTitleFontSelected { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tabBarItemTitleColor;
        [NullAllowed, Export("tabBarItemTitleColor", ArgumentSemantic.Strong)]
        UIColor TabBarItemTitleColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tabBarItemTitleColorSelected;
        [NullAllowed, Export("tabBarItemTitleColorSelected", ArgumentSemantic.Strong)]
        UIColor TabBarItemTitleColorSelected { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tabBarItemImageColor;
        [NullAllowed, Export("tabBarItemImageColor", ArgumentSemantic.Strong)]
        UIColor TabBarItemImageColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tabBarItemImageColorSelected;
        [NullAllowed, Export("tabBarItemImageColorSelected", ArgumentSemantic.Strong)]
        UIColor TabBarItemImageColorSelected { get; set; }

        // @property (copy, nonatomic) NSArray<Class<UIAppearanceContainer>> * _Nullable toolBarContainerClasses;
        [NullAllowed, Export("toolBarContainerClasses", ArgumentSemantic.Copy)]
        UIAppearanceContainer[] ToolBarContainerClasses { get; set; }

        // @property (assign, nonatomic) CGFloat toolBarHighlightedAlpha;
        [Export("toolBarHighlightedAlpha")]
        nfloat ToolBarHighlightedAlpha { get; set; }

        // @property (assign, nonatomic) CGFloat toolBarDisabledAlpha;
        [Export("toolBarDisabledAlpha")]
        nfloat ToolBarDisabledAlpha { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable toolBarTintColor;
        [NullAllowed, Export("toolBarTintColor", ArgumentSemantic.Strong)]
        UIColor ToolBarTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable toolBarTintColorHighlighted;
        [NullAllowed, Export("toolBarTintColorHighlighted", ArgumentSemantic.Strong)]
        UIColor ToolBarTintColorHighlighted { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable toolBarTintColorDisabled;
        [NullAllowed, Export("toolBarTintColorDisabled", ArgumentSemantic.Strong)]
        UIColor ToolBarTintColorDisabled { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable toolBarBackgroundImage;
        [NullAllowed, Export("toolBarBackgroundImage", ArgumentSemantic.Strong)]
        UIImage ToolBarBackgroundImage { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable toolBarBarTintColor;
        [NullAllowed, Export("toolBarBarTintColor", ArgumentSemantic.Strong)]
        UIColor ToolBarBarTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable toolBarShadowImageColor;
        [NullAllowed, Export("toolBarShadowImageColor", ArgumentSemantic.Strong)]
        UIColor ToolBarShadowImageColor { get; set; }

        // @property (assign, nonatomic) UIBarStyle toolBarStyle;
        [Export("toolBarStyle", ArgumentSemantic.Assign)]
        UIBarStyle ToolBarStyle { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable toolBarButtonFont;
        [NullAllowed, Export("toolBarButtonFont", ArgumentSemantic.Strong)]
        UIFont ToolBarButtonFont { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable searchBarTextFieldBackgroundImage;
        [NullAllowed, Export("searchBarTextFieldBackgroundImage", ArgumentSemantic.Strong)]
        UIImage SearchBarTextFieldBackgroundImage { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable searchBarTextFieldBorderColor;
        [NullAllowed, Export("searchBarTextFieldBorderColor", ArgumentSemantic.Strong)]
        UIColor SearchBarTextFieldBorderColor { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable searchBarBackgroundImage;
        [NullAllowed, Export("searchBarBackgroundImage", ArgumentSemantic.Strong)]
        UIImage SearchBarBackgroundImage { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable searchBarTintColor;
        [NullAllowed, Export("searchBarTintColor", ArgumentSemantic.Strong)]
        UIColor SearchBarTintColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable searchBarTextColor;
        [NullAllowed, Export("searchBarTextColor", ArgumentSemantic.Strong)]
        UIColor SearchBarTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable searchBarPlaceholderColor;
        [NullAllowed, Export("searchBarPlaceholderColor", ArgumentSemantic.Strong)]
        UIColor SearchBarPlaceholderColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable searchBarFont;
        [NullAllowed, Export("searchBarFont", ArgumentSemantic.Strong)]
        UIFont SearchBarFont { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable searchBarSearchIconImage;
        [NullAllowed, Export("searchBarSearchIconImage", ArgumentSemantic.Strong)]
        UIImage SearchBarSearchIconImage { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable searchBarClearIconImage;
        [NullAllowed, Export("searchBarClearIconImage", ArgumentSemantic.Strong)]
        UIImage SearchBarClearIconImage { get; set; }

        // @property (assign, nonatomic) CGFloat searchBarTextFieldCornerRadius;
        [Export("searchBarTextFieldCornerRadius")]
        nfloat SearchBarTextFieldCornerRadius { get; set; }

        // @property (assign, nonatomic) BOOL tableViewEstimatedHeightEnabled;
        [Export("tableViewEstimatedHeightEnabled")]
        bool TableViewEstimatedHeightEnabled { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewBackgroundColor;
        [NullAllowed, Export("tableViewBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TableViewBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableSectionIndexColor;
        [NullAllowed, Export("tableSectionIndexColor", ArgumentSemantic.Strong)]
        UIColor TableSectionIndexColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableSectionIndexBackgroundColor;
        [NullAllowed, Export("tableSectionIndexBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TableSectionIndexBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableSectionIndexTrackingBackgroundColor;
        [NullAllowed, Export("tableSectionIndexTrackingBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TableSectionIndexTrackingBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewSeparatorColor;
        [NullAllowed, Export("tableViewSeparatorColor", ArgumentSemantic.Strong)]
        UIColor TableViewSeparatorColor { get; set; }

        // @property (assign, nonatomic) CGFloat tableViewCellNormalHeight;
        [Export("tableViewCellNormalHeight")]
        nfloat TableViewCellNormalHeight { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewCellTitleLabelColor;
        [NullAllowed, Export("tableViewCellTitleLabelColor", ArgumentSemantic.Strong)]
        UIColor TableViewCellTitleLabelColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewCellDetailLabelColor;
        [NullAllowed, Export("tableViewCellDetailLabelColor", ArgumentSemantic.Strong)]
        UIColor TableViewCellDetailLabelColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewCellBackgroundColor;
        [NullAllowed, Export("tableViewCellBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TableViewCellBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewCellSelectedBackgroundColor;
        [NullAllowed, Export("tableViewCellSelectedBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TableViewCellSelectedBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewCellWarningBackgroundColor;
        [NullAllowed, Export("tableViewCellWarningBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TableViewCellWarningBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable tableViewCellDisclosureIndicatorImage;
        [NullAllowed, Export("tableViewCellDisclosureIndicatorImage", ArgumentSemantic.Strong)]
        UIImage TableViewCellDisclosureIndicatorImage { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable tableViewCellCheckmarkImage;
        [NullAllowed, Export("tableViewCellCheckmarkImage", ArgumentSemantic.Strong)]
        UIImage TableViewCellCheckmarkImage { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable tableViewCellDetailButtonImage;
        [NullAllowed, Export("tableViewCellDetailButtonImage", ArgumentSemantic.Strong)]
        UIImage TableViewCellDetailButtonImage { get; set; }

        // @property (assign, nonatomic) CGFloat tableViewCellSpacingBetweenDetailButtonAndDisclosureIndicator;
        [Export("tableViewCellSpacingBetweenDetailButtonAndDisclosureIndicator")]
        nfloat TableViewCellSpacingBetweenDetailButtonAndDisclosureIndicator { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewSectionHeaderBackgroundColor;
        [NullAllowed, Export("tableViewSectionHeaderBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TableViewSectionHeaderBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewSectionFooterBackgroundColor;
        [NullAllowed, Export("tableViewSectionFooterBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TableViewSectionFooterBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable tableViewSectionHeaderFont;
        [NullAllowed, Export("tableViewSectionHeaderFont", ArgumentSemantic.Strong)]
        UIFont TableViewSectionHeaderFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable tableViewSectionFooterFont;
        [NullAllowed, Export("tableViewSectionFooterFont", ArgumentSemantic.Strong)]
        UIFont TableViewSectionFooterFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewSectionHeaderTextColor;
        [NullAllowed, Export("tableViewSectionHeaderTextColor", ArgumentSemantic.Strong)]
        UIColor TableViewSectionHeaderTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewSectionFooterTextColor;
        [NullAllowed, Export("tableViewSectionFooterTextColor", ArgumentSemantic.Strong)]
        UIColor TableViewSectionFooterTextColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets tableViewSectionHeaderAccessoryMargins;
        [Export("tableViewSectionHeaderAccessoryMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets TableViewSectionHeaderAccessoryMargins { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets tableViewSectionFooterAccessoryMargins;
        [Export("tableViewSectionFooterAccessoryMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets TableViewSectionFooterAccessoryMargins { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets tableViewSectionHeaderContentInset;
        [Export("tableViewSectionHeaderContentInset", ArgumentSemantic.Assign)]
        UIEdgeInsets TableViewSectionHeaderContentInset { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets tableViewSectionFooterContentInset;
        [Export("tableViewSectionFooterContentInset", ArgumentSemantic.Assign)]
        UIEdgeInsets TableViewSectionFooterContentInset { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewGroupedBackgroundColor;
        [NullAllowed, Export("tableViewGroupedBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TableViewGroupedBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewGroupedSeparatorColor;
        [NullAllowed, Export("tableViewGroupedSeparatorColor", ArgumentSemantic.Strong)]
        UIColor TableViewGroupedSeparatorColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewGroupedCellTitleLabelColor;
        [NullAllowed, Export("tableViewGroupedCellTitleLabelColor", ArgumentSemantic.Strong)]
        UIColor TableViewGroupedCellTitleLabelColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewGroupedCellDetailLabelColor;
        [NullAllowed, Export("tableViewGroupedCellDetailLabelColor", ArgumentSemantic.Strong)]
        UIColor TableViewGroupedCellDetailLabelColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewGroupedCellBackgroundColor;
        [NullAllowed, Export("tableViewGroupedCellBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TableViewGroupedCellBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewGroupedCellSelectedBackgroundColor;
        [NullAllowed, Export("tableViewGroupedCellSelectedBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TableViewGroupedCellSelectedBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewGroupedCellWarningBackgroundColor;
        [NullAllowed, Export("tableViewGroupedCellWarningBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TableViewGroupedCellWarningBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable tableViewGroupedSectionHeaderFont;
        [NullAllowed, Export("tableViewGroupedSectionHeaderFont", ArgumentSemantic.Strong)]
        UIFont TableViewGroupedSectionHeaderFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable tableViewGroupedSectionFooterFont;
        [NullAllowed, Export("tableViewGroupedSectionFooterFont", ArgumentSemantic.Strong)]
        UIFont TableViewGroupedSectionFooterFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewGroupedSectionHeaderTextColor;
        [NullAllowed, Export("tableViewGroupedSectionHeaderTextColor", ArgumentSemantic.Strong)]
        UIColor TableViewGroupedSectionHeaderTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewGroupedSectionFooterTextColor;
        [NullAllowed, Export("tableViewGroupedSectionFooterTextColor", ArgumentSemantic.Strong)]
        UIColor TableViewGroupedSectionFooterTextColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets tableViewGroupedSectionHeaderAccessoryMargins;
        [Export("tableViewGroupedSectionHeaderAccessoryMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets TableViewGroupedSectionHeaderAccessoryMargins { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets tableViewGroupedSectionFooterAccessoryMargins;
        [Export("tableViewGroupedSectionFooterAccessoryMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets TableViewGroupedSectionFooterAccessoryMargins { get; set; }

        // @property (assign, nonatomic) CGFloat tableViewGroupedSectionHeaderDefaultHeight;
        [Export("tableViewGroupedSectionHeaderDefaultHeight")]
        nfloat TableViewGroupedSectionHeaderDefaultHeight { get; set; }

        // @property (assign, nonatomic) CGFloat tableViewGroupedSectionFooterDefaultHeight;
        [Export("tableViewGroupedSectionFooterDefaultHeight")]
        nfloat TableViewGroupedSectionFooterDefaultHeight { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets tableViewGroupedSectionHeaderContentInset;
        [Export("tableViewGroupedSectionHeaderContentInset", ArgumentSemantic.Assign)]
        UIEdgeInsets TableViewGroupedSectionHeaderContentInset { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets tableViewGroupedSectionFooterContentInset;
        [Export("tableViewGroupedSectionFooterContentInset", ArgumentSemantic.Assign)]
        UIEdgeInsets TableViewGroupedSectionFooterContentInset { get; set; }

        // @property (assign, nonatomic) CGFloat tableViewInsetGroupedCornerRadius;
        [Export("tableViewInsetGroupedCornerRadius")]
        nfloat TableViewInsetGroupedCornerRadius { get; set; }

        // @property (assign, nonatomic) CGFloat tableViewInsetGroupedHorizontalInset;
        [Export("tableViewInsetGroupedHorizontalInset")]
        nfloat TableViewInsetGroupedHorizontalInset { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewInsetGroupedBackgroundColor;
        [NullAllowed, Export("tableViewInsetGroupedBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TableViewInsetGroupedBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewInsetGroupedSeparatorColor;
        [NullAllowed, Export("tableViewInsetGroupedSeparatorColor", ArgumentSemantic.Strong)]
        UIColor TableViewInsetGroupedSeparatorColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewInsetGroupedCellTitleLabelColor;
        [NullAllowed, Export("tableViewInsetGroupedCellTitleLabelColor", ArgumentSemantic.Strong)]
        UIColor TableViewInsetGroupedCellTitleLabelColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewInsetGroupedCellDetailLabelColor;
        [NullAllowed, Export("tableViewInsetGroupedCellDetailLabelColor", ArgumentSemantic.Strong)]
        UIColor TableViewInsetGroupedCellDetailLabelColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewInsetGroupedCellBackgroundColor;
        [NullAllowed, Export("tableViewInsetGroupedCellBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TableViewInsetGroupedCellBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewInsetGroupedCellSelectedBackgroundColor;
        [NullAllowed, Export("tableViewInsetGroupedCellSelectedBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TableViewInsetGroupedCellSelectedBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewInsetGroupedCellWarningBackgroundColor;
        [NullAllowed, Export("tableViewInsetGroupedCellWarningBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TableViewInsetGroupedCellWarningBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable tableViewInsetGroupedSectionHeaderFont;
        [NullAllowed, Export("tableViewInsetGroupedSectionHeaderFont", ArgumentSemantic.Strong)]
        UIFont TableViewInsetGroupedSectionHeaderFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable tableViewInsetGroupedSectionFooterFont;
        [NullAllowed, Export("tableViewInsetGroupedSectionFooterFont", ArgumentSemantic.Strong)]
        UIFont TableViewInsetGroupedSectionFooterFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewInsetGroupedSectionHeaderTextColor;
        [NullAllowed, Export("tableViewInsetGroupedSectionHeaderTextColor", ArgumentSemantic.Strong)]
        UIColor TableViewInsetGroupedSectionHeaderTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable tableViewInsetGroupedSectionFooterTextColor;
        [NullAllowed, Export("tableViewInsetGroupedSectionFooterTextColor", ArgumentSemantic.Strong)]
        UIColor TableViewInsetGroupedSectionFooterTextColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets tableViewInsetGroupedSectionHeaderAccessoryMargins;
        [Export("tableViewInsetGroupedSectionHeaderAccessoryMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets TableViewInsetGroupedSectionHeaderAccessoryMargins { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets tableViewInsetGroupedSectionFooterAccessoryMargins;
        [Export("tableViewInsetGroupedSectionFooterAccessoryMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets TableViewInsetGroupedSectionFooterAccessoryMargins { get; set; }

        // @property (assign, nonatomic) CGFloat tableViewInsetGroupedSectionHeaderDefaultHeight;
        [Export("tableViewInsetGroupedSectionHeaderDefaultHeight")]
        nfloat TableViewInsetGroupedSectionHeaderDefaultHeight { get; set; }

        // @property (assign, nonatomic) CGFloat tableViewInsetGroupedSectionFooterDefaultHeight;
        [Export("tableViewInsetGroupedSectionFooterDefaultHeight")]
        nfloat TableViewInsetGroupedSectionFooterDefaultHeight { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets tableViewInsetGroupedSectionHeaderContentInset;
        [Export("tableViewInsetGroupedSectionHeaderContentInset", ArgumentSemantic.Assign)]
        UIEdgeInsets TableViewInsetGroupedSectionHeaderContentInset { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets tableViewInsetGroupedSectionFooterContentInset;
        [Export("tableViewInsetGroupedSectionFooterContentInset", ArgumentSemantic.Assign)]
        UIEdgeInsets TableViewInsetGroupedSectionFooterContentInset { get; set; }

        // @property (assign, nonatomic) CGFloat windowLevelQMUIAlertView;
        [Export("windowLevelQMUIAlertView")]
        nfloat WindowLevelQMUIAlertView { get; set; }

        // @property (assign, nonatomic) CGFloat windowLevelQMUIConsole;
        [Export("windowLevelQMUIConsole")]
        nfloat WindowLevelQMUIConsole { get; set; }

        // @property (assign, nonatomic) BOOL shouldPrintDefaultLog;
        [Export("shouldPrintDefaultLog")]
        bool ShouldPrintDefaultLog { get; set; }

        // @property (assign, nonatomic) BOOL shouldPrintInfoLog;
        [Export("shouldPrintInfoLog")]
        bool ShouldPrintInfoLog { get; set; }

        // @property (assign, nonatomic) BOOL shouldPrintWarnLog;
        [Export("shouldPrintWarnLog")]
        bool ShouldPrintWarnLog { get; set; }

        // @property (assign, nonatomic) BOOL shouldPrintQMUIWarnLogToConsole;
        [Export("shouldPrintQMUIWarnLogToConsole")]
        bool ShouldPrintQMUIWarnLogToConsole { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable badgeBackgroundColor;
        [NullAllowed, Export("badgeBackgroundColor", ArgumentSemantic.Strong)]
        UIColor BadgeBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable badgeTextColor;
        [NullAllowed, Export("badgeTextColor", ArgumentSemantic.Strong)]
        UIColor BadgeTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable badgeFont;
        [NullAllowed, Export("badgeFont", ArgumentSemantic.Strong)]
        UIFont BadgeFont { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets badgeContentEdgeInsets;
        [Export("badgeContentEdgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets BadgeContentEdgeInsets { get; set; }

        // @property (assign, nonatomic) CGPoint badgeOffset;
        [Export("badgeOffset", ArgumentSemantic.Assign)]
        CGPoint BadgeOffset { get; set; }

        // @property (assign, nonatomic) CGPoint badgeOffsetLandscape;
        [Export("badgeOffsetLandscape", ArgumentSemantic.Assign)]
        CGPoint BadgeOffsetLandscape { get; set; }

        // @property (assign, nonatomic) CGPoint badgeCenterOffset __attribute__((deprecated("请改为使用 badgeOffset")));
        [Export("badgeCenterOffset", ArgumentSemantic.Assign)]
        CGPoint BadgeCenterOffset { get; set; }

        // @property (assign, nonatomic) CGPoint badgeCenterOffsetLandscape __attribute__((deprecated("请改为使用 badgeOffsetLandscape")));
        [Export("badgeCenterOffsetLandscape", ArgumentSemantic.Assign)]
        CGPoint BadgeCenterOffsetLandscape { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable updatesIndicatorColor;
        [NullAllowed, Export("updatesIndicatorColor", ArgumentSemantic.Strong)]
        UIColor UpdatesIndicatorColor { get; set; }

        // @property (assign, nonatomic) CGSize updatesIndicatorSize;
        [Export("updatesIndicatorSize", ArgumentSemantic.Assign)]
        CGSize UpdatesIndicatorSize { get; set; }

        // @property (assign, nonatomic) CGPoint updatesIndicatorOffset;
        [Export("updatesIndicatorOffset", ArgumentSemantic.Assign)]
        CGPoint UpdatesIndicatorOffset { get; set; }

        // @property (assign, nonatomic) CGPoint updatesIndicatorOffsetLandscape;
        [Export("updatesIndicatorOffsetLandscape", ArgumentSemantic.Assign)]
        CGPoint UpdatesIndicatorOffsetLandscape { get; set; }

        // @property (assign, nonatomic) CGPoint updatesIndicatorCenterOffset __attribute__((deprecated("请改为使用 updatesIndicatorOffset")));
        [Export("updatesIndicatorCenterOffset", ArgumentSemantic.Assign)]
        CGPoint UpdatesIndicatorCenterOffset { get; set; }

        // @property (assign, nonatomic) CGPoint updatesIndicatorCenterOffsetLandscape __attribute__((deprecated("请改为使用 updatesIndicatorOffsetLandscape")));
        [Export("updatesIndicatorCenterOffsetLandscape", ArgumentSemantic.Assign)]
        CGPoint UpdatesIndicatorCenterOffsetLandscape { get; set; }

        // @property (assign, nonatomic) BOOL automaticCustomNavigationBarTransitionStyle;
        [Export("automaticCustomNavigationBarTransitionStyle")]
        bool AutomaticCustomNavigationBarTransitionStyle { get; set; }

        // @property (assign, nonatomic) UIInterfaceOrientationMask supportedOrientationMask;
        [Export("supportedOrientationMask", ArgumentSemantic.Assign)]
        UIInterfaceOrientationMask SupportedOrientationMask { get; set; }

        // @property (assign, nonatomic) BOOL automaticallyRotateDeviceOrientation;
        [Export("automaticallyRotateDeviceOrientation")]
        bool AutomaticallyRotateDeviceOrientation { get; set; }

        // @property (assign, nonatomic) BOOL statusbarStyleLightInitially;
        [Export("statusbarStyleLightInitially")]
        bool StatusbarStyleLightInitially { get; set; }

        // @property (assign, nonatomic) BOOL needsBackBarButtonItemTitle;
        [Export("needsBackBarButtonItemTitle")]
        bool NeedsBackBarButtonItemTitle { get; set; }

        // @property (assign, nonatomic) BOOL hidesBottomBarWhenPushedInitially;
        [Export("hidesBottomBarWhenPushedInitially")]
        bool HidesBottomBarWhenPushedInitially { get; set; }

        // @property (assign, nonatomic) BOOL preventConcurrentNavigationControllerTransitions;
        [Export("preventConcurrentNavigationControllerTransitions")]
        bool PreventConcurrentNavigationControllerTransitions { get; set; }

        // @property (assign, nonatomic) BOOL navigationBarHiddenInitially;
        [Export("navigationBarHiddenInitially")]
        bool NavigationBarHiddenInitially { get; set; }

        // @property (assign, nonatomic) BOOL shouldFixTabBarTransitionBugInIPhoneX;
        [Export("shouldFixTabBarTransitionBugInIPhoneX")]
        bool ShouldFixTabBarTransitionBugInIPhoneX { get; set; }

        // @property (assign, nonatomic) BOOL shouldFixTabBarSafeAreaInsetsBug;
        [Export("shouldFixTabBarSafeAreaInsetsBug")]
        bool ShouldFixTabBarSafeAreaInsetsBug { get; set; }

        // @property (assign, nonatomic) BOOL shouldFixSearchBarMaskViewLayoutBug;
        [Export("shouldFixSearchBarMaskViewLayoutBug")]
        bool ShouldFixSearchBarMaskViewLayoutBug { get; set; }

        // @property (assign, nonatomic) BOOL sendAnalyticsToQMUITeam;
        [Export("sendAnalyticsToQMUITeam")]
        bool SendAnalyticsToQMUITeam { get; set; }

        // @property (assign, nonatomic) BOOL dynamicPreferredValueForIPad;
        [Export("dynamicPreferredValueForIPad")]
        bool DynamicPreferredValueForIPad { get; set; }

        // @property (assign, nonatomic) BOOL ignoreKVCAccessProhibited __attribute__((availability(ios, introduced=13.0)));
        [iOS(13, 0)]
        [Export("ignoreKVCAccessProhibited")]
        bool IgnoreKVCAccessProhibited { get; set; }

        // @property (assign, nonatomic) BOOL adjustScrollIndicatorInsetsByContentInsetAdjustment __attribute__((availability(ios, introduced=13.0)));
        [iOS(13, 0)]
        [Export("adjustScrollIndicatorInsetsByContentInsetAdjustment")]
        bool AdjustScrollIndicatorInsetsByContentInsetAdjustment { get; set; }

        // +(instancetype _Nullable)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        [return: NullAllowed]
        QMUIConfiguration SharedInstance();

        // -(void)applyInitialTemplate;
        [Export("applyInitialTemplate")]
        void ApplyInitialTemplate();
    }

    // @interface QMUIConfiguration (UINavigationBar)
    [Category]
    [BaseType(typeof(UINavigationBar))]
    interface UINavigationBar_QMUIConfiguration
    {
        // +(instancetype _Nonnull)qmui_appearanceConfigured;
        [Static]
        [Export("qmui_appearanceConfigured")]
        UINavigationBar Qmui_appearanceConfigured();
    }

    // @interface QMUIConfiguration (UITabBar)
    [Category]
    [BaseType(typeof(UITabBar))]
    interface UITabBar_QMUIConfiguration
    {
        // +(instancetype _Nonnull)qmui_appearanceConfigured;
        [Static]
        [Export("qmui_appearanceConfigured")]
        UITabBar Qmui_appearanceConfigured();
    }

    // @interface QMUIConfiguration (UIToolbar)
    [Category]
    [BaseType(typeof(UIToolbar))]
    interface UIToolbar_QMUIConfiguration
    {
        // +(instancetype _Nonnull)qmui_appearanceConfigured;
        [Static]
        [Export("qmui_appearanceConfigured")]
        UIToolbar Qmui_appearanceConfigured();
    }

    // @interface QMUIConfiguration (UITabBarItem)
    [Category]
    [BaseType(typeof(UITabBarItem))]
    interface UITabBarItem_QMUIConfiguration
    {
        // +(instancetype _Nonnull)qmui_appearanceConfigured;
        [Static]
        [Export("qmui_appearanceConfigured")]
        UITabBarItem Qmui_appearanceConfigured();
    }

    // @protocol QMUIBadgeProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIBadgeProtocol
    {
        // @required @property (assign, nonatomic) NSUInteger qmui_badgeInteger;
        [Abstract]
        [Export("qmui_badgeInteger")]
        nuint Qmui_badgeInteger { get; set; }

        // @required @property (copy, nonatomic) NSString * _Nullable qmui_badgeString;
        [Abstract]
        [NullAllowed, Export("qmui_badgeString")]
        string Qmui_badgeString { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Nullable qmui_badgeBackgroundColor;
        [Abstract]
        [NullAllowed, Export("qmui_badgeBackgroundColor", ArgumentSemantic.Strong)]
        UIColor Qmui_badgeBackgroundColor { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Nullable qmui_badgeTextColor;
        [Abstract]
        [NullAllowed, Export("qmui_badgeTextColor", ArgumentSemantic.Strong)]
        UIColor Qmui_badgeTextColor { get; set; }

        // @required @property (nonatomic, strong) UIFont * _Nullable qmui_badgeFont;
        [Abstract]
        [NullAllowed, Export("qmui_badgeFont", ArgumentSemantic.Strong)]
        UIFont Qmui_badgeFont { get; set; }

        // @required @property (assign, nonatomic) UIEdgeInsets qmui_badgeContentEdgeInsets;
        [Abstract]
        [Export("qmui_badgeContentEdgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets Qmui_badgeContentEdgeInsets { get; set; }

        // @required @property (assign, nonatomic) CGPoint qmui_badgeOffset;
        [Abstract]
        [Export("qmui_badgeOffset", ArgumentSemantic.Assign)]
        CGPoint Qmui_badgeOffset { get; set; }

        // @required @property (assign, nonatomic) CGPoint qmui_badgeOffsetLandscape;
        [Abstract]
        [Export("qmui_badgeOffsetLandscape", ArgumentSemantic.Assign)]
        CGPoint Qmui_badgeOffsetLandscape { get; set; }

        // @required @property (assign, nonatomic) CGPoint qmui_badgeCenterOffset __attribute__((deprecated("QMUIBadge 不再以中心为布局参考点，请改为使用 qmui_badgeOffset")));
        [Abstract]
        [Export("qmui_badgeCenterOffset", ArgumentSemantic.Assign)]
        CGPoint Qmui_badgeCenterOffset { get; set; }

        // @required @property (assign, nonatomic) CGPoint qmui_badgeCenterOffsetLandscape __attribute__((deprecated("QMUIBadge 不再以中心为布局参考点，请改为使用 qmui_badgeOffsetLandscape")));
        [Abstract]
        [Export("qmui_badgeCenterOffsetLandscape", ArgumentSemantic.Assign)]
        CGPoint Qmui_badgeCenterOffsetLandscape { get; set; }

        // @required @property (readonly, nonatomic, strong) QMUILabel * _Nullable qmui_badgeLabel;
        [Abstract]
        [NullAllowed, Export("qmui_badgeLabel", ArgumentSemantic.Strong)]
        QMUILabel Qmui_badgeLabel { get; }

        // @required @property (assign, nonatomic) BOOL qmui_shouldShowUpdatesIndicator;
        [Abstract]
        [Export("qmui_shouldShowUpdatesIndicator")]
        bool Qmui_shouldShowUpdatesIndicator { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Nullable qmui_updatesIndicatorColor;
        [Abstract]
        [NullAllowed, Export("qmui_updatesIndicatorColor", ArgumentSemantic.Strong)]
        UIColor Qmui_updatesIndicatorColor { get; set; }

        // @required @property (assign, nonatomic) CGSize qmui_updatesIndicatorSize;
        [Abstract]
        [Export("qmui_updatesIndicatorSize", ArgumentSemantic.Assign)]
        CGSize Qmui_updatesIndicatorSize { get; set; }

        // @required @property (assign, nonatomic) CGPoint qmui_updatesIndicatorOffset;
        [Abstract]
        [Export("qmui_updatesIndicatorOffset", ArgumentSemantic.Assign)]
        CGPoint Qmui_updatesIndicatorOffset { get; set; }

        // @required @property (assign, nonatomic) CGPoint qmui_updatesIndicatorOffsetLandscape;
        [Abstract]
        [Export("qmui_updatesIndicatorOffsetLandscape", ArgumentSemantic.Assign)]
        CGPoint Qmui_updatesIndicatorOffsetLandscape { get; set; }

        // @required @property (assign, nonatomic) CGPoint qmui_updatesIndicatorCenterOffset __attribute__((deprecated("QMUIBadge 不再以中心为布局参考点，请改为使用 qmui_updatesIndicatorOffset")));
        [Abstract]
        [Export("qmui_updatesIndicatorCenterOffset", ArgumentSemantic.Assign)]
        CGPoint Qmui_updatesIndicatorCenterOffset { get; set; }

        // @required @property (assign, nonatomic) CGPoint qmui_updatesIndicatorCenterOffsetLandscape __attribute__((deprecated("QMUIBadge 不再以中心为布局参考点，请改为使用 qmui_updatesIndicatorOffsetLandscape")));
        [Abstract]
        [Export("qmui_updatesIndicatorCenterOffsetLandscape", ArgumentSemantic.Assign)]
        CGPoint Qmui_updatesIndicatorCenterOffsetLandscape { get; set; }

        // @required @property (readonly, nonatomic, strong) UIView * _Nullable qmui_updatesIndicatorView;
        [Abstract]
        [NullAllowed, Export("qmui_updatesIndicatorView", ArgumentSemantic.Strong)]
        UIView Qmui_updatesIndicatorView { get; }
    }

    // @interface QMUIButton : UIButton
    [BaseType(typeof(UIButton))]
    interface QMUIButton
    {
        // -(void)didInitialize __attribute__((objc_requires_super));
        [Export("didInitialize")]
        [RequiresSuper]
        void DidInitialize();

        // @property (assign, nonatomic) BOOL adjustsTitleTintColorAutomatically;
        [Export("adjustsTitleTintColorAutomatically")]
        bool AdjustsTitleTintColorAutomatically { get; set; }

        // @property (assign, nonatomic) BOOL adjustsImageTintColorAutomatically;
        [Export("adjustsImageTintColorAutomatically")]
        bool AdjustsImageTintColorAutomatically { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull tintColorAdjustsTitleAndImage;
        [Export("tintColorAdjustsTitleAndImage", ArgumentSemantic.Strong)]
        UIColor TintColorAdjustsTitleAndImage { get; set; }

        // @property (assign, nonatomic) BOOL adjustsButtonWhenHighlighted;
        [Export("adjustsButtonWhenHighlighted")]
        bool AdjustsButtonWhenHighlighted { get; set; }

        // @property (assign, nonatomic) BOOL adjustsButtonWhenDisabled;
        [Export("adjustsButtonWhenDisabled")]
        bool AdjustsButtonWhenDisabled { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable highlightedBackgroundColor;
        [NullAllowed, Export("highlightedBackgroundColor", ArgumentSemantic.Strong)]
        UIColor HighlightedBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable highlightedBorderColor;
        [NullAllowed, Export("highlightedBorderColor", ArgumentSemantic.Strong)]
        UIColor HighlightedBorderColor { get; set; }

        // @property (assign, nonatomic) QMUIButtonImagePosition imagePosition;
        [Export("imagePosition", ArgumentSemantic.Assign)]
        QMUIButtonImagePosition ImagePosition { get; set; }

        // @property (assign, nonatomic) CGFloat spacingBetweenImageAndTitle;
        [Export("spacingBetweenImageAndTitle")]
        nfloat SpacingBetweenImageAndTitle { get; set; }
    }

    // @interface QMUICellHeightCache : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUICellHeightCache
    {
        // -(BOOL)existsHeightForKey:(id<NSCopying>)key;
        [Export("existsHeightForKey:")]
        bool ExistsHeightForKey(NSCopying key);

        // -(void)cacheHeight:(CGFloat)height byKey:(id<NSCopying>)key;
        [Export("cacheHeight:byKey:")]
        void CacheHeight(nfloat height, NSCopying key);

        // -(CGFloat)heightForKey:(id<NSCopying>)key;
        [Export("heightForKey:")]
        nfloat HeightForKey(NSCopying key);

        // -(void)invalidateHeightForKey:(id<NSCopying>)key;
        [Export("invalidateHeightForKey:")]
        void InvalidateHeightForKey(NSCopying key);

        // -(void)invalidateAllHeightCache;
        [Export("invalidateAllHeightCache")]
        void InvalidateAllHeightCache();
    }

    // @interface QMUICellHeightIndexPathCache : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUICellHeightIndexPathCache
    {
        // @property (assign, nonatomic) BOOL automaticallyInvalidateEnabled;
        [Export("automaticallyInvalidateEnabled")]
        bool AutomaticallyInvalidateEnabled { get; set; }

        // -(BOOL)existsHeightAtIndexPath:(NSIndexPath *)indexPath;
        [Export("existsHeightAtIndexPath:")]
        bool ExistsHeightAtIndexPath(NSIndexPath indexPath);

        // -(void)cacheHeight:(CGFloat)height byIndexPath:(NSIndexPath *)indexPath;
        [Export("cacheHeight:byIndexPath:")]
        void CacheHeight(nfloat height, NSIndexPath indexPath);

        // -(CGFloat)heightForIndexPath:(NSIndexPath *)indexPath;
        [Export("heightForIndexPath:")]
        nfloat HeightForIndexPath(NSIndexPath indexPath);

        // -(void)invalidateHeightAtIndexPath:(NSIndexPath *)indexPath;
        [Export("invalidateHeightAtIndexPath:")]
        void InvalidateHeightAtIndexPath(NSIndexPath indexPath);

        // -(void)invalidateAllHeightCache;
        [Export("invalidateAllHeightCache")]
        void InvalidateAllHeightCache();
    }

    // @interface QMUILayoutCell (UITableView)
    [Category]
    [BaseType(typeof(UITableView))]
    interface UITableView_QMUILayoutCell
    {
        // -(CGFloat)qmui_heightForCellWithIdentifier:(NSString *)identifier configuration:(void (^)(__kindof UITableViewCell *))configuration;
        [Export("qmui_heightForCellWithIdentifier:configuration:")]
        nfloat Qmui_heightForCellWithIdentifier(string identifier, Action<UITableViewCell> configuration);

        // -(CGFloat)qmui_heightForCellWithIdentifier:(NSString *)identifier cacheByIndexPath:(NSIndexPath *)indexPath configuration:(void (^)(__kindof UITableViewCell *))configuration;
        [Export("qmui_heightForCellWithIdentifier:cacheByIndexPath:configuration:")]
        nfloat Qmui_heightForCellWithIdentifier(string identifier, NSIndexPath indexPath, Action<UITableViewCell> configuration);

        // -(CGFloat)qmui_heightForCellWithIdentifier:(NSString *)identifier cacheByKey:(id<NSCopying>)key configuration:(void (^)(__kindof UITableViewCell *))configuration;
        [Export("qmui_heightForCellWithIdentifier:cacheByKey:configuration:")]
        nfloat Qmui_heightForCellWithIdentifier(string identifier, NSCopying key, Action<UITableViewCell> configuration);

        // -(void)qmui_invalidateAllHeight;
        [Export("qmui_invalidateAllHeight")]
        void Qmui_invalidateAllHeight();
    }

    // @interface QMUIKeyedHeightCache (UITableView)
    [Category]
    [BaseType(typeof(UITableView))]
    interface UITableView_QMUIKeyedHeightCache
    {
        // @property (readonly, nonatomic, strong) QMUICellHeightCache * qmui_keyedHeightCache;
        [Export("qmui_keyedHeightCache", ArgumentSemantic.Strong)]
        QMUICellHeightCache Qmui_keyedHeightCache { get; }

        // -(void)qmui_invalidateHeightForKey:(id<NSCopying>)key;
        [Export("qmui_invalidateHeightForKey:")]
        void Qmui_invalidateHeightForKey(NSCopying key);
    }

    // @interface QMUICellHeightIndexPathCache (UITableView)
    [Category]
    [BaseType(typeof(UITableView))]
    interface UITableView_QMUICellHeightIndexPathCache
    {
        // @property (assign, nonatomic) BOOL qmui_invalidateIndexPathHeightCachedAutomatically;
        [Export("qmui_invalidateIndexPathHeightCachedAutomatically")]
        bool Qmui_invalidateIndexPathHeightCachedAutomatically { get; set; }

        // @property (readonly, nonatomic, strong) QMUICellHeightIndexPathCache * qmui_indexPathHeightCache;
        [Export("qmui_indexPathHeightCache", ArgumentSemantic.Strong)]
        QMUICellHeightIndexPathCache Qmui_indexPathHeightCache { get; }

        // -(void)qmui_invalidateHeightAtIndexPath:(NSIndexPath *)indexPath;
        [Export("qmui_invalidateHeightAtIndexPath:")]
        void Qmui_invalidateHeightAtIndexPath(NSIndexPath indexPath);
    }

    // @interface QMUIIndexPathHeightCacheInvalidation (UITableView)
    [Category]
    [BaseType(typeof(UITableView))]
    interface UITableView_QMUIIndexPathHeightCacheInvalidation
    {
        // -(void)qmui_reloadDataWithoutInvalidateIndexPathHeightCache;
        [Export("qmui_reloadDataWithoutInvalidateIndexPathHeightCache")]
        void Qmui_reloadDataWithoutInvalidateIndexPathHeightCache();
    }

    // @interface QMUIKeyedHeightCache (UICollectionView)
    [Category]
    [BaseType(typeof(UICollectionView))]
    interface UICollectionView_QMUIKeyedHeightCache
    {
        // @property (readonly, nonatomic, strong) QMUICellHeightCache * qmui_keyedHeightCache;
        [Export("qmui_keyedHeightCache", ArgumentSemantic.Strong)]
        QMUICellHeightCache Qmui_keyedHeightCache { get; }

        // -(void)qmui_invalidateHeightForKey:(id<NSCopying>)key;
        [Export("qmui_invalidateHeightForKey:")]
        void Qmui_invalidateHeightForKey(NSCopying key);
    }

    // @interface QMUICellHeightIndexPathCache (UICollectionView)
    [Category]
    [BaseType(typeof(UICollectionView))]
    interface UICollectionView_QMUICellHeightIndexPathCache
    {
        // @property (assign, nonatomic) BOOL qmui_invalidateIndexPathHeightCachedAutomatically;
        [Export("qmui_invalidateIndexPathHeightCachedAutomatically")]
        bool Qmui_invalidateIndexPathHeightCachedAutomatically { get; set; }

        // @property (readonly, nonatomic, strong) QMUICellHeightIndexPathCache * qmui_indexPathHeightCache;
        [Export("qmui_indexPathHeightCache", ArgumentSemantic.Strong)]
        QMUICellHeightIndexPathCache Qmui_indexPathHeightCache { get; }

        // -(void)qmui_invalidateHeightAtIndexPath:(NSIndexPath *)indexPath;
        [Export("qmui_invalidateHeightAtIndexPath:")]
        void Qmui_invalidateHeightAtIndexPath(NSIndexPath indexPath);
    }

    // @interface QMUIIndexPathHeightCacheInvalidation (UICollectionView)
    [Category]
    [BaseType(typeof(UICollectionView))]
    interface UICollectionView_QMUIIndexPathHeightCacheInvalidation
    {
        // -(void)qmui_reloadDataWithoutInvalidateIndexPathHeightCache;
        [Export("qmui_reloadDataWithoutInvalidateIndexPathHeightCache")]
        void Qmui_reloadDataWithoutInvalidateIndexPathHeightCache();
    }

    // @interface QMUILayoutCell (UICollectionView)
    [Category]
    [BaseType(typeof(UICollectionView))]
    interface UICollectionView_QMUILayoutCell
    {
        // -(CGFloat)qmui_heightForCellWithIdentifier:(NSString *)identifier cellClass:(Class)cellClass itemWidth:(CGFloat)itemWidth configuration:(void (^)(__kindof UICollectionViewCell *))configuration;
        [Export("qmui_heightForCellWithIdentifier:cellClass:itemWidth:configuration:")]
        nfloat Qmui_heightForCellWithIdentifier(string identifier, Class cellClass, nfloat itemWidth, Action<UICollectionViewCell> configuration);

        // -(CGFloat)qmui_heightForCellWithIdentifier:(NSString *)identifier cellClass:(Class)cellClass itemWidth:(CGFloat)itemWidth cacheByIndexPath:(NSIndexPath *)indexPath configuration:(void (^)(__kindof UICollectionViewCell *))configuration;
        [Export("qmui_heightForCellWithIdentifier:cellClass:itemWidth:cacheByIndexPath:configuration:")]
        nfloat Qmui_heightForCellWithIdentifier(string identifier, Class cellClass, nfloat itemWidth, NSIndexPath indexPath, Action<UICollectionViewCell> configuration);

        // -(CGFloat)qmui_heightForCellWithIdentifier:(NSString *)identifier cellClass:(Class)cellClass itemWidth:(CGFloat)itemWidth cacheByKey:(id<NSCopying>)key configuration:(void (^)(__kindof UICollectionViewCell *))configuration;
        [Export("qmui_heightForCellWithIdentifier:cellClass:itemWidth:cacheByKey:configuration:")]
        nfloat Qmui_heightForCellWithIdentifier(string identifier, Class cellClass, nfloat itemWidth, NSCopying key, Action<UICollectionViewCell> configuration);

        // -(void)qmui_invalidateAllHeight;
        [Export("qmui_invalidateAllHeight")]
        void Qmui_invalidateAllHeight();
    }

    // @interface QMUICellHeightKeyCache : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUICellHeightKeyCache
    {
        // -(BOOL)existsHeightForKey:(id<NSCopying> _Nonnull)key;
        [Export("existsHeightForKey:")]
        bool ExistsHeightForKey(NSCopying key);

        // -(void)cacheHeight:(CGFloat)height forKey:(id<NSCopying> _Nonnull)key;
        [Export("cacheHeight:forKey:")]
        void CacheHeight(nfloat height, NSCopying key);

        // -(CGFloat)heightForKey:(id<NSCopying> _Nonnull)key;
        [Export("heightForKey:")]
        nfloat HeightForKey(NSCopying key);

        // -(void)invalidateHeightForKey:(id<NSCopying> _Nonnull)key;
        [Export("invalidateHeightForKey:")]
        void InvalidateHeightForKey(NSCopying key);

        // -(void)invalidateAllHeightCache;
        [Export("invalidateAllHeightCache")]
        void InvalidateAllHeightCache();
    }

    // @interface QMUICellSizeKeyCache : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUICellSizeKeyCache
    {
        // -(BOOL)existsSizeForKey:(id<NSCopying>)key;
        [Export("existsSizeForKey:")]
        bool ExistsSizeForKey(NSCopying key);

        // -(void)cacheSize:(CGSize)size forKey:(id<NSCopying>)key;
        [Export("cacheSize:forKey:")]
        void CacheSize(CGSize size, NSCopying key);

        // -(CGSize)sizeForKey:(id<NSCopying>)key;
        [Export("sizeForKey:")]
        CGSize SizeForKey(NSCopying key);

        // -(void)invalidateSizeForKey:(id<NSCopying>)key;
        [Export("invalidateSizeForKey:")]
        void InvalidateSizeForKey(NSCopying key);

        // -(void)invalidateAllSizeCache;
        [Export("invalidateAllSizeCache")]
        void InvalidateAllSizeCache();
    }

    // @interface QMUICollectionViewPagingLayout : UICollectionViewFlowLayout
    [BaseType(typeof(UICollectionViewFlowLayout))]
    interface QMUICollectionViewPagingLayout
    {
        // -(instancetype)initWithStyle:(QMUICollectionViewPagingLayoutStyle)style __attribute__((objc_designated_initializer));
        [Export("initWithStyle:")]
        [DesignatedInitializer]
        IntPtr Constructor(QMUICollectionViewPagingLayoutStyle style);

        // @property (readonly, assign, nonatomic) QMUICollectionViewPagingLayoutStyle style;
        [Export("style", ArgumentSemantic.Assign)]
        QMUICollectionViewPagingLayoutStyle Style { get; }

        // @property (assign, nonatomic) CGFloat velocityForEnsurePageDown;
        [Export("velocityForEnsurePageDown")]
        nfloat VelocityForEnsurePageDown { get; set; }

        // @property (assign, nonatomic) BOOL allowsMultipleItemScroll;
        [Export("allowsMultipleItemScroll")]
        bool AllowsMultipleItemScroll { get; set; }

        // @property (assign, nonatomic) CGFloat multipleItemScrollVelocityLimit;
        [Export("multipleItemScrollVelocityLimit")]
        nfloat MultipleItemScrollVelocityLimit { get; set; }
    }

    // @interface DefaultStyle (QMUICollectionViewPagingLayout)
    [Category]
    [BaseType(typeof(QMUICollectionViewPagingLayout))]
    interface QMUICollectionViewPagingLayout_DefaultStyle
    {
        // @property (assign, nonatomic) CGFloat pagingThreshold;
        [Export("pagingThreshold")]
        nfloat PagingThreshold { get; set; }

        // @property (assign, nonatomic) BOOL debug;
        [Export("debug")]
        bool Debug { get; set; }
    }

    // @interface ScaleStyle (QMUICollectionViewPagingLayout)
    [Category]
    [BaseType(typeof(QMUICollectionViewPagingLayout))]
    interface QMUICollectionViewPagingLayout_ScaleStyle
    {
        // @property (assign, nonatomic) CGFloat maximumScale;
        [Export("maximumScale")]
        nfloat MaximumScale { get; set; }

        // @property (assign, nonatomic) CGFloat minimumScale;
        [Export("minimumScale")]
        nfloat MinimumScale { get; set; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const CGFloat QMUICollectionViewPagingLayoutRotationRadiusAutomatic;
        [Field("QMUICollectionViewPagingLayoutRotationRadiusAutomatic", "__Internal")]
        nfloat QMUICollectionViewPagingLayoutRotationRadiusAutomatic { get; }
    }

    // @interface RotationStyle (QMUICollectionViewPagingLayout)
    [Category]
    [BaseType(typeof(QMUICollectionViewPagingLayout))]
    interface QMUICollectionViewPagingLayout_RotationStyle
    {
        // @property (assign, nonatomic) CGFloat rotationRatio;
        [Export("rotationRatio")]
        nfloat RotationRatio { get; set; }

        // @property (assign, nonatomic) CGFloat rotationRadius;
        [Export("rotationRadius")]
        nfloat RotationRadius { get; set; }
    }

    // @interface QMUIConsoleToolbar : UIView
    [BaseType(typeof(UIView))]
    interface QMUIConsoleToolbar
    {
        // @property (readonly, nonatomic, strong) QMUIButton * _Nonnull levelButton;
        [Export("levelButton", ArgumentSemantic.Strong)]
        QMUIButton LevelButton { get; }

        // @property (readonly, nonatomic, strong) QMUIButton * _Nonnull nameButton;
        [Export("nameButton", ArgumentSemantic.Strong)]
        QMUIButton NameButton { get; }

        // @property (readonly, nonatomic, strong) QMUIButton * _Nonnull clearButton;
        [Export("clearButton", ArgumentSemantic.Strong)]
        QMUIButton ClearButton { get; }

        // @property (readonly, nonatomic, strong) QMUITextField * _Nonnull searchTextField;
        [Export("searchTextField", ArgumentSemantic.Strong)]
        QMUITextField SearchTextField { get; }

        // @property (readonly, nonatomic, strong) UILabel * _Nonnull searchResultCountLabel;
        [Export("searchResultCountLabel", ArgumentSemantic.Strong)]
        UILabel SearchResultCountLabel { get; }

        // @property (readonly, nonatomic, strong) QMUIButton * _Nonnull searchResultPreviousButton;
        [Export("searchResultPreviousButton", ArgumentSemantic.Strong)]
        QMUIButton SearchResultPreviousButton { get; }

        // @property (readonly, nonatomic, strong) QMUIButton * _Nonnull searchResultNextButton;
        [Export("searchResultNextButton", ArgumentSemantic.Strong)]
        QMUIButton SearchResultNextButton { get; }

        // -(void)setNeedsLayoutSearchResultViews;
        [Export("setNeedsLayoutSearchResultViews")]
        void SetNeedsLayoutSearchResultViews();
    }

    // @interface QMUIConsoleViewController : QMUICommonViewController
    [BaseType(typeof(QMUICommonViewController))]
    interface QMUIConsoleViewController
    {
        // @property (readonly, nonatomic, strong) QMUIButton * _Nonnull popoverButton;
        [Export("popoverButton", ArgumentSemantic.Strong)]
        QMUIButton PopoverButton { get; }

        // @property (readonly, nonatomic, strong) QMUITextView * _Nonnull textView;
        [Export("textView", ArgumentSemantic.Strong)]
        QMUITextView TextView { get; }

        // @property (readonly, nonatomic, strong) QMUIConsoleToolbar * _Nonnull toolbar;
        [Export("toolbar", ArgumentSemantic.Strong)]
        QMUIConsoleToolbar Toolbar { get; }

        // @property (readonly, nonatomic, strong) NSDateFormatter * _Nonnull dateFormatter;
        [Export("dateFormatter", ArgumentSemantic.Strong)]
        NSDateFormatter DateFormatter { get; }

        // @property (nonatomic, strong) UIColor * _Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // -(void)logWithLevel:(NSString * _Nullable)level name:(NSString * _Nullable)name logString:(id _Nonnull)logString;
        [Export("logWithLevel:name:logString:")]
        void LogWithLevel([NullAllowed] string level, [NullAllowed] string name, NSObject logString);

        // -(void)log:(id _Nonnull)logString;
        [Export("log:")]
        void Log(NSObject logString);

        // -(void)clear;
        [Export("clear")]
        void Clear();
    }

    // @interface QMUIConsole (QMUILogger)
    [Category]
    [BaseType(typeof(QMUILogger))]
    interface QMUILogger_QMUIConsole
    {
    }

    // @interface QMUIConsole : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIConsole
    {
        // +(instancetype _Nonnull)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        QMUIConsole SharedInstance();

        // +(void)logWithLevel:(NSString * _Nullable)level name:(NSString * _Nullable)name logString:(id _Nonnull)logString;
        [Static]
        [Export("logWithLevel:name:logString:")]
        void LogWithLevel([NullAllowed] string level, [NullAllowed] string name, NSObject logString);

        // +(void)log:(id _Nonnull)logString;
        [Static]
        [Export("log:")]
        void Log(NSObject logString);

        // +(void)clear;
        [Static]
        [Export("clear")]
        void Clear();

        // +(void)show;
        [Static]
        [Export("show")]
        void Show();

        // +(void)hide;
        [Static]
        [Export("hide")]
        void Hide();

        // @property (assign, nonatomic) BOOL canShow;
        [Export("canShow")]
        bool CanShow { get; set; }

        // @property (assign, nonatomic) BOOL showConsoleAutomatically;
        [Export("showConsoleAutomatically")]
        bool ShowConsoleAutomatically { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable backgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) NSDictionary<NSAttributedStringKey,id> * _Nullable textAttributes __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("textAttributes", ArgumentSemantic.Strong)]
        NSDictionary<NSString, NSObject> TextAttributes { get; set; }

        // @property (nonatomic, strong) NSDictionary<NSAttributedStringKey,id> * _Nullable timeAttributes __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("timeAttributes", ArgumentSemantic.Strong)]
        NSDictionary<NSString, NSObject> TimeAttributes { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable searchResultHighlightedBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("searchResultHighlightedBackgroundColor", ArgumentSemantic.Strong)]
        UIColor SearchResultHighlightedBackgroundColor { get; set; }
    }

    // @interface UIAppearance (QMUIConsole)
    [Category]
    [BaseType(typeof(QMUIConsole))]
    interface QMUIConsole_UIAppearance
    {
        // +(instancetype _Nonnull)appearance;
        [Static]
        [Export("appearance")]
        QMUIConsole Appearance();
    }

    // @interface QMUIDialogViewController : QMUICommonViewController <QMUIModalPresentationContentViewControllerProtocol, QMUIModalPresentationComponentProtocol>
    [BaseType(typeof(QMUICommonViewController))]
    interface QMUIDialogViewController : IQMUIModalPresentationContentViewControllerProtocol, IQMUIModalPresentationComponentProtocol
    {
        // @property (assign, nonatomic) CGFloat cornerRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets dialogViewMargins __attribute__((annotate("ui_appearance_selector")));
        [Export("dialogViewMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets DialogViewMargins { get; set; }

        // @property (assign, nonatomic) CGFloat maximumContentViewWidth __attribute__((annotate("ui_appearance_selector")));
        [Export("maximumContentViewWidth")]
        nfloat MaximumContentViewWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable backgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable titleTintColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("titleTintColor", ArgumentSemantic.Strong)]
        UIColor TitleTintColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable titleLabelFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("titleLabelFont", ArgumentSemantic.Strong)]
        UIFont TitleLabelFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable titleLabelTextColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("titleLabelTextColor", ArgumentSemantic.Strong)]
        UIColor TitleLabelTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable subTitleLabelFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("subTitleLabelFont", ArgumentSemantic.Strong)]
        UIFont SubTitleLabelFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable subTitleLabelTextColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("subTitleLabelTextColor", ArgumentSemantic.Strong)]
        UIColor SubTitleLabelTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable headerSeparatorColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("headerSeparatorColor", ArgumentSemantic.Strong)]
        UIColor HeaderSeparatorColor { get; set; }

        // @property (assign, nonatomic) CGFloat headerViewHeight __attribute__((annotate("ui_appearance_selector")));
        [Export("headerViewHeight")]
        nfloat HeaderViewHeight { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable headerViewBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("headerViewBackgroundColor", ArgumentSemantic.Strong)]
        UIColor HeaderViewBackgroundColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets contentViewMargins __attribute__((annotate("ui_appearance_selector")));
        [Export("contentViewMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets ContentViewMargins { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable contentViewBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("contentViewBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ContentViewBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable footerSeparatorColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("footerSeparatorColor", ArgumentSemantic.Strong)]
        UIColor FooterSeparatorColor { get; set; }

        // @property (assign, nonatomic) CGFloat footerViewHeight __attribute__((annotate("ui_appearance_selector")));
        [Export("footerViewHeight")]
        nfloat FooterViewHeight { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable footerViewBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("footerViewBackgroundColor", ArgumentSemantic.Strong)]
        UIColor FooterViewBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable buttonBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("buttonBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ButtonBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable buttonHighlightedBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("buttonHighlightedBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ButtonHighlightedBackgroundColor { get; set; }

        // @property (copy, nonatomic) NSDictionary<NSAttributedStringKey,id> * _Nullable buttonTitleAttributes __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("buttonTitleAttributes", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> ButtonTitleAttributes { get; set; }

        // @property (readonly, nonatomic, strong) UIView * _Nullable headerView;
        [NullAllowed, Export("headerView", ArgumentSemantic.Strong)]
        UIView HeaderView { get; }

        // @property (readonly, nonatomic, strong) CALayer * _Nullable headerViewSeparatorLayer;
        [NullAllowed, Export("headerViewSeparatorLayer", ArgumentSemantic.Strong)]
        CALayer HeaderViewSeparatorLayer { get; }

        // @property (nonatomic, strong) UIView * _Nullable contentView;
        [NullAllowed, Export("contentView", ArgumentSemantic.Strong)]
        UIView ContentView { get; set; }

        // @property (readonly, nonatomic, strong) UIView * _Nullable footerView;
        [NullAllowed, Export("footerView", ArgumentSemantic.Strong)]
        UIView FooterView { get; }

        // @property (readonly, nonatomic, strong) CALayer * _Nullable footerViewSeparatorLayer;
        [NullAllowed, Export("footerViewSeparatorLayer", ArgumentSemantic.Strong)]
        CALayer FooterViewSeparatorLayer { get; }

        // @property (readonly, nonatomic, strong) QMUIButton * _Nullable cancelButton;
        [NullAllowed, Export("cancelButton", ArgumentSemantic.Strong)]
        QMUIButton CancelButton { get; }

        // @property (readonly, nonatomic, strong) QMUIButton * _Nullable submitButton;
        [NullAllowed, Export("submitButton", ArgumentSemantic.Strong)]
        QMUIButton SubmitButton { get; }

        // @property (readonly, nonatomic, strong) CALayer * _Nullable buttonSeparatorLayer;
        [NullAllowed, Export("buttonSeparatorLayer", ArgumentSemantic.Strong)]
        CALayer ButtonSeparatorLayer { get; }

        // -(void)addCancelButtonWithText:(NSString * _Nonnull)buttonText block:(void (^ _Nullable)(__kindof QMUIDialogViewController * _Nonnull))block;
        [Export("addCancelButtonWithText:block:")]
        void AddCancelButtonWithText(string buttonText, [NullAllowed] Action<QMUIDialogViewController> block);

        // -(void)removeCancelButton;
        [Export("removeCancelButton")]
        void RemoveCancelButton();

        // -(void)addSubmitButtonWithText:(NSString * _Nonnull)buttonText block:(void (^ _Nullable)(__kindof QMUIDialogViewController * _Nonnull))block;
        [Export("addSubmitButtonWithText:block:")]
        void AddSubmitButtonWithText(string buttonText, [NullAllowed] Action<QMUIDialogViewController> block);

        // -(void)removeSubmitButton;
        [Export("removeSubmitButton")]
        void RemoveSubmitButton();

        // @property (nonatomic, strong) QMUIModalPresentationViewController * _Nullable modalPresentationViewController;
        [NullAllowed, Export("modalPresentationViewController", ArgumentSemantic.Strong)]
        QMUIModalPresentationViewController ModalPresentationViewController { get; set; }

        // -(void)show;
        [Export("show")]
        void Show();

        // -(void)showWithAnimated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
        [Export("showWithAnimated:completion:")]
        void ShowWithAnimated(bool animated, [NullAllowed] Action<bool> completion);

        // -(void)hide;
        [Export("hide")]
        void Hide();

        // -(void)hideWithAnimated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
        [Export("hideWithAnimated:completion:")]
        void HideWithAnimated(bool animated, [NullAllowed] Action<bool> completion);
    }

    // @interface UIAppearance (QMUIDialogViewController)
    [Category]
    [BaseType(typeof(QMUIDialogViewController))]
    interface QMUIDialogViewController_UIAppearance
    {
        // +(instancetype _Nonnull)appearance;
        [Static]
        [Export("appearance")]
        QMUIDialogViewController Appearance();
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const NSInteger QMUIDialogSelectionViewControllerSelectedItemIndexNone;
        [Field("QMUIDialogSelectionViewControllerSelectedItemIndexNone", "__Internal")]
        nint QMUIDialogSelectionViewControllerSelectedItemIndexNone { get; }
    }

    // @interface QMUIDialogSelectionViewController : QMUIDialogViewController <QMUITableViewDelegate, QMUITableViewDataSource>
    [BaseType(typeof(QMUIDialogViewController))]
    interface QMUIDialogSelectionViewController : IQMUITableViewDelegate, IQMUITableViewDataSource
    {
        // @property (assign, nonatomic) CGFloat rowHeight __attribute__((annotate("ui_appearance_selector")));
        [Export("rowHeight")]
        nfloat RowHeight { get; set; }

        // @property (readonly, nonatomic, strong) QMUITableView * _Nullable tableView;
        [NullAllowed, Export("tableView", ArgumentSemantic.Strong)]
        QMUITableView TableView { get; }

        // @property (copy, nonatomic) NSArray<NSString *> * _Nullable items;
        [NullAllowed, Export("items", ArgumentSemantic.Copy)]
        string[] Items { get; set; }

        // @property (assign, nonatomic) NSInteger selectedItemIndex;
        [Export("selectedItemIndex")]
        nint SelectedItemIndex { get; set; }

        // @property (nonatomic, strong) NSMutableSet<NSNumber *> * _Nullable selectedItemIndexes;
        [NullAllowed, Export("selectedItemIndexes", ArgumentSemantic.Strong)]
        NSMutableSet<NSNumber> SelectedItemIndexes { get; set; }

        // @property (assign, nonatomic) BOOL allowsMultipleSelection;
        [Export("allowsMultipleSelection")]
        bool AllowsMultipleSelection { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(__kindof QMUIDialogSelectionViewController * _Nonnull, __kindof QMUITableViewCell * _Nonnull, NSUInteger) cellForItemBlock;
        [NullAllowed, Export("cellForItemBlock", ArgumentSemantic.Copy)]
        Action<QMUIDialogSelectionViewController, QMUITableViewCell, nuint> CellForItemBlock { get; set; }

        // @property (copy, nonatomic) CGFloat (^ _Nullable)(__kindof QMUIDialogSelectionViewController * _Nonnull, NSUInteger) heightForItemBlock;
        [NullAllowed, Export("heightForItemBlock", ArgumentSemantic.Copy)]
        Func<QMUIDialogSelectionViewController, nuint, nfloat> HeightForItemBlock { get; set; }

        // @property (copy, nonatomic) BOOL (^ _Nullable)(__kindof QMUIDialogSelectionViewController * _Nonnull, NSUInteger) canSelectItemBlock;
        [NullAllowed, Export("canSelectItemBlock", ArgumentSemantic.Copy)]
        Func<QMUIDialogSelectionViewController, nuint, bool> CanSelectItemBlock { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(__kindof QMUIDialogSelectionViewController * _Nonnull, NSUInteger) didSelectItemBlock;
        [NullAllowed, Export("didSelectItemBlock", ArgumentSemantic.Copy)]
        Action<QMUIDialogSelectionViewController, nuint> DidSelectItemBlock { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(__kindof QMUIDialogSelectionViewController * _Nonnull, NSUInteger) didDeselectItemBlock;
        [NullAllowed, Export("didDeselectItemBlock", ArgumentSemantic.Copy)]
        Action<QMUIDialogSelectionViewController, nuint> DidDeselectItemBlock { get; set; }
    }

    // @interface QMUIDialogTextFieldViewController : QMUIDialogViewController
    [BaseType(typeof(QMUIDialogViewController))]
    interface QMUIDialogTextFieldViewController
    {
        // @property (nonatomic, strong) UIFont * _Nullable textFieldLabelFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("textFieldLabelFont", ArgumentSemantic.Strong)]
        UIFont TextFieldLabelFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable textFieldLabelTextColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("textFieldLabelTextColor", ArgumentSemantic.Strong)]
        UIColor TextFieldLabelTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable textFieldFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("textFieldFont", ArgumentSemantic.Strong)]
        UIFont TextFieldFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable textFieldTextColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("textFieldTextColor", ArgumentSemantic.Strong)]
        UIColor TextFieldTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable textFieldSeparatorColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("textFieldSeparatorColor", ArgumentSemantic.Strong)]
        UIColor TextFieldSeparatorColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets textFieldLabelMargins __attribute__((annotate("ui_appearance_selector")));
        [Export("textFieldLabelMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets TextFieldLabelMargins { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets textFieldMargins __attribute__((annotate("ui_appearance_selector")));
        [Export("textFieldMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets TextFieldMargins { get; set; }

        // @property (assign, nonatomic) CGFloat textFieldHeight __attribute__((annotate("ui_appearance_selector")));
        [Export("textFieldHeight")]
        nfloat TextFieldHeight { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets textFieldSeparatorInsets __attribute__((annotate("ui_appearance_selector")));
        [Export("textFieldSeparatorInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets TextFieldSeparatorInsets { get; set; }

        // -(void)addTextFieldWithTitle:(NSString * _Nullable)textFieldTitle configurationHandler:(void (^ _Nullable)(QMUILabel * _Nonnull, QMUITextField * _Nonnull, CALayer * _Nonnull))configurationHandler;
        [Export("addTextFieldWithTitle:configurationHandler:")]
        void AddTextFieldWithTitle([NullAllowed] string textFieldTitle, [NullAllowed] Action<QMUILabel, QMUITextField, CALayer> configurationHandler);

        // @property (readonly, copy, nonatomic) NSArray<QMUILabel *> * _Nullable textFieldTitleLabels;
        [NullAllowed, Export("textFieldTitleLabels", ArgumentSemantic.Copy)]
        QMUILabel[] TextFieldTitleLabels { get; }

        // @property (readonly, copy, nonatomic) NSArray<QMUITextField *> * _Nullable textFields;
        [NullAllowed, Export("textFields", ArgumentSemantic.Copy)]
        QMUITextField[] TextFields { get; }

        // @property (readonly, copy, nonatomic) NSArray<CALayer *> * _Nullable textFieldSeparatorLayers;
        [NullAllowed, Export("textFieldSeparatorLayers", ArgumentSemantic.Copy)]
        CALayer[] TextFieldSeparatorLayers { get; }

        // @property (assign, nonatomic) BOOL shouldManageTextFieldsReturnEventAutomatically;
        [Export("shouldManageTextFieldsReturnEventAutomatically")]
        bool ShouldManageTextFieldsReturnEventAutomatically { get; set; }

        // @property (assign, nonatomic) BOOL enablesSubmitButtonAutomatically;
        [Export("enablesSubmitButtonAutomatically")]
        bool EnablesSubmitButtonAutomatically { get; set; }

        // @property (copy, nonatomic) BOOL (^ _Nullable)(__kindof QMUIDialogTextFieldViewController * _Nonnull) shouldEnableSubmitButtonBlock;
        [NullAllowed, Export("shouldEnableSubmitButtonBlock", ArgumentSemantic.Copy)]
        Func<QMUIDialogTextFieldViewController, bool> ShouldEnableSubmitButtonBlock { get; set; }
    }

    // @interface QMUIDisplayLinkAnimation : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIDisplayLinkAnimation
    {
        // @property (readonly, nonatomic, strong) CADisplayLink * displayLink;
        [Export("displayLink", ArgumentSemantic.Strong)]
        CADisplayLink DisplayLink { get; }

        // @property (nonatomic, strong) id fromValue;
        [Export("fromValue", ArgumentSemantic.Strong)]
        NSObject FromValue { get; set; }

        // @property (nonatomic, strong) id toValue;
        [Export("toValue", ArgumentSemantic.Strong)]
        NSObject ToValue { get; set; }

        // @property (assign, nonatomic) NSTimeInterval duration;
        [Export("duration")]
        double Duration { get; set; }

        // @property (assign, nonatomic) QMUIAnimationEasings easing;
        [Export("easing", ArgumentSemantic.Assign)]
        QMUIAnimationEasings Easing { get; set; }

        // @property (assign, nonatomic) BOOL repeat;
        [Export("repeat")]
        bool Repeat { get; set; }

        // @property (assign, nonatomic) NSTimeInterval beginTime;
        [Export("beginTime")]
        double BeginTime { get; set; }

        // @property (assign, nonatomic) float repeatCount;
        [Export("repeatCount")]
        float RepeatCount { get; set; }

        // @property (assign, nonatomic) BOOL autoreverses;
        [Export("autoreverses")]
        bool Autoreverses { get; set; }

        // @property (copy, nonatomic) void (^animation)(id);
        [Export("animation", ArgumentSemantic.Copy)]
        Action<NSObject> Animation { get; set; }

        // @property (copy, nonatomic) void (^animations)(QMUIDisplayLinkAnimation *, CGFloat);
        [Export("animations", ArgumentSemantic.Copy)]
        Action<QMUIDisplayLinkAnimation, nfloat> Animations { get; set; }

        // -(instancetype)initWithDuration:(NSTimeInterval)duration easing:(QMUIAnimationEasings)easing fromValue:(id)fromValue toValue:(id)toValue animation:(void (^)(id))animation;
        [Export("initWithDuration:easing:fromValue:toValue:animation:")]
        IntPtr Constructor(double duration, QMUIAnimationEasings easing, NSObject fromValue, NSObject toValue, Action<NSObject> animation);

        // -(instancetype)initWithDuration:(NSTimeInterval)duration easing:(QMUIAnimationEasings)easing animations:(void (^)(QMUIDisplayLinkAnimation *, CGFloat))animations;
        [Export("initWithDuration:easing:animations:")]
        IntPtr Constructor(double duration, QMUIAnimationEasings easing, Action<QMUIDisplayLinkAnimation, nfloat> animations);

        // -(void)startAnimation;
        [Export("startAnimation")]
        void StartAnimation();

        // -(void)stopAnimation;
        [Export("stopAnimation")]
        void StopAnimation();

        // @property (copy, nonatomic) void (^willStartAnimation)();
        [Export("willStartAnimation", ArgumentSemantic.Copy)]
        Action WillStartAnimation { get; set; }

        // @property (copy, nonatomic) void (^didStopAnimation)();
        [Export("didStopAnimation", ArgumentSemantic.Copy)]
        Action DidStopAnimation { get; set; }
    }

    // @interface ConvenienceClassMethod (QMUIDisplayLinkAnimation)
    [Category]
    [BaseType(typeof(QMUIDisplayLinkAnimation))]
    interface QMUIDisplayLinkAnimation_ConvenienceClassMethod
    {
        // +(instancetype)springAnimateWithFromValue:(id)fromValue toValue:(id)toValue animation:(void (^)(id))animation createdBlock:(void (^)(QMUIDisplayLinkAnimation *))createdBlock;
        [Static]
        [Export("springAnimateWithFromValue:toValue:animation:createdBlock:")]
        QMUIDisplayLinkAnimation SpringAnimateWithFromValue(NSObject fromValue, NSObject toValue, Action<NSObject> animation, Action<QMUIDisplayLinkAnimation> createdBlock);

        // +(instancetype)animateWithDuration:(NSTimeInterval)duration easing:(QMUIAnimationEasings)easing fromValue:(id)fromValue toValue:(id)toValue animation:(void (^)(id))animation;
        [Static]
        [Export("animateWithDuration:easing:fromValue:toValue:animation:")]
        QMUIDisplayLinkAnimation AnimateWithDuration(double duration, QMUIAnimationEasings easing, NSObject fromValue, NSObject toValue, Action<NSObject> animation);

        // +(instancetype)animateWithDuration:(NSTimeInterval)duration easing:(QMUIAnimationEasings)easing fromValue:(id)fromValue toValue:(id)toValue animation:(void (^)(id))animation createdBlock:(void (^)(QMUIDisplayLinkAnimation *))createdBlock;
        [Static]
        [Export("animateWithDuration:easing:fromValue:toValue:animation:createdBlock:")]
        QMUIDisplayLinkAnimation AnimateWithDuration(double duration, QMUIAnimationEasings easing, NSObject fromValue, NSObject toValue, Action<NSObject> animation, Action<QMUIDisplayLinkAnimation> createdBlock);

        // +(instancetype)animateWithDuration:(NSTimeInterval)duration easing:(QMUIAnimationEasings)easing fromValue:(id)fromValue toValue:(id)toValue animation:(void (^)(id))animation createdBlock:(void (^)(QMUIDisplayLinkAnimation *))createdBlock didStopBlock:(void (^)(QMUIDisplayLinkAnimation *))didStopBlock;
        [Static]
        [Export("animateWithDuration:easing:fromValue:toValue:animation:createdBlock:didStopBlock:")]
        QMUIDisplayLinkAnimation AnimateWithDuration(double duration, QMUIAnimationEasings easing, NSObject fromValue, NSObject toValue, Action<NSObject> animation, Action<QMUIDisplayLinkAnimation> createdBlock, Action<QMUIDisplayLinkAnimation> didStopBlock);

        // +(instancetype)springAnimateWithAnimations:(void (^)(QMUIDisplayLinkAnimation *, CGFloat))animations createdBlock:(void (^)(QMUIDisplayLinkAnimation *))createdBlock;
        [Static]
        [Export("springAnimateWithAnimations:createdBlock:")]
        QMUIDisplayLinkAnimation SpringAnimateWithAnimations(Action<QMUIDisplayLinkAnimation, nfloat> animations, Action<QMUIDisplayLinkAnimation> createdBlock);

        // +(instancetype)animateWithDuration:(NSTimeInterval)duration easing:(QMUIAnimationEasings)easing animations:(void (^)(QMUIDisplayLinkAnimation *, CGFloat))animations;
        [Static]
        [Export("animateWithDuration:easing:animations:")]
        QMUIDisplayLinkAnimation AnimateWithDuration(double duration, QMUIAnimationEasings easing, Action<QMUIDisplayLinkAnimation, nfloat> animations);

        // +(instancetype)animateWithDuration:(NSTimeInterval)duration easing:(QMUIAnimationEasings)easing animations:(void (^)(QMUIDisplayLinkAnimation *, CGFloat))animations createdBlock:(void (^)(QMUIDisplayLinkAnimation *))createdBlock;
        [Static]
        [Export("animateWithDuration:easing:animations:createdBlock:")]
        QMUIDisplayLinkAnimation AnimateWithDuration(double duration, QMUIAnimationEasings easing, Action<QMUIDisplayLinkAnimation, nfloat> animations, Action<QMUIDisplayLinkAnimation> createdBlock);

        // +(instancetype)animateWithDuration:(NSTimeInterval)duration easing:(QMUIAnimationEasings)easing animations:(void (^)(QMUIDisplayLinkAnimation *, CGFloat))animations createdBlock:(void (^)(QMUIDisplayLinkAnimation *))createdBlock didStopBlock:(void (^)(QMUIDisplayLinkAnimation *))didStopBlock;
        [Static]
        [Export("animateWithDuration:easing:animations:createdBlock:didStopBlock:")]
        QMUIDisplayLinkAnimation AnimateWithDuration(double duration, QMUIAnimationEasings easing, Action<QMUIDisplayLinkAnimation, nfloat> animations, Action<QMUIDisplayLinkAnimation> createdBlock, Action<QMUIDisplayLinkAnimation> didStopBlock);
    }

    // @interface QMUIEmotionInputManager : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIEmotionInputManager
    {
        // @property (nonatomic, weak) UITextField * boundTextField;
        [Export("boundTextField", ArgumentSemantic.Weak)]
        UITextField BoundTextField { get; set; }

        // @property (nonatomic, weak) UITextView * boundTextView;
        [Export("boundTextView", ArgumentSemantic.Weak)]
        UITextView BoundTextView { get; set; }

        // @property (assign, nonatomic) NSRange selectedRangeForBoundTextInput;
        [Export("selectedRangeForBoundTextInput", ArgumentSemantic.Assign)]
        NSRange SelectedRangeForBoundTextInput { get; set; }

        // @property (readonly, nonatomic, strong) QMUIEmotionView * emotionView;
        [Export("emotionView", ArgumentSemantic.Strong)]
        QMUIEmotionView EmotionView { get; }

        // -(BOOL)deleteEmotionDisplayNameAtCurrentSelectedRangeForce:(BOOL)forceDelete;
        [Export("deleteEmotionDisplayNameAtCurrentSelectedRangeForce:")]
        bool DeleteEmotionDisplayNameAtCurrentSelectedRangeForce(bool forceDelete);

        // -(BOOL)shouldTakeOverControlDeleteKeyWithChangeTextInRange:(NSRange)range replacementText:(NSString *)text;
        [Export("shouldTakeOverControlDeleteKeyWithChangeTextInRange:replacementText:")]
        bool ShouldTakeOverControlDeleteKeyWithChangeTextInRange(NSRange range, string text);
    }

    // @interface QMUIEmotion : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIEmotion
    {
        // @property (copy, nonatomic) NSString * identifier;
        [Export("identifier")]
        string Identifier { get; set; }

        // @property (copy, nonatomic) NSString * displayName;
        [Export("displayName")]
        string DisplayName { get; set; }

        // @property (nonatomic, strong) UIImage * image;
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // +(instancetype)emotionWithIdentifier:(NSString *)identifier displayName:(NSString *)displayName;
        [Static]
        [Export("emotionWithIdentifier:displayName:")]
        QMUIEmotion EmotionWithIdentifier(string identifier, string displayName);
    }

    // @interface QMUIEmotionView : UIView <UICollectionViewDataSource, UICollectionViewDelegateFlowLayout>
    [BaseType(typeof(UIView))]
    interface QMUIEmotionView : IUICollectionViewDataSource, IUICollectionViewDelegateFlowLayout
    {
        // @property (copy, nonatomic) NSArray<QMUIEmotion *> * emotions;
        [Export("emotions", ArgumentSemantic.Copy)]
        QMUIEmotion[] Emotions { get; set; }

        // @property (copy, nonatomic) void (^didSelectEmotionBlock)(NSInteger, QMUIEmotion *);
        [Export("didSelectEmotionBlock", ArgumentSemantic.Copy)]
        Action<nint, QMUIEmotion> DidSelectEmotionBlock { get; set; }

        // @property (copy, nonatomic) void (^didSelectDeleteButtonBlock)();
        [Export("didSelectDeleteButtonBlock", ArgumentSemantic.Copy)]
        Action DidSelectDeleteButtonBlock { get; set; }

        // @property (readonly, nonatomic, strong) UICollectionView * collectionView;
        [Export("collectionView", ArgumentSemantic.Strong)]
        UICollectionView CollectionView { get; }

        // @property (readonly, nonatomic, strong) UICollectionViewFlowLayout * collectionViewLayout;
        [Export("collectionViewLayout", ArgumentSemantic.Strong)]
        UICollectionViewFlowLayout CollectionViewLayout { get; }

        // @property (readonly, nonatomic, strong) UIPageControl * pageControl;
        [Export("pageControl", ArgumentSemantic.Strong)]
        UIPageControl PageControl { get; }

        // @property (readonly, nonatomic, strong) QMUIButton * sendButton;
        [Export("sendButton", ArgumentSemantic.Strong)]
        QMUIButton SendButton { get; }

        // @property (assign, nonatomic) UIEdgeInsets paddingInPage __attribute__((annotate("ui_appearance_selector")));
        [Export("paddingInPage", ArgumentSemantic.Assign)]
        UIEdgeInsets PaddingInPage { get; set; }

        // @property (assign, nonatomic) NSInteger numberOfRowsPerPage __attribute__((annotate("ui_appearance_selector")));
        [Export("numberOfRowsPerPage")]
        nint NumberOfRowsPerPage { get; set; }

        // @property (assign, nonatomic) CGSize emotionSize __attribute__((annotate("ui_appearance_selector")));
        [Export("emotionSize", ArgumentSemantic.Assign)]
        CGSize EmotionSize { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets emotionSelectedBackgroundExtension __attribute__((annotate("ui_appearance_selector")));
        [Export("emotionSelectedBackgroundExtension", ArgumentSemantic.Assign)]
        UIEdgeInsets EmotionSelectedBackgroundExtension { get; set; }

        // @property (assign, nonatomic) CGFloat minimumEmotionHorizontalSpacing __attribute__((annotate("ui_appearance_selector")));
        [Export("minimumEmotionHorizontalSpacing")]
        nfloat MinimumEmotionHorizontalSpacing { get; set; }

        // @property (nonatomic, strong) UIImage * deleteButtonImage __attribute__((annotate("ui_appearance_selector")));
        [Export("deleteButtonImage", ArgumentSemantic.Strong)]
        UIImage DeleteButtonImage { get; set; }

        // @property (nonatomic, strong) NSDictionary * sendButtonTitleAttributes __attribute__((annotate("ui_appearance_selector")));
        [Export("sendButtonTitleAttributes", ArgumentSemantic.Strong)]
        NSDictionary SendButtonTitleAttributes { get; set; }

        // @property (nonatomic, strong) UIColor * sendButtonBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [Export("sendButtonBackgroundColor", ArgumentSemantic.Strong)]
        UIColor SendButtonBackgroundColor { get; set; }

        // @property (assign, nonatomic) CGFloat sendButtonCornerRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("sendButtonCornerRadius")]
        nfloat SendButtonCornerRadius { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets sendButtonMargins __attribute__((annotate("ui_appearance_selector")));
        [Export("sendButtonMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets SendButtonMargins { get; set; }

        // @property (assign, nonatomic) CGFloat pageControlMarginBottom __attribute__((annotate("ui_appearance_selector")));
        [Export("pageControlMarginBottom")]
        nfloat PageControlMarginBottom { get; set; }
    }

    // @protocol QMUIEmptyViewLoadingViewProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIEmptyViewLoadingViewProtocol
    {
        // @optional -(void)startAnimating;
        [Export("startAnimating")]
        void StartAnimating();
    }

    // @interface QMUIEmptyView : UIView
    [BaseType(typeof(UIView))]
    interface QMUIEmptyView
    {
        // @property (nonatomic, strong) UIView<QMUIEmptyViewLoadingViewProtocol> * loadingView;
        [Export("loadingView", ArgumentSemantic.Strong)]
        QMUIEmptyViewLoadingViewProtocol LoadingView { get; set; }

        // @property (readonly, nonatomic, strong) UIImageView * imageView;
        [Export("imageView", ArgumentSemantic.Strong)]
        UIImageView ImageView { get; }

        // @property (readonly, nonatomic, strong) UILabel * textLabel;
        [Export("textLabel", ArgumentSemantic.Strong)]
        UILabel TextLabel { get; }

        // @property (readonly, nonatomic, strong) UILabel * detailTextLabel;
        [Export("detailTextLabel", ArgumentSemantic.Strong)]
        UILabel DetailTextLabel { get; }

        // @property (readonly, nonatomic, strong) QMUIButton * actionButton;
        [Export("actionButton", ArgumentSemantic.Strong)]
        QMUIButton ActionButton { get; }

        // @property (assign, nonatomic) UIEdgeInsets imageViewInsets __attribute__((annotate("ui_appearance_selector")));
        [Export("imageViewInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets ImageViewInsets { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets loadingViewInsets __attribute__((annotate("ui_appearance_selector")));
        [Export("loadingViewInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets LoadingViewInsets { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets textLabelInsets __attribute__((annotate("ui_appearance_selector")));
        [Export("textLabelInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets TextLabelInsets { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets detailTextLabelInsets __attribute__((annotate("ui_appearance_selector")));
        [Export("detailTextLabelInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets DetailTextLabelInsets { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets actionButtonInsets __attribute__((annotate("ui_appearance_selector")));
        [Export("actionButtonInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets ActionButtonInsets { get; set; }

        // @property (assign, nonatomic) CGFloat verticalOffset __attribute__((annotate("ui_appearance_selector")));
        [Export("verticalOffset")]
        nfloat VerticalOffset { get; set; }

        // @property (nonatomic, strong) UIFont * textLabelFont __attribute__((annotate("ui_appearance_selector")));
        [Export("textLabelFont", ArgumentSemantic.Strong)]
        UIFont TextLabelFont { get; set; }

        // @property (nonatomic, strong) UIFont * detailTextLabelFont __attribute__((annotate("ui_appearance_selector")));
        [Export("detailTextLabelFont", ArgumentSemantic.Strong)]
        UIFont DetailTextLabelFont { get; set; }

        // @property (nonatomic, strong) UIFont * actionButtonFont __attribute__((annotate("ui_appearance_selector")));
        [Export("actionButtonFont", ArgumentSemantic.Strong)]
        UIFont ActionButtonFont { get; set; }

        // @property (nonatomic, strong) UIColor * textLabelTextColor __attribute__((annotate("ui_appearance_selector")));
        [Export("textLabelTextColor", ArgumentSemantic.Strong)]
        UIColor TextLabelTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * detailTextLabelTextColor __attribute__((annotate("ui_appearance_selector")));
        [Export("detailTextLabelTextColor", ArgumentSemantic.Strong)]
        UIColor DetailTextLabelTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * actionButtonTitleColor __attribute__((annotate("ui_appearance_selector")));
        [Export("actionButtonTitleColor", ArgumentSemantic.Strong)]
        UIColor ActionButtonTitleColor { get; set; }

        // -(void)setLoadingViewHidden:(BOOL)hidden;
        [Export("setLoadingViewHidden:")]
        void SetLoadingViewHidden(bool hidden);

        // -(void)setImage:(UIImage *)image;
        [Export("setImage:")]
        void SetImage(UIImage image);

        // -(void)setTextLabelText:(NSString *)text;
        [Export("setTextLabelText:")]
        void SetTextLabelText(string text);

        // -(void)setDetailTextLabelText:(NSString *)text;
        [Export("setDetailTextLabelText:")]
        void SetDetailTextLabelText(string text);

        // -(void)setActionButtonTitle:(NSString *)title;
        [Export("setActionButtonTitle:")]
        void SetActionButtonTitle(string title);

        // @property (readonly, nonatomic, strong) UIView * contentView;
        [Export("contentView", ArgumentSemantic.Strong)]
        UIView ContentView { get; }

        // -(CGSize)sizeThatContentViewFits;
        [Export("sizeThatContentViewFits")]
        [Verify(MethodToProperty)]
        CGSize SizeThatContentViewFits { get; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const CGFloat QMUIFillButtonCornerRadiusAdjustsBounds;
        [Field("QMUIFillButtonCornerRadiusAdjustsBounds", "__Internal")]
        nfloat QMUIFillButtonCornerRadiusAdjustsBounds { get; }
    }

    // @interface QMUIFillButton : QMUIButton
    [BaseType(typeof(QMUIButton))]
    interface QMUIFillButton
    {
        // @property (nonatomic, strong) UIColor * _Nullable fillColor;
        [NullAllowed, Export("fillColor", ArgumentSemantic.Strong)]
        UIColor FillColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable titleTextColor;
        [NullAllowed, Export("titleTextColor", ArgumentSemantic.Strong)]
        UIColor TitleTextColor { get; set; }

        // @property (assign, nonatomic) CGFloat cornerRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (assign, nonatomic) BOOL adjustsImageWithTitleTextColor __attribute__((annotate("ui_appearance_selector")));
        [Export("adjustsImageWithTitleTextColor")]
        bool AdjustsImageWithTitleTextColor { get; set; }

        // -(instancetype _Nonnull)initWithFillType:(QMUIFillButtonColor)fillType;
        [Export("initWithFillType:")]
        IntPtr Constructor(QMUIFillButtonColor fillType);

        // -(instancetype _Nonnull)initWithFillType:(QMUIFillButtonColor)fillType frame:(CGRect)frame;
        [Export("initWithFillType:frame:")]
        IntPtr Constructor(QMUIFillButtonColor fillType, CGRect frame);

        // -(instancetype _Nonnull)initWithFillColor:(UIColor * _Nullable)fillColor titleTextColor:(UIColor * _Nullable)textColor;
        [Export("initWithFillColor:titleTextColor:")]
        IntPtr Constructor([NullAllowed] UIColor fillColor, [NullAllowed] UIColor textColor);

        // -(instancetype _Nonnull)initWithFillColor:(UIColor * _Nullable)fillColor titleTextColor:(UIColor * _Nullable)textColor frame:(CGRect)frame;
        [Export("initWithFillColor:titleTextColor:frame:")]
        IntPtr Constructor([NullAllowed] UIColor fillColor, [NullAllowed] UIColor textColor, CGRect frame);
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const CGSize QMUIFloatLayoutViewAutomaticalMaximumItemSize;
        [Field("QMUIFloatLayoutViewAutomaticalMaximumItemSize", "__Internal")]
        CGSize QMUIFloatLayoutViewAutomaticalMaximumItemSize { get; }
    }

    // @interface QMUIFloatLayoutView : UIView
    [BaseType(typeof(UIView))]
    interface QMUIFloatLayoutView
    {
        // @property (assign, nonatomic) UIEdgeInsets padding;
        [Export("padding", ArgumentSemantic.Assign)]
        UIEdgeInsets Padding { get; set; }

        // @property (assign, nonatomic) CGSize minimumItemSize;
        [Export("minimumItemSize", ArgumentSemantic.Assign)]
        CGSize MinimumItemSize { get; set; }

        // @property (assign, nonatomic) CGSize maximumItemSize;
        [Export("maximumItemSize", ArgumentSemantic.Assign)]
        CGSize MaximumItemSize { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets itemMargins;
        [Export("itemMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets ItemMargins { get; set; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const CGFloat QMUIGhostButtonCornerRadiusAdjustsBounds;
        [Field("QMUIGhostButtonCornerRadiusAdjustsBounds", "__Internal")]
        nfloat QMUIGhostButtonCornerRadiusAdjustsBounds { get; }
    }

    // @interface QMUIGhostButton : QMUIButton
    [BaseType(typeof(QMUIButton))]
    interface QMUIGhostButton
    {
        // @property (nonatomic, strong) UIColor * _Nullable ghostColor;
        [NullAllowed, Export("ghostColor", ArgumentSemantic.Strong)]
        UIColor GhostColor { get; set; }

        // @property (assign, nonatomic) CGFloat borderWidth __attribute__((annotate("ui_appearance_selector")));
        [Export("borderWidth")]
        nfloat BorderWidth { get; set; }

        // @property (assign, nonatomic) CGFloat cornerRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (assign, nonatomic) BOOL adjustsImageWithGhostColor __attribute__((annotate("ui_appearance_selector")));
        [Export("adjustsImageWithGhostColor")]
        bool AdjustsImageWithGhostColor { get; set; }

        // -(instancetype _Nonnull)initWithGhostType:(QMUIGhostButtonColor)ghostType;
        [Export("initWithGhostType:")]
        IntPtr Constructor(QMUIGhostButtonColor ghostType);

        // -(instancetype _Nonnull)initWithGhostColor:(UIColor * _Nullable)ghostColor;
        [Export("initWithGhostColor:")]
        IntPtr Constructor([NullAllowed] UIColor ghostColor);
    }

    // @interface QMUIGridView : UIView
    [BaseType(typeof(UIView))]
    interface QMUIGridView
    {
        // @property (assign, nonatomic) NSInteger columnCount;
        [Export("columnCount")]
        nint ColumnCount { get; set; }

        // @property (assign, nonatomic) CGFloat rowHeight;
        [Export("rowHeight")]
        nfloat RowHeight { get; set; }

        // @property (assign, nonatomic) CGFloat separatorWidth;
        [Export("separatorWidth")]
        nfloat SeparatorWidth { get; set; }

        // @property (nonatomic, strong) UIColor * separatorColor;
        [Export("separatorColor", ArgumentSemantic.Strong)]
        UIColor SeparatorColor { get; set; }

        // @property (assign, nonatomic) BOOL separatorDashed;
        [Export("separatorDashed")]
        bool SeparatorDashed { get; set; }

        // -(instancetype)initWithColumn:(NSInteger)column rowHeight:(CGFloat)rowHeight;
        [Export("initWithColumn:rowHeight:")]
        IntPtr Constructor(nint column, nfloat rowHeight);
    }

    // @interface QMUIImagePickerCollectionViewCell : UICollectionViewCell
    [BaseType(typeof(UICollectionViewCell))]
    interface QMUIImagePickerCollectionViewCell
    {
        // @property (nonatomic, strong) UIImage * favoriteImage __attribute__((annotate("ui_appearance_selector")));
        [Export("favoriteImage", ArgumentSemantic.Strong)]
        UIImage FavoriteImage { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets favoriteImageMargins __attribute__((annotate("ui_appearance_selector")));
        [Export("favoriteImageMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets FavoriteImageMargins { get; set; }

        // @property (nonatomic, strong) UIImage * checkboxImage __attribute__((annotate("ui_appearance_selector")));
        [Export("checkboxImage", ArgumentSemantic.Strong)]
        UIImage CheckboxImage { get; set; }

        // @property (nonatomic, strong) UIImage * checkboxCheckedImage __attribute__((annotate("ui_appearance_selector")));
        [Export("checkboxCheckedImage", ArgumentSemantic.Strong)]
        UIImage CheckboxCheckedImage { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets checkboxButtonMargins __attribute__((annotate("ui_appearance_selector")));
        [Export("checkboxButtonMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets CheckboxButtonMargins { get; set; }

        // @property (nonatomic, strong) UIFont * videoDurationLabelFont __attribute__((annotate("ui_appearance_selector")));
        [Export("videoDurationLabelFont", ArgumentSemantic.Strong)]
        UIFont VideoDurationLabelFont { get; set; }

        // @property (nonatomic, strong) UIColor * videoDurationLabelTextColor __attribute__((annotate("ui_appearance_selector")));
        [Export("videoDurationLabelTextColor", ArgumentSemantic.Strong)]
        UIColor VideoDurationLabelTextColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets videoDurationLabelMargins __attribute__((annotate("ui_appearance_selector")));
        [Export("videoDurationLabelMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets VideoDurationLabelMargins { get; set; }

        // @property (readonly, nonatomic, strong) UIImageView * contentImageView;
        [Export("contentImageView", ArgumentSemantic.Strong)]
        UIImageView ContentImageView { get; }

        // @property (readonly, nonatomic, strong) UIImageView * favoriteImageView;
        [Export("favoriteImageView", ArgumentSemantic.Strong)]
        UIImageView FavoriteImageView { get; }

        // @property (readonly, nonatomic, strong) QMUIButton * checkboxButton;
        [Export("checkboxButton", ArgumentSemantic.Strong)]
        QMUIButton CheckboxButton { get; }

        // @property (readonly, nonatomic, strong) UILabel * videoDurationLabel;
        [Export("videoDurationLabel", ArgumentSemantic.Strong)]
        UILabel VideoDurationLabel { get; }

        // @property (readonly, nonatomic, strong) CAGradientLayer * bottomShadowLayer;
        [Export("bottomShadowLayer", ArgumentSemantic.Strong)]
        CAGradientLayer BottomShadowLayer { get; }

        // @property (getter = isSelectable, assign, nonatomic) BOOL selectable;
        [Export("selectable")]
        bool Selectable { [Bind("isSelectable")] get; set; }

        // @property (getter = isChecked, assign, nonatomic) BOOL checked;
        [Export("checked")]
        bool Checked { [Bind("isChecked")] get; set; }

        // @property (assign, nonatomic) QMUIAssetDownloadStatus downloadStatus;
        [Export("downloadStatus", ArgumentSemantic.Assign)]
        QMUIAssetDownloadStatus DownloadStatus { get; set; }

        // @property (copy, nonatomic) NSString * assetIdentifier;
        [Export("assetIdentifier")]
        string AssetIdentifier { get; set; }

        // -(void)renderWithAsset:(QMUIAsset *)asset referenceSize:(CGSize)referenceSize;
        [Export("renderWithAsset:referenceSize:")]
        void RenderWithAsset(QMUIAsset asset, CGSize referenceSize);
    }

    // @interface QMUIImagePickerHelper : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIImagePickerHelper
    {
        // +(void)springAnimationOfImageSelectedCountChangeWithCountLabel:(UILabel *)label;
        [Static]
        [Export("springAnimationOfImageSelectedCountChangeWithCountLabel:")]
        void SpringAnimationOfImageSelectedCountChangeWithCountLabel(UILabel label);

        // +(void)springAnimationOfImageCheckedWithCheckboxButton:(UIButton *)button;
        [Static]
        [Export("springAnimationOfImageCheckedWithCheckboxButton:")]
        void SpringAnimationOfImageCheckedWithCheckboxButton(UIButton button);

        // +(void)removeSpringAnimationOfImageCheckedWithCheckboxButton:(UIButton *)button;
        [Static]
        [Export("removeSpringAnimationOfImageCheckedWithCheckboxButton:")]
        void RemoveSpringAnimationOfImageCheckedWithCheckboxButton(UIButton button);

        // +(QMUIAssetsGroup *)assetsGroupOfLastPickerAlbumWithUserIdentify:(NSString *)userIdentify;
        [Static]
        [Export("assetsGroupOfLastPickerAlbumWithUserIdentify:")]
        QMUIAssetsGroup AssetsGroupOfLastPickerAlbumWithUserIdentify(string userIdentify);

        // +(void)updateLastestAlbumWithAssetsGroup:(QMUIAssetsGroup *)assetsGroup ablumContentType:(QMUIAlbumContentType)albumContentType userIdentify:(NSString *)userIdentify;
        [Static]
        [Export("updateLastestAlbumWithAssetsGroup:ablumContentType:userIdentify:")]
        void UpdateLastestAlbumWithAssetsGroup(QMUIAssetsGroup assetsGroup, QMUIAlbumContentType albumContentType, string userIdentify);

        // +(BOOL)imageAssetsDownloaded:(NSMutableArray<QMUIAsset *> *)imagesAssetArray;
        [Static]
        [Export("imageAssetsDownloaded:")]
        bool ImageAssetsDownloaded(NSMutableArray<QMUIAsset> imagesAssetArray);

        // +(void)requestImageAssetIfNeeded:(QMUIAsset *)asset completion:(void (^)(QMUIAssetDownloadStatus, NSError *))completion;
        [Static]
        [Export("requestImageAssetIfNeeded:completion:")]
        void RequestImageAssetIfNeeded(QMUIAsset asset, Action<QMUIAssetDownloadStatus, NSError> completion);
    }

    // @protocol QMUIZoomImageViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIZoomImageViewDelegate
    {
        // @optional -(void)singleTouchInZoomingImageView:(QMUIZoomImageView *)zoomImageView location:(CGPoint)location;
        [Export("singleTouchInZoomingImageView:location:")]
        void SingleTouchInZoomingImageView(QMUIZoomImageView zoomImageView, CGPoint location);

        // @optional -(void)doubleTouchInZoomingImageView:(QMUIZoomImageView *)zoomImageView location:(CGPoint)location;
        [Export("doubleTouchInZoomingImageView:location:")]
        void DoubleTouchInZoomingImageView(QMUIZoomImageView zoomImageView, CGPoint location);

        // @optional -(void)longPressInZoomingImageView:(QMUIZoomImageView *)zoomImageView;
        [Export("longPressInZoomingImageView:")]
        void LongPressInZoomingImageView(QMUIZoomImageView zoomImageView);

        // @optional -(void)didTouchICloudRetryButtonInZoomImageView:(QMUIZoomImageView *)imageView;
        [Export("didTouchICloudRetryButtonInZoomImageView:")]
        void DidTouchICloudRetryButtonInZoomImageView(QMUIZoomImageView imageView);

        // @optional -(void)zoomImageView:(QMUIZoomImageView *)imageView didHideVideoToolbar:(BOOL)didHide;
        [Export("zoomImageView:didHideVideoToolbar:")]
        void ZoomImageView(QMUIZoomImageView imageView, bool didHide);

        // @optional -(BOOL)enabledZoomViewInZoomImageView:(QMUIZoomImageView *)zoomImageView;
        [Export("enabledZoomViewInZoomImageView:")]
        bool EnabledZoomViewInZoomImageView(QMUIZoomImageView zoomImageView);
    }

    // @interface QMUIZoomImageView : UIView <UIScrollViewDelegate>
    [BaseType(typeof(UIView))]
    interface QMUIZoomImageView : IUIScrollViewDelegate
    {
        [Wrap("WeakDelegate")]
        QMUIZoomImageViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<QMUIZoomImageViewDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic, strong) UIScrollView * scrollView;
        [Export("scrollView", ArgumentSemantic.Strong)]
        UIScrollView ScrollView { get; }

        // @property (assign, nonatomic) CGRect viewportRect;
        [Export("viewportRect", ArgumentSemantic.Assign)]
        CGRect ViewportRect { get; set; }

        // @property (assign, nonatomic) CGFloat maximumZoomScale;
        [Export("maximumZoomScale")]
        nfloat MaximumZoomScale { get; set; }

        // @property (copy, nonatomic) NSObject<NSCopying> * reusedIdentifier;
        [Export("reusedIdentifier", ArgumentSemantic.Copy)]
        NSCopying ReusedIdentifier { get; set; }

        // @property (nonatomic, weak) UIImage * image;
        [Export("image", ArgumentSemantic.Weak)]
        UIImage Image { get; set; }

        // @property (readonly, nonatomic, strong) UIImageView * imageView;
        [Export("imageView", ArgumentSemantic.Strong)]
        UIImageView ImageView { get; }

        // @property (nonatomic, weak) PHLivePhoto * livePhoto;
        [Export("livePhoto", ArgumentSemantic.Weak)]
        PHLivePhoto LivePhoto { get; set; }

        // @property (readonly, nonatomic, strong) PHLivePhotoView * livePhotoView;
        [Export("livePhotoView", ArgumentSemantic.Strong)]
        PHLivePhotoView LivePhotoView { get; }

        // @property (nonatomic, weak) AVPlayerItem * videoPlayerItem;
        [Export("videoPlayerItem", ArgumentSemantic.Weak)]
        AVPlayerItem VideoPlayerItem { get; set; }

        // @property (readonly, nonatomic, weak) AVPlayerLayer * videoPlayerLayer;
        [Export("videoPlayerLayer", ArgumentSemantic.Weak)]
        AVPlayerLayer VideoPlayerLayer { get; }

        // @property (readonly, nonatomic, strong) QMUIZoomImageViewVideoToolbar * videoToolbar;
        [Export("videoToolbar", ArgumentSemantic.Strong)]
        QMUIZoomImageViewVideoToolbar VideoToolbar { get; }

        // @property (assign, nonatomic) UIEdgeInsets videoToolbarMargins __attribute__((annotate("ui_appearance_selector")));
        [Export("videoToolbarMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets VideoToolbarMargins { get; set; }

        // @property (readonly, nonatomic, strong) QMUIButton * videoCenteredPlayButton;
        [Export("videoCenteredPlayButton", ArgumentSemantic.Strong)]
        QMUIButton VideoCenteredPlayButton { get; }

        // @property (nonatomic, strong) UIImage * videoCenteredPlayButtonImage __attribute__((annotate("ui_appearance_selector")));
        [Export("videoCenteredPlayButtonImage", ArgumentSemantic.Strong)]
        UIImage VideoCenteredPlayButtonImage { get; set; }

        // @property (nonatomic, strong) QMUIPieProgressView * cloudProgressView;
        [Export("cloudProgressView", ArgumentSemantic.Strong)]
        QMUIPieProgressView CloudProgressView { get; set; }

        // @property (nonatomic, strong) QMUIButton * cloudDownloadRetryButton;
        [Export("cloudDownloadRetryButton", ArgumentSemantic.Strong)]
        QMUIButton CloudDownloadRetryButton { get; set; }

        // @property (assign, nonatomic) QMUIAssetDownloadStatus cloudDownloadStatus;
        [Export("cloudDownloadStatus", ArgumentSemantic.Assign)]
        QMUIAssetDownloadStatus CloudDownloadStatus { get; set; }

        // -(void)pauseVideo;
        [Export("pauseVideo")]
        void PauseVideo();

        // -(void)endPlayingVideo;
        [Export("endPlayingVideo")]
        void EndPlayingVideo();

        // @property (readonly, nonatomic, weak) __kindof UIView * contentView;
        [Export("contentView", ArgumentSemantic.Weak)]
        UIView ContentView { get; }

        // -(CGRect)contentViewRectInZoomImageView;
        [Export("contentViewRectInZoomImageView")]
        [Verify(MethodToProperty)]
        CGRect ContentViewRectInZoomImageView { get; }

        // -(void)revertZooming;
        [Export("revertZooming")]
        void RevertZooming();

        // @property (readonly, nonatomic, strong) QMUIEmptyView * emptyView;
        [Export("emptyView", ArgumentSemantic.Strong)]
        QMUIEmptyView EmptyView { get; }

        // -(void)showLoading;
        [Export("showLoading")]
        void ShowLoading();

        // -(void)showEmptyViewWithText:(NSString *)text;
        [Export("showEmptyViewWithText:")]
        void ShowEmptyViewWithText(string text);

        // -(void)showEmptyViewWithText:(NSString *)text detailText:(NSString *)detailText buttonTitle:(NSString *)buttonTitle buttonTarget:(id)buttonTarget buttonAction:(SEL)action;
        [Export("showEmptyViewWithText:detailText:buttonTitle:buttonTarget:buttonAction:")]
        void ShowEmptyViewWithText(string text, string detailText, string buttonTitle, NSObject buttonTarget, Selector action);

        // -(void)hideEmptyView;
        [Export("hideEmptyView")]
        void HideEmptyView();
    }

    // @interface QMUIZoomImageViewVideoToolbar : UIView
    [BaseType(typeof(UIView))]
    interface QMUIZoomImageViewVideoToolbar
    {
        // @property (readonly, nonatomic, strong) QMUIButton * playButton;
        [Export("playButton", ArgumentSemantic.Strong)]
        QMUIButton PlayButton { get; }

        // @property (readonly, nonatomic, strong) QMUIButton * pauseButton;
        [Export("pauseButton", ArgumentSemantic.Strong)]
        QMUIButton PauseButton { get; }

        // @property (readonly, nonatomic, strong) QMUISlider * slider;
        [Export("slider", ArgumentSemantic.Strong)]
        QMUISlider Slider { get; }

        // @property (readonly, nonatomic, strong) UILabel * sliderLeftLabel;
        [Export("sliderLeftLabel", ArgumentSemantic.Strong)]
        UILabel SliderLeftLabel { get; }

        // @property (readonly, nonatomic, strong) UILabel * sliderRightLabel;
        [Export("sliderRightLabel", ArgumentSemantic.Strong)]
        UILabel SliderRightLabel { get; }

        // @property (assign, nonatomic) UIEdgeInsets paddings __attribute__((annotate("ui_appearance_selector")));
        [Export("paddings", ArgumentSemantic.Assign)]
        UIEdgeInsets Paddings { get; set; }

        // @property (nonatomic, strong) UIImage * playButtonImage __attribute__((annotate("ui_appearance_selector")));
        [Export("playButtonImage", ArgumentSemantic.Strong)]
        UIImage PlayButtonImage { get; set; }

        // @property (nonatomic, strong) UIImage * pauseButtonImage __attribute__((annotate("ui_appearance_selector")));
        [Export("pauseButtonImage", ArgumentSemantic.Strong)]
        UIImage PauseButtonImage { get; set; }
    }

    interface IQMUIZoomImageViewDelegate { 
    }

    // @protocol QMUIImagePreviewViewDelegate <QMUIZoomImageViewDelegate>
    [Protocol, Model]
    interface QMUIImagePreviewViewDelegate : IQMUIZoomImageViewDelegate
    {
        // @required -(NSUInteger)numberOfImagesInImagePreviewView:(QMUIImagePreviewView *)imagePreviewView;
        [Abstract]
        [Export("numberOfImagesInImagePreviewView:")]
        nuint NumberOfImagesInImagePreviewView(QMUIImagePreviewView imagePreviewView);

        // @required -(void)imagePreviewView:(QMUIImagePreviewView *)imagePreviewView renderZoomImageView:(QMUIZoomImageView *)zoomImageView atIndex:(NSUInteger)index;
        [Abstract]
        [Export("imagePreviewView:renderZoomImageView:atIndex:")]
        void ImagePreviewView(QMUIImagePreviewView imagePreviewView, QMUIZoomImageView zoomImageView, nuint index);

        // @optional -(QMUIImagePreviewMediaType)imagePreviewView:(QMUIImagePreviewView *)imagePreviewView assetTypeAtIndex:(NSUInteger)index;
        [Export("imagePreviewView:assetTypeAtIndex:")]
        QMUIImagePreviewMediaType ImagePreviewView(QMUIImagePreviewView imagePreviewView, nuint index);

        // @optional -(void)imagePreviewView:(QMUIImagePreviewView *)imagePreviewView didScrollToIndex:(NSUInteger)index;
        [Export("imagePreviewView:didScrollToIndex:")]
        void ImagePreviewView(QMUIImagePreviewView imagePreviewView, nuint index);

        // @optional -(void)imagePreviewView:(QMUIImagePreviewView *)imagePreviewView willScrollHalfToIndex:(NSUInteger)index;
        [Export("imagePreviewView:willScrollHalfToIndex:")]
        void ImagePreviewView(QMUIImagePreviewView imagePreviewView, nuint index);
    }

    // @interface QMUIImagePreviewView : UIView <UICollectionViewDataSource, UICollectionViewDelegateFlowLayout>
    [BaseType(typeof(UIView))]
    interface QMUIImagePreviewView : IUICollectionViewDataSource, IUICollectionViewDelegateFlowLayout
    {
        [Wrap("WeakDelegate")]
        QMUIImagePreviewViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<QMUIImagePreviewViewDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic, strong) UICollectionView * collectionView;
        [Export("collectionView", ArgumentSemantic.Strong)]
        UICollectionView CollectionView { get; }

        // @property (readonly, nonatomic, strong) QMUICollectionViewPagingLayout * collectionViewLayout;
        [Export("collectionViewLayout", ArgumentSemantic.Strong)]
        QMUICollectionViewPagingLayout CollectionViewLayout { get; }

        // @property (assign, nonatomic) NSUInteger currentImageIndex;
        [Export("currentImageIndex")]
        nuint CurrentImageIndex { get; set; }

        // -(void)setCurrentImageIndex:(NSUInteger)currentImageIndex animated:(BOOL)animated;
        [Export("setCurrentImageIndex:animated:")]
        void SetCurrentImageIndex(nuint currentImageIndex, bool animated);

        // @property (nonatomic, strong) UIColor * loadingColor;
        [Export("loadingColor", ArgumentSemantic.Strong)]
        UIColor LoadingColor { get; set; }
    }

    // @interface QMUIZoomImageView (QMUIImagePreviewView) <QMUIZoomImageViewDelegate>
    [Category]
    [BaseType(typeof(QMUIImagePreviewView))]
    interface QMUIImagePreviewView_QMUIZoomImageView : IQMUIZoomImageViewDelegate
    {
        // -(NSInteger)indexForZoomImageView:(QMUIZoomImageView *)zoomImageView;
        [Export("indexForZoomImageView:")]
        nint IndexForZoomImageView(QMUIZoomImageView zoomImageView);

        // -(QMUIZoomImageView *)zoomImageViewAtIndex:(NSUInteger)index;
        [Export("zoomImageViewAtIndex:")]
        QMUIZoomImageView ZoomImageViewAtIndex(nuint index);
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //	// extern const CGFloat QMUIImagePreviewViewControllerCornerRadiusAutomaticDimension;
    //	[Field("QMUIImagePreviewViewControllerCornerRadiusAutomaticDimension", "__Internal")]
    //	nfloat QMUIImagePreviewViewControllerCornerRadiusAutomaticDimension { get; }
    //}

    // @interface QMUIImagePreviewViewController : QMUICommonViewController <UIViewControllerTransitioningDelegate>
    [BaseType(typeof(QMUICommonViewController))]
    interface QMUIImagePreviewViewController : IUIViewControllerTransitioningDelegate
    {
        // @property (nonatomic, strong) UIColor * _Nullable backgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (readonly, nonatomic, strong) QMUIImagePreviewView * _Null_unspecified imagePreviewView;
        [Export("imagePreviewView", ArgumentSemantic.Strong)]
        QMUIImagePreviewView ImagePreviewView { get; }

        // @property (nonatomic, strong) __kindof QMUIImagePreviewViewTransitionAnimator * _Nullable transitioningAnimator;
        [Export("transitioningAnimator", ArgumentSemantic.Strong)]
        QMUIImagePreviewViewTransitionAnimator TransitioningAnimator { get; set; }

        // @property (assign, nonatomic) QMUIImagePreviewViewControllerTransitioningStyle presentingStyle;
        [Export("presentingStyle", ArgumentSemantic.Assign)]
        QMUIImagePreviewViewControllerTransitioningStyle PresentingStyle { get; set; }

        // @property (assign, nonatomic) QMUIImagePreviewViewControllerTransitioningStyle dismissingStyle;
        [Export("dismissingStyle", ArgumentSemantic.Assign)]
        QMUIImagePreviewViewControllerTransitioningStyle DismissingStyle { get; set; }

        // @property (copy, nonatomic) UIView * _Nullable (^ _Nullable)(void) sourceImageView;
        [NullAllowed, Export("sourceImageView", ArgumentSemantic.Copy)]
        Func<UIView> SourceImageView { get; set; }

        // @property (copy, nonatomic) CGRect (^ _Nullable)(void) sourceImageRect;
        [NullAllowed, Export("sourceImageRect", ArgumentSemantic.Copy)]
        Func<CGRect> SourceImageRect { get; set; }

        // @property (assign, nonatomic) CGFloat sourceImageCornerRadius;
        [Export("sourceImageCornerRadius")]
        nfloat SourceImageCornerRadius { get; set; }

        // @property (assign, nonatomic) BOOL dismissingGestureEnabled;
        [Export("dismissingGestureEnabled")]
        bool DismissingGestureEnabled { get; set; }
    }

    // @interface UIAppearance (QMUIImagePreviewViewController)
    [Category]
    [BaseType(typeof(QMUIImagePreviewViewController))]
    interface QMUIImagePreviewViewController_UIAppearance
    {
        // +(instancetype _Nonnull)appearance;
        [Static]
        [Export("appearance")]
        QMUIImagePreviewViewController Appearance();
    }

    // @protocol QMUIImagePickerPreviewViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIImagePickerPreviewViewControllerDelegate
    {
        // @optional -(void)imagePickerPreviewViewControllerDidCancel:(QMUIImagePickerPreviewViewController * _Nonnull)imagePickerPreviewViewController;
        [Export("imagePickerPreviewViewControllerDidCancel:")]
        void ImagePickerPreviewViewControllerDidCancel(QMUIImagePickerPreviewViewController imagePickerPreviewViewController);

        // @optional -(void)imagePickerPreviewViewController:(QMUIImagePickerPreviewViewController * _Nonnull)imagePickerPreviewViewController willCheckImageAtIndex:(NSInteger)index;
        [Export("imagePickerPreviewViewController:willCheckImageAtIndex:")]
        void ImagePickerPreviewViewController(QMUIImagePickerPreviewViewController imagePickerPreviewViewController, nint index);

        // @optional -(void)imagePickerPreviewViewController:(QMUIImagePickerPreviewViewController * _Nonnull)imagePickerPreviewViewController didCheckImageAtIndex:(NSInteger)index;
        [Export("imagePickerPreviewViewController:didCheckImageAtIndex:")]
        void ImagePickerPreviewViewController(QMUIImagePickerPreviewViewController imagePickerPreviewViewController, nint index);

        // @optional -(void)imagePickerPreviewViewController:(QMUIImagePickerPreviewViewController * _Nonnull)imagePickerPreviewViewController willUncheckImageAtIndex:(NSInteger)index;
        [Export("imagePickerPreviewViewController:willUncheckImageAtIndex:")]
        void ImagePickerPreviewViewController(QMUIImagePickerPreviewViewController imagePickerPreviewViewController, nint index);

        // @optional -(void)imagePickerPreviewViewController:(QMUIImagePickerPreviewViewController * _Nonnull)imagePickerPreviewViewController didUncheckImageAtIndex:(NSInteger)index;
        [Export("imagePickerPreviewViewController:didUncheckImageAtIndex:")]
        void ImagePickerPreviewViewController(QMUIImagePickerPreviewViewController imagePickerPreviewViewController, nint index);
    }

    interface IQMUIImagePreviewViewDelegate { 
    }

    // @interface QMUIImagePickerPreviewViewController : QMUIImagePreviewViewController <QMUIImagePreviewViewDelegate>
    [BaseType(typeof(QMUIImagePreviewViewController))]
    interface QMUIImagePickerPreviewViewController : IQMUIImagePreviewViewDelegate
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        QMUIImagePickerPreviewViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<QMUIImagePickerPreviewViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable toolBarBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("toolBarBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ToolBarBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable toolBarTintColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("toolBarTintColor", ArgumentSemantic.Strong)]
        UIColor ToolBarTintColor { get; set; }

        // @property (readonly, nonatomic, strong) UIView * _Nullable topToolBarView;
        [NullAllowed, Export("topToolBarView", ArgumentSemantic.Strong)]
        UIView TopToolBarView { get; }

        // @property (readonly, nonatomic, strong) QMUINavigationButton * _Nullable backButton;
        [NullAllowed, Export("backButton", ArgumentSemantic.Strong)]
        QMUINavigationButton BackButton { get; }

        // @property (readonly, nonatomic, strong) QMUIButton * _Nullable checkboxButton;
        [NullAllowed, Export("checkboxButton", ArgumentSemantic.Strong)]
        QMUIButton CheckboxButton { get; }

        // @property (nonatomic, strong) NSMutableArray<QMUIAsset *> * _Nullable imagesAssetArray;
        [NullAllowed, Export("imagesAssetArray", ArgumentSemantic.Strong)]
        NSMutableArray<QMUIAsset> ImagesAssetArray { get; set; }

        // @property (nonatomic, strong) NSMutableArray<QMUIAsset *> * _Nullable selectedImageAssetArray;
        [NullAllowed, Export("selectedImageAssetArray", ArgumentSemantic.Strong)]
        NSMutableArray<QMUIAsset> SelectedImageAssetArray { get; set; }

        // @property (assign, nonatomic) QMUIAssetDownloadStatus downloadStatus;
        [Export("downloadStatus", ArgumentSemantic.Assign)]
        QMUIAssetDownloadStatus DownloadStatus { get; set; }

        // @property (assign, nonatomic) NSUInteger maximumSelectImageCount;
        [Export("maximumSelectImageCount")]
        nuint MaximumSelectImageCount { get; set; }

        // @property (assign, nonatomic) NSUInteger minimumSelectImageCount;
        [Export("minimumSelectImageCount")]
        nuint MinimumSelectImageCount { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable alertTitleWhenExceedMaxSelectImageCount;
        [NullAllowed, Export("alertTitleWhenExceedMaxSelectImageCount")]
        string AlertTitleWhenExceedMaxSelectImageCount { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable alertButtonTitleWhenExceedMaxSelectImageCount;
        [NullAllowed, Export("alertButtonTitleWhenExceedMaxSelectImageCount")]
        string AlertButtonTitleWhenExceedMaxSelectImageCount { get; set; }

        // -(void)updateImagePickerPreviewViewWithImagesAssetArray:(NSMutableArray<QMUIAsset *> * _Nullable)imageAssetArray selectedImageAssetArray:(NSMutableArray<QMUIAsset *> * _Nullable)selectedImageAssetArray currentImageIndex:(NSInteger)currentImageIndex singleCheckMode:(BOOL)singleCheckMode;
        [Export("updateImagePickerPreviewViewWithImagesAssetArray:selectedImageAssetArray:currentImageIndex:singleCheckMode:")]
        void UpdateImagePickerPreviewViewWithImagesAssetArray([NullAllowed] NSMutableArray<QMUIAsset> imageAssetArray, [NullAllowed] NSMutableArray<QMUIAsset> selectedImageAssetArray, nint currentImageIndex, bool singleCheckMode);
    }

    // @interface UIAppearance (QMUIImagePickerPreviewViewController)
    [Category]
    [BaseType(typeof(QMUIImagePickerPreviewViewController))]
    interface QMUIImagePickerPreviewViewController_UIAppearance
    {
        // +(instancetype _Nonnull)appearance;
        [Static]
        [Export("appearance")]
        QMUIImagePickerPreviewViewController Appearance();
    }

    // @protocol QMUIImagePickerViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIImagePickerViewControllerDelegate
    {
        // @optional -(QMUIImagePickerPreviewViewController * _Nonnull)imagePickerPreviewViewControllerForImagePickerViewController:(QMUIImagePickerViewController * _Nonnull)imagePickerViewController;
        [Export("imagePickerPreviewViewControllerForImagePickerViewController:")]
        QMUIImagePickerPreviewViewController ImagePickerPreviewViewControllerForImagePickerViewController(QMUIImagePickerViewController imagePickerViewController);

        // @optional -(QMUIAlbumSortType)albumSortTypeForImagePickerViewController:(QMUIImagePickerViewController * _Nonnull)imagePickerViewController;
        [Export("albumSortTypeForImagePickerViewController:")]
        QMUIAlbumSortType AlbumSortTypeForImagePickerViewController(QMUIImagePickerViewController imagePickerViewController);

        // @optional -(void)imagePickerViewController:(QMUIImagePickerViewController * _Nonnull)imagePickerViewController didFinishPickingImageWithImagesAssetArray:(NSMutableArray<QMUIAsset *> * _Nonnull)imagesAssetArray;
        [Export("imagePickerViewController:didFinishPickingImageWithImagesAssetArray:")]
        void ImagePickerViewController(QMUIImagePickerViewController imagePickerViewController, NSMutableArray<QMUIAsset> imagesAssetArray);

        // @optional -(void)imagePickerViewController:(QMUIImagePickerViewController * _Nonnull)imagePickerViewController didSelectImageWithImagesAsset:(QMUIAsset * _Nonnull)imageAsset afterImagePickerPreviewViewControllerUpdate:(QMUIImagePickerPreviewViewController * _Nonnull)imagePickerPreviewViewController;
        [Export("imagePickerViewController:didSelectImageWithImagesAsset:afterImagePickerPreviewViewControllerUpdate:")]
        void ImagePickerViewController(QMUIImagePickerViewController imagePickerViewController, QMUIAsset imageAsset, QMUIImagePickerPreviewViewController imagePickerPreviewViewController);

        // @optional -(BOOL)imagePickerViewController:(QMUIImagePickerViewController * _Nonnull)imagePickerViewController shouldCheckImageAtIndex:(NSInteger)index;
        [Export("imagePickerViewController:shouldCheckImageAtIndex:")]
        bool ImagePickerViewController(QMUIImagePickerViewController imagePickerViewController, nint index);

        // @optional -(void)imagePickerViewController:(QMUIImagePickerViewController * _Nonnull)imagePickerViewController willCheckImageAtIndex:(NSInteger)index;
        [Export("imagePickerViewController:willCheckImageAtIndex:")]
        void ImagePickerViewController(QMUIImagePickerViewController imagePickerViewController, nint index);

        // @optional -(void)imagePickerViewController:(QMUIImagePickerViewController * _Nonnull)imagePickerViewController didCheckImageAtIndex:(NSInteger)index;
        [Export("imagePickerViewController:didCheckImageAtIndex:")]
        void ImagePickerViewController(QMUIImagePickerViewController imagePickerViewController, nint index);

        // @optional -(void)imagePickerViewController:(QMUIImagePickerViewController * _Nonnull)imagePickerViewController willUncheckImageAtIndex:(NSInteger)index;
        [Export("imagePickerViewController:willUncheckImageAtIndex:")]
        void ImagePickerViewController(QMUIImagePickerViewController imagePickerViewController, nint index);

        // @optional -(void)imagePickerViewController:(QMUIImagePickerViewController * _Nonnull)imagePickerViewController didUncheckImageAtIndex:(NSInteger)index;
        [Export("imagePickerViewController:didUncheckImageAtIndex:")]
        void ImagePickerViewController(QMUIImagePickerViewController imagePickerViewController, nint index);

        // @optional -(void)imagePickerViewControllerDidCancel:(QMUIImagePickerViewController * _Nonnull)imagePickerViewController;
        [Export("imagePickerViewControllerDidCancel:")]
        void ImagePickerViewControllerDidCancel(QMUIImagePickerViewController imagePickerViewController);

        // @optional -(void)imagePickerViewControllerWillStartLoading:(QMUIImagePickerViewController * _Nonnull)imagePickerViewController;
        [Export("imagePickerViewControllerWillStartLoading:")]
        void ImagePickerViewControllerWillStartLoading(QMUIImagePickerViewController imagePickerViewController);

        // @optional -(void)imagePickerViewControllerDidFinishLoading:(QMUIImagePickerViewController * _Nonnull)imagePickerViewController;
        [Export("imagePickerViewControllerDidFinishLoading:")]
        void ImagePickerViewControllerDidFinishLoading(QMUIImagePickerViewController imagePickerViewController);
    }

    // @interface QMUIImagePickerViewController : QMUICommonViewController <UICollectionViewDataSource, UICollectionViewDelegate, QMUIImagePickerPreviewViewControllerDelegate>
    [BaseType(typeof(QMUICommonViewController))]
    interface QMUIImagePickerViewController : IUICollectionViewDataSource, IUICollectionViewDelegate, IQMUIImagePickerPreviewViewControllerDelegate
    {
        [Wrap("WeakImagePickerViewControllerDelegate")]
        [NullAllowed]
        QMUIImagePickerViewControllerDelegate ImagePickerViewControllerDelegate { get; set; }

        // @property (nonatomic, weak) id<QMUIImagePickerViewControllerDelegate> _Nullable imagePickerViewControllerDelegate;
        [NullAllowed, Export("imagePickerViewControllerDelegate", ArgumentSemantic.Weak)]
        NSObject WeakImagePickerViewControllerDelegate { get; set; }

        // @property (assign, nonatomic) CGFloat minimumImageWidth __attribute__((annotate("ui_appearance_selector")));
        [Export("minimumImageWidth")]
        nfloat MinimumImageWidth { get; set; }

        // @property (readonly, nonatomic, strong) UICollectionViewFlowLayout * _Nullable collectionViewLayout;
        [NullAllowed, Export("collectionViewLayout", ArgumentSemantic.Strong)]
        UICollectionViewFlowLayout CollectionViewLayout { get; }

        // @property (readonly, nonatomic, strong) UICollectionView * _Nullable collectionView;
        [NullAllowed, Export("collectionView", ArgumentSemantic.Strong)]
        UICollectionView CollectionView { get; }

        // @property (readonly, nonatomic, strong) UIView * _Nullable operationToolBarView;
        [NullAllowed, Export("operationToolBarView", ArgumentSemantic.Strong)]
        UIView OperationToolBarView { get; }

        // @property (readonly, nonatomic, strong) QMUIButton * _Nullable previewButton;
        [NullAllowed, Export("previewButton", ArgumentSemantic.Strong)]
        QMUIButton PreviewButton { get; }

        // @property (readonly, nonatomic, strong) QMUIButton * _Nullable sendButton;
        [NullAllowed, Export("sendButton", ArgumentSemantic.Strong)]
        QMUIButton SendButton { get; }

        // @property (readonly, nonatomic, strong) UILabel * _Nullable imageCountLabel;
        [NullAllowed, Export("imageCountLabel", ArgumentSemantic.Strong)]
        UILabel ImageCountLabel { get; }

        // -(void)refreshWithAssetsGroup:(QMUIAssetsGroup * _Nullable)assetsGroup;
        [Export("refreshWithAssetsGroup:")]
        void RefreshWithAssetsGroup([NullAllowed] QMUIAssetsGroup assetsGroup);

        // @property (readonly, nonatomic, strong) NSMutableArray<QMUIAsset *> * _Nullable imagesAssetArray;
        [NullAllowed, Export("imagesAssetArray", ArgumentSemantic.Strong)]
        NSMutableArray<QMUIAsset> ImagesAssetArray { get; }

        // @property (readonly, nonatomic, strong) QMUIAssetsGroup * _Nullable assetsGroup;
        [NullAllowed, Export("assetsGroup", ArgumentSemantic.Strong)]
        QMUIAssetsGroup AssetsGroup { get; }

        // @property (readonly, nonatomic, strong) NSMutableArray<QMUIAsset *> * _Nullable selectedImageAssetArray;
        [NullAllowed, Export("selectedImageAssetArray", ArgumentSemantic.Strong)]
        NSMutableArray<QMUIAsset> SelectedImageAssetArray { get; }

        // @property (assign, nonatomic) BOOL allowsMultipleSelection;
        [Export("allowsMultipleSelection")]
        bool AllowsMultipleSelection { get; set; }

        // @property (assign, nonatomic) NSUInteger maximumSelectImageCount;
        [Export("maximumSelectImageCount")]
        nuint MaximumSelectImageCount { get; set; }

        // @property (assign, nonatomic) NSUInteger minimumSelectImageCount;
        [Export("minimumSelectImageCount")]
        nuint MinimumSelectImageCount { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable alertTitleWhenExceedMaxSelectImageCount;
        [NullAllowed, Export("alertTitleWhenExceedMaxSelectImageCount")]
        string AlertTitleWhenExceedMaxSelectImageCount { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable alertButtonTitleWhenExceedMaxSelectImageCount;
        [NullAllowed, Export("alertButtonTitleWhenExceedMaxSelectImageCount")]
        string AlertButtonTitleWhenExceedMaxSelectImageCount { get; set; }

        // @property (assign, nonatomic) BOOL shouldShowDefaultLoadingView;
        [Export("shouldShowDefaultLoadingView")]
        bool ShouldShowDefaultLoadingView { get; set; }
    }

    // @interface UIAppearance (QMUIImagePickerViewController)
    [Category]
    [BaseType(typeof(QMUIImagePickerViewController))]
    interface QMUIImagePickerViewController_UIAppearance
    {
        // +(instancetype _Nonnull)appearance;
        [Static]
        [Export("appearance")]
        QMUIImagePickerViewController Appearance();
    }

    // @interface QMUIImagePreviewViewTransitionAnimator : NSObject <UIViewControllerAnimatedTransitioning>
    [BaseType(typeof(NSObject))]
    interface QMUIImagePreviewViewTransitionAnimator : IUIViewControllerAnimatedTransitioning
    {
        // @property (nonatomic, weak) QMUIImagePreviewViewController * _Nullable imagePreviewViewController;
        [NullAllowed, Export("imagePreviewViewController", ArgumentSemantic.Weak)]
        QMUIImagePreviewViewController ImagePreviewViewController { get; set; }

        // @property (assign, nonatomic) NSTimeInterval duration;
        [Export("duration")]
        double Duration { get; set; }

        // @property (readonly, nonatomic, strong) CALayer * _Nonnull cornerRadiusMaskLayer;
        [Export("cornerRadiusMaskLayer", ArgumentSemantic.Strong)]
        CALayer CornerRadiusMaskLayer { get; }

        // @property (copy, nonatomic) void (^ _Nonnull)(__kindof QMUIImagePreviewViewTransitionAnimator * _Nonnull, BOOL, QMUIImagePreviewViewControllerTransitioningStyle, CGRect, QMUIZoomImageView * _Nonnull, id<UIViewControllerContextTransitioning> _Nullable) animationEnteringBlock;
        [Export("animationEnteringBlock", ArgumentSemantic.Copy)]
        Action<QMUIImagePreviewViewTransitionAnimator, bool, QMUIImagePreviewViewControllerTransitioningStyle, CGRect, QMUIZoomImageView, UIViewControllerContextTransitioning> AnimationEnteringBlock { get; set; }

        // @property (copy, nonatomic) void (^ _Nonnull)(__kindof QMUIImagePreviewViewTransitionAnimator * _Nonnull, BOOL, QMUIImagePreviewViewControllerTransitioningStyle, CGRect, QMUIZoomImageView * _Nonnull, id<UIViewControllerContextTransitioning> _Nullable) animationBlock;
        [Export("animationBlock", ArgumentSemantic.Copy)]
        Action<QMUIImagePreviewViewTransitionAnimator, bool, QMUIImagePreviewViewControllerTransitioningStyle, CGRect, QMUIZoomImageView, UIViewControllerContextTransitioning> AnimationBlock { get; set; }

        // @property (copy, nonatomic) void (^ _Nonnull)(__kindof QMUIImagePreviewViewTransitionAnimator * _Nonnull, BOOL, QMUIImagePreviewViewControllerTransitioningStyle, CGRect, QMUIZoomImageView * _Nonnull, id<UIViewControllerContextTransitioning> _Nullable) animationCompletionBlock;
        [Export("animationCompletionBlock", ArgumentSemantic.Copy)]
        Action<QMUIImagePreviewViewTransitionAnimator, bool, QMUIImagePreviewViewControllerTransitioningStyle, CGRect, QMUIZoomImageView, UIViewControllerContextTransitioning> AnimationCompletionBlock { get; set; }
    }

    // @interface QMUILabel : UILabel
    [BaseType(typeof(UILabel))]
    interface QMUILabel
    {
        // @property (assign, nonatomic) UIEdgeInsets contentEdgeInsets;
        [Export("contentEdgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets ContentEdgeInsets { get; set; }

        // @property (assign, nonatomic) BOOL canPerformCopyAction;
        [Export("canPerformCopyAction")]
        bool CanPerformCopyAction { get; set; }

        // @property (copy, nonatomic) NSString * menuItemTitleForCopyAction;
        [Export("menuItemTitleForCopyAction")]
        string MenuItemTitleForCopyAction { get; set; }

        // @property (nonatomic, strong) UIColor * highlightedBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [Export("highlightedBackgroundColor", ArgumentSemantic.Strong)]
        UIColor HighlightedBackgroundColor { get; set; }

        // @property (copy, nonatomic) void (^didCopyBlock)(QMUILabel *, NSString *);
        [Export("didCopyBlock", ArgumentSemantic.Copy)]
        Action<QMUILabel, NSString> DidCopyBlock { get; set; }
    }

    // @interface QMUILinkButton : QMUIButton
    [BaseType(typeof(QMUIButton))]
    interface QMUILinkButton
    {
        // @property (assign, nonatomic) BOOL underlineHidden;
        [Export("underlineHidden")]
        bool UnderlineHidden { get; set; }

        // @property (assign, nonatomic) CGFloat underlineWidth;
        [Export("underlineWidth")]
        nfloat UnderlineWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable underlineColor;
        [NullAllowed, Export("underlineColor", ArgumentSemantic.Strong)]
        UIColor UnderlineColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets underlineInsets;
        [Export("underlineInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets UnderlineInsets { get; set; }
    }

    // @interface QMUILogManagerViewController : QMUICommonTableViewController
    [BaseType(typeof(QMUICommonTableViewController))]
    interface QMUILogManagerViewController
    {
        // @property (assign, nonatomic) NSUInteger rowCountWhenShowSearchBar;
        [Export("rowCountWhenShowSearchBar")]
        nuint RowCountWhenShowSearchBar { get; set; }

        // @property (copy, nonatomic) NSString * (^formatLogNameForSortingBlock)(NSString *);
        [Export("formatLogNameForSortingBlock", ArgumentSemantic.Copy)]
        Func<NSString, NSString> FormatLogNameForSortingBlock { get; set; }

        // @property (copy, nonatomic) NSAttributedString * (^formatCellTextBlock)(NSString *);
        [Export("formatCellTextBlock", ArgumentSemantic.Copy)]
        Func<NSString, NSAttributedString> FormatCellTextBlock { get; set; }
    }

    // @interface QMUIConfigurationTemplate (QMUILogger)
    [Category]
    [BaseType(typeof(QMUILogger))]
    interface QMUILogger_QMUIConfigurationTemplate
    {
    }

    // @interface QMUIMarqueeLabel : UILabel
    [BaseType(typeof(UILabel))]
    interface QMUIMarqueeLabel
    {
        // @property (assign, nonatomic) CGFloat speed;
        [Export("speed")]
        nfloat Speed { get; set; }

        // @property (assign, nonatomic) NSTimeInterval pauseDurationWhenMoveToEdge;
        [Export("pauseDurationWhenMoveToEdge")]
        double PauseDurationWhenMoveToEdge { get; set; }

        // @property (assign, nonatomic) CGFloat spacingBetweenHeadToTail;
        [Export("spacingBetweenHeadToTail")]
        nfloat SpacingBetweenHeadToTail { get; set; }

        // @property (assign, nonatomic) CGFloat fadeWidthPercent;
        [Export("fadeWidthPercent")]
        nfloat FadeWidthPercent { get; set; }

        // @property (assign, nonatomic) BOOL automaticallyValidateVisibleFrame;
        [Export("automaticallyValidateVisibleFrame")]
        bool AutomaticallyValidateVisibleFrame { get; set; }

        // @property (assign, nonatomic) BOOL shouldFadeAtEdge;
        [Export("shouldFadeAtEdge")]
        bool ShouldFadeAtEdge { get; set; }

        // @property (assign, nonatomic) BOOL textStartAfterFade;
        [Export("textStartAfterFade")]
        bool TextStartAfterFade { get; set; }
    }

    // @interface ReusableView (QMUIMarqueeLabel)
    [Category]
    [BaseType(typeof(QMUIMarqueeLabel))]
    interface QMUIMarqueeLabel_ReusableView
    {
        // -(BOOL)requestToStartAnimation;
        [Export("requestToStartAnimation")]
        [Verify(MethodToProperty)]
        bool RequestToStartAnimation { get; }

        // -(BOOL)requestToStopAnimation;
        [Export("requestToStopAnimation")]
        [Verify(MethodToProperty)]
        bool RequestToStopAnimation { get; }
    }

    // @protocol QMUIMoreOperationControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIMoreOperationControllerDelegate
    {
        // @optional -(void)willPresentMoreOperationController:(QMUIMoreOperationController * _Nonnull)moreOperationController;
        [Export("willPresentMoreOperationController:")]
        void WillPresentMoreOperationController(QMUIMoreOperationController moreOperationController);

        // @optional -(void)didPresentMoreOperationController:(QMUIMoreOperationController * _Nonnull)moreOperationController;
        [Export("didPresentMoreOperationController:")]
        void DidPresentMoreOperationController(QMUIMoreOperationController moreOperationController);

        // @optional -(void)willDismissMoreOperationController:(QMUIMoreOperationController * _Nonnull)moreOperationController cancelled:(BOOL)cancelled;
        [Export("willDismissMoreOperationController:cancelled:")]
        void WillDismissMoreOperationController(QMUIMoreOperationController moreOperationController, bool cancelled);

        // @optional -(void)didDismissMoreOperationController:(QMUIMoreOperationController * _Nonnull)moreOperationController cancelled:(BOOL)cancelled;
        [Export("didDismissMoreOperationController:cancelled:")]
        void DidDismissMoreOperationController(QMUIMoreOperationController moreOperationController, bool cancelled);

        // @optional -(void)moreOperationController:(QMUIMoreOperationController * _Nonnull)moreOperationController didSelectItemView:(QMUIMoreOperationItemView * _Nonnull)itemView;
        [Export("moreOperationController:didSelectItemView:")]
        void MoreOperationController(QMUIMoreOperationController moreOperationController, QMUIMoreOperationItemView itemView);
    }

    // @interface QMUIMoreOperationController : UIViewController <QMUIModalPresentationContentViewControllerProtocol, QMUIModalPresentationViewControllerDelegate, QMUIModalPresentationComponentProtocol>
    [BaseType(typeof(UIViewController))]
    interface QMUIMoreOperationController : IQMUIModalPresentationContentViewControllerProtocol, IQMUIModalPresentationViewControllerDelegate, IQMUIModalPresentationComponentProtocol
    {
        // @property (nonatomic, strong) UIColor * _Nullable contentBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("contentBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ContentBackgroundColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets contentEdgeMargins __attribute__((annotate("ui_appearance_selector")));
        [Export("contentEdgeMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets ContentEdgeMargins { get; set; }

        // @property (assign, nonatomic) CGFloat contentMaximumWidth __attribute__((annotate("ui_appearance_selector")));
        [Export("contentMaximumWidth")]
        nfloat ContentMaximumWidth { get; set; }

        // @property (assign, nonatomic) CGFloat contentCornerRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("contentCornerRadius")]
        nfloat ContentCornerRadius { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets contentPaddings __attribute__((annotate("ui_appearance_selector")));
        [Export("contentPaddings", ArgumentSemantic.Assign)]
        UIEdgeInsets ContentPaddings { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable scrollViewSeparatorColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("scrollViewSeparatorColor", ArgumentSemantic.Strong)]
        UIColor ScrollViewSeparatorColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets scrollViewContentInsets __attribute__((annotate("ui_appearance_selector")));
        [Export("scrollViewContentInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets ScrollViewContentInsets { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable itemBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("itemBackgroundColor", ArgumentSemantic.Strong)]
        UIColor ItemBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable itemTitleColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("itemTitleColor", ArgumentSemantic.Strong)]
        UIColor ItemTitleColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable itemTitleFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("itemTitleFont", ArgumentSemantic.Strong)]
        UIFont ItemTitleFont { get; set; }

        // @property (assign, nonatomic) CGFloat itemPaddingHorizontal __attribute__((annotate("ui_appearance_selector")));
        [Export("itemPaddingHorizontal")]
        nfloat ItemPaddingHorizontal { get; set; }

        // @property (assign, nonatomic) CGFloat itemTitleMarginTop __attribute__((annotate("ui_appearance_selector")));
        [Export("itemTitleMarginTop")]
        nfloat ItemTitleMarginTop { get; set; }

        // @property (assign, nonatomic) CGFloat itemMinimumMarginHorizontal __attribute__((annotate("ui_appearance_selector")));
        [Export("itemMinimumMarginHorizontal")]
        nfloat ItemMinimumMarginHorizontal { get; set; }

        // @property (assign, nonatomic) BOOL automaticallyAdjustItemMargins __attribute__((annotate("ui_appearance_selector")));
        [Export("automaticallyAdjustItemMargins")]
        bool AutomaticallyAdjustItemMargins { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable cancelButtonBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("cancelButtonBackgroundColor", ArgumentSemantic.Strong)]
        UIColor CancelButtonBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable cancelButtonTitleColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("cancelButtonTitleColor", ArgumentSemantic.Strong)]
        UIColor CancelButtonTitleColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable cancelButtonSeparatorColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("cancelButtonSeparatorColor", ArgumentSemantic.Strong)]
        UIColor CancelButtonSeparatorColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable cancelButtonFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("cancelButtonFont", ArgumentSemantic.Strong)]
        UIFont CancelButtonFont { get; set; }

        // @property (assign, nonatomic) CGFloat cancelButtonHeight __attribute__((annotate("ui_appearance_selector")));
        [Export("cancelButtonHeight")]
        nfloat CancelButtonHeight { get; set; }

        // @property (assign, nonatomic) CGFloat cancelButtonMarginTop __attribute__((annotate("ui_appearance_selector")));
        [Export("cancelButtonMarginTop")]
        nfloat CancelButtonMarginTop { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        QMUIMoreOperationControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<QMUIMoreOperationControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic, strong) UIView * _Nullable contentView;
        [NullAllowed, Export("contentView", ArgumentSemantic.Strong)]
        UIView ContentView { get; }

        // @property (readonly, copy, nonatomic) NSArray<UIScrollView *> * _Nullable scrollViews;
        [NullAllowed, Export("scrollViews", ArgumentSemantic.Copy)]
        UIScrollView[] ScrollViews { get; }

        // @property (readonly, nonatomic, strong) QMUIButton * _Nullable cancelButton;
        [NullAllowed, Export("cancelButton", ArgumentSemantic.Strong)]
        QMUIButton CancelButton { get; }

        // @property (assign, nonatomic) BOOL isExtendBottomLayout __attribute__((annotate("ui_appearance_selector")));
        [Export("isExtendBottomLayout")]
        bool IsExtendBottomLayout { get; set; }

        // @property (copy, nonatomic) NSArray<NSArray<QMUIMoreOperationItemView *> *> * _Nullable items;
        [NullAllowed, Export("items", ArgumentSemantic.Copy)]
        NSArray<QMUIMoreOperationItemView>[] Items { get; set; }

        // -(void)addItemView:(QMUIMoreOperationItemView * _Nonnull)itemView inSection:(NSInteger)section;
        [Export("addItemView:inSection:")]
        void AddItemView(QMUIMoreOperationItemView itemView, nint section);

        // -(void)insertItemView:(QMUIMoreOperationItemView * _Nonnull)itemView atIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("insertItemView:atIndexPath:")]
        void InsertItemView(QMUIMoreOperationItemView itemView, NSIndexPath indexPath);

        // -(void)removeItemViewAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("removeItemViewAtIndexPath:")]
        void RemoveItemViewAtIndexPath(NSIndexPath indexPath);

        // -(QMUIMoreOperationItemView * _Nullable)itemViewWithTag:(NSInteger)tag;
        [Export("itemViewWithTag:")]
        [return: NullAllowed]
        QMUIMoreOperationItemView ItemViewWithTag(nint tag);

        // -(NSIndexPath * _Nullable)indexPathWithItemView:(QMUIMoreOperationItemView * _Nonnull)itemView;
        [Export("indexPathWithItemView:")]
        [return: NullAllowed]
        NSIndexPath IndexPathWithItemView(QMUIMoreOperationItemView itemView);

        // -(void)showFromBottom;
        [Export("showFromBottom")]
        void ShowFromBottom();

        // -(void)hideToBottom;
        [Export("hideToBottom")]
        void HideToBottom();

        // @property (readonly, getter = isShowing, assign, nonatomic) BOOL showing;
        [Export("showing")]
        bool Showing { [Bind("isShowing")] get; }

        // @property (readonly, getter = isAnimating, assign, nonatomic) BOOL animating;
        [Export("animating")]
        bool Animating { [Bind("isAnimating")] get; }
    }

    // @interface UIAppearance (QMUIMoreOperationController)
    [Category]
    [BaseType(typeof(QMUIMoreOperationController))]
    interface QMUIMoreOperationController_UIAppearance
    {
        // +(instancetype _Nonnull)appearance;
        [Static]
        [Export("appearance")]
        QMUIMoreOperationController Appearance();
    }

    // @interface QMUIMoreOperationItemView : QMUIButton
    [BaseType(typeof(QMUIButton))]
    interface QMUIMoreOperationItemView
    {
        // @property (readonly, nonatomic, strong) NSIndexPath * _Nullable indexPath;
        [NullAllowed, Export("indexPath", ArgumentSemantic.Strong)]
        NSIndexPath IndexPath { get; }

        // @property (assign, nonatomic) NSInteger tag;
        [Export("tag")]
        nint Tag { get; set; }

        // +(instancetype _Nonnull)itemViewWithImage:(UIImage * _Nullable)image title:(NSString * _Nullable)title handler:(void (^ _Nullable)(QMUIMoreOperationController * _Nonnull, QMUIMoreOperationItemView * _Nonnull))handler;
        [Static]
        [Export("itemViewWithImage:title:handler:")]
        QMUIMoreOperationItemView ItemViewWithImage([NullAllowed] UIImage image, [NullAllowed] string title, [NullAllowed] Action<QMUIMoreOperationController, QMUIMoreOperationItemView> handler);

        // +(instancetype _Nonnull)itemViewWithImage:(UIImage * _Nullable)image selectedImage:(UIImage * _Nullable)selectedImage title:(NSString * _Nullable)title selectedTitle:(NSString * _Nullable)selectedTitle handler:(void (^ _Nullable)(QMUIMoreOperationController * _Nonnull, QMUIMoreOperationItemView * _Nonnull))handler;
        [Static]
        [Export("itemViewWithImage:selectedImage:title:selectedTitle:handler:")]
        QMUIMoreOperationItemView ItemViewWithImage([NullAllowed] UIImage image, [NullAllowed] UIImage selectedImage, [NullAllowed] string title, [NullAllowed] string selectedTitle, [NullAllowed] Action<QMUIMoreOperationController, QMUIMoreOperationItemView> handler);

        // +(instancetype _Nonnull)itemViewWithImage:(UIImage * _Nullable)image title:(NSString * _Nullable)title tag:(NSInteger)tag handler:(void (^ _Nullable)(QMUIMoreOperationController * _Nonnull, QMUIMoreOperationItemView * _Nonnull))handler;
        [Static]
        [Export("itemViewWithImage:title:tag:handler:")]
        QMUIMoreOperationItemView ItemViewWithImage([NullAllowed] UIImage image, [NullAllowed] string title, nint tag, [NullAllowed] Action<QMUIMoreOperationController, QMUIMoreOperationItemView> handler);

        // +(instancetype _Nonnull)itemViewWithImage:(UIImage * _Nullable)image selectedImage:(UIImage * _Nullable)selectedImage title:(NSString * _Nullable)title selectedTitle:(NSString * _Nullable)selectedTitle tag:(NSInteger)tag handler:(void (^ _Nullable)(QMUIMoreOperationController * _Nonnull, QMUIMoreOperationItemView * _Nonnull))handler;
        [Static]
        [Export("itemViewWithImage:selectedImage:title:selectedTitle:tag:handler:")]
        QMUIMoreOperationItemView ItemViewWithImage([NullAllowed] UIImage image, [NullAllowed] UIImage selectedImage, [NullAllowed] string title, [NullAllowed] string selectedTitle, nint tag, [NullAllowed] Action<QMUIMoreOperationController, QMUIMoreOperationItemView> handler);
    }

    // @interface QMUIMultipleDelegates : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIMultipleDelegates
    {
        // +(instancetype)weakDelegates;
        [Static]
        [Export("weakDelegates")]
        QMUIMultipleDelegates WeakDelegates();

        // +(instancetype)strongDelegates;
        [Static]
        [Export("strongDelegates")]
        QMUIMultipleDelegates StrongDelegates();

        // @property (readonly, nonatomic, strong) NSPointerArray * delegates;
        [Export("delegates", ArgumentSemantic.Strong)]
        NSPointerArray Delegates { get; }

        // @property (nonatomic, weak) NSObject * parentObject;
        [Export("parentObject", ArgumentSemantic.Weak)]
        NSObject ParentObject { get; set; }

        // -(void)addDelegate:(id)delegate;
        [Export("addDelegate:")]
        void AddDelegate(NSObject @delegate);

        // -(BOOL)removeDelegate:(id)delegate;
        [Export("removeDelegate:")]
        bool RemoveDelegate(NSObject @delegate);

        // -(void)removeAllDelegates;
        [Export("removeAllDelegates")]
        void RemoveAllDelegates();

        // -(BOOL)containsDelegate:(id)delegate;
        [Export("containsDelegate:")]
        bool ContainsDelegate(NSObject @delegate);
    }

    // @interface QMUIScrollAnimator : NSObject <UIScrollViewDelegate>
    [BaseType(typeof(NSObject))]
    interface QMUIScrollAnimator : IUIScrollViewDelegate
    {
        // @property (nonatomic, weak) __kindof UIScrollView * _Nullable scrollView;
        [Export("scrollView", ArgumentSemantic.Weak)]
        UIScrollView ScrollView { get; set; }

        // @property (copy, nonatomic) void (^ _Nonnull)(__kindof QMUIScrollAnimator * _Nonnull) didScrollBlock;
        [Export("didScrollBlock", ArgumentSemantic.Copy)]
        Action<QMUIScrollAnimator> DidScrollBlock { get; set; }

        // @property (assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }

        // -(void)updateScroll;
        [Export("updateScroll")]
        void UpdateScroll();
    }

    // @interface QMUINavigationBarScrollingAnimator : QMUIScrollAnimator
    [BaseType(typeof(QMUIScrollAnimator))]
    interface QMUINavigationBarScrollingAnimator
    {
        // @property (nonatomic, weak) UINavigationBar * _Nullable navigationBar;
        [NullAllowed, Export("navigationBar", ArgumentSemantic.Weak)]
        UINavigationBar NavigationBar { get; set; }

        // @property (assign, nonatomic) CGFloat offsetYToStartAnimation;
        [Export("offsetYToStartAnimation")]
        nfloat OffsetYToStartAnimation { get; set; }

        // @property (assign, nonatomic) CGFloat distanceToStopAnimation;
        [Export("distanceToStopAnimation")]
        nfloat DistanceToStopAnimation { get; set; }

        // @property (assign, nonatomic) BOOL adjustsOffsetYWithInsetTopAutomatically;
        [Export("adjustsOffsetYWithInsetTopAutomatically")]
        bool AdjustsOffsetYWithInsetTopAutomatically { get; set; }

        // @property (readonly, assign, nonatomic) float progress;
        [Export("progress")]
        float Progress { get; }

        // @property (assign, nonatomic) BOOL continuous;
        [Export("continuous")]
        bool Continuous { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(QMUINavigationBarScrollingAnimator * _Nonnull, float) animationBlock;
        [NullAllowed, Export("animationBlock", ArgumentSemantic.Copy)]
        Action<QMUINavigationBarScrollingAnimator, float> AnimationBlock { get; set; }

        // @property (copy, nonatomic) UIImage * _Nonnull (^ _Nullable)(QMUINavigationBarScrollingAnimator * _Nonnull, float) backgroundImageBlock;
        [NullAllowed, Export("backgroundImageBlock", ArgumentSemantic.Copy)]
        Func<QMUINavigationBarScrollingAnimator, float, UIImage> BackgroundImageBlock { get; set; }

        // @property (copy, nonatomic) UIImage * _Nonnull (^ _Nullable)(QMUINavigationBarScrollingAnimator * _Nonnull, float) shadowImageBlock;
        [NullAllowed, Export("shadowImageBlock", ArgumentSemantic.Copy)]
        Func<QMUINavigationBarScrollingAnimator, float, UIImage> ShadowImageBlock { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull (^ _Nullable)(QMUINavigationBarScrollingAnimator * _Nonnull, float) tintColorBlock;
        [NullAllowed, Export("tintColorBlock", ArgumentSemantic.Copy)]
        Func<QMUINavigationBarScrollingAnimator, float, UIColor> TintColorBlock { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull (^ _Nullable)(QMUINavigationBarScrollingAnimator * _Nonnull, float) titleViewTintColorBlock;
        [NullAllowed, Export("titleViewTintColorBlock", ArgumentSemantic.Copy)]
        Func<QMUINavigationBarScrollingAnimator, float, UIColor> TitleViewTintColorBlock { get; set; }

        // @property (copy, nonatomic) UIStatusBarStyle (^ _Nullable)(QMUINavigationBarScrollingAnimator * _Nonnull, float) statusbarStyleBlock;
        [NullAllowed, Export("statusbarStyleBlock", ArgumentSemantic.Copy)]
        Func<QMUINavigationBarScrollingAnimator, float, UIStatusBarStyle> StatusbarStyleBlock { get; set; }

        // @property (copy, nonatomic) UIColor * _Nonnull (^ _Nonnull)(QMUINavigationBarScrollingAnimator * _Nonnull, float) barTintColorBlock;
        [Export("barTintColorBlock", ArgumentSemantic.Copy)]
        Func<QMUINavigationBarScrollingAnimator, float, UIColor> BarTintColorBlock { get; set; }
    }

    // @interface QMUINavigationBarScrollingSnapAnimator : QMUIScrollAnimator
    [BaseType(typeof(QMUIScrollAnimator))]
    interface QMUINavigationBarScrollingSnapAnimator
    {
        // @property (nonatomic, weak) UINavigationBar * _Nullable navigationBar;
        [NullAllowed, Export("navigationBar", ArgumentSemantic.Weak)]
        UINavigationBar NavigationBar { get; set; }

        // @property (assign, nonatomic) CGFloat offsetYToStartAnimation;
        [Export("offsetYToStartAnimation")]
        nfloat OffsetYToStartAnimation { get; set; }

        // @property (assign, nonatomic) BOOL adjustsOffsetYWithInsetTopAutomatically;
        [Export("adjustsOffsetYWithInsetTopAutomatically")]
        bool AdjustsOffsetYWithInsetTopAutomatically { get; set; }

        // @property (copy, nonatomic) void (^ _Nonnull)(QMUINavigationBarScrollingSnapAnimator * _Nonnull, BOOL) animationBlock;
        [Export("animationBlock", ArgumentSemantic.Copy)]
        Action<QMUINavigationBarScrollingSnapAnimator, bool> AnimationBlock { get; set; }

        // @property (readonly, assign, nonatomic) BOOL offsetYReached;
        [Export("offsetYReached")]
        bool OffsetYReached { get; }

        // @property (assign, nonatomic) BOOL continuous;
        [Export("continuous")]
        bool Continuous { get; set; }
    }

    // @interface QMUINavigationButton : UIButton
    [BaseType(typeof(UIButton))]
    interface QMUINavigationButton
    {
        // @property (readonly, assign, nonatomic) QMUINavigationButtonType type;
        [Export("type", ArgumentSemantic.Assign)]
        QMUINavigationButtonType Type { get; }

        // @property (assign, nonatomic) BOOL adjustsImageTintColorAutomatically;
        [Export("adjustsImageTintColorAutomatically")]
        bool AdjustsImageTintColorAutomatically { get; set; }

        // -(instancetype _Nonnull)initWithType:(QMUINavigationButtonType)type title:(NSString * _Nullable)title;
        [Export("initWithType:title:")]
        IntPtr Constructor(QMUINavigationButtonType type, [NullAllowed] string title);

        // -(instancetype _Nonnull)initWithType:(QMUINavigationButtonType)type;
        [Export("initWithType:")]
        IntPtr Constructor(QMUINavigationButtonType type);

        // -(instancetype _Nonnull)initWithImage:(UIImage * _Nullable)image;
        [Export("initWithImage:")]
        IntPtr Constructor([NullAllowed] UIImage image);
    }

    // @interface QMUINavigationButton (UIBarButtonItem)
    [Category]
    [BaseType(typeof(UIBarButtonItem))]
    interface UIBarButtonItem_QMUINavigationButton
    {
        // +(instancetype _Nonnull)qmui_itemWithButton:(QMUINavigationButton * _Nonnull)button target:(id _Nullable)target action:(SEL _Nullable)action;
        [Static]
        [Export("qmui_itemWithButton:target:action:")]
        UIBarButtonItem Qmui_itemWithButton(QMUINavigationButton button, [NullAllowed] NSObject target, [NullAllowed] Selector action);

        // +(instancetype _Nonnull)qmui_itemWithImage:(UIImage * _Nonnull)image target:(id _Nullable)target action:(SEL _Nullable)action;
        [Static]
        [Export("qmui_itemWithImage:target:action:")]
        UIBarButtonItem Qmui_itemWithImage(UIImage image, [NullAllowed] NSObject target, [NullAllowed] Selector action);

        // +(instancetype _Nonnull)qmui_itemWithTitle:(NSString * _Nonnull)title target:(id _Nullable)target action:(SEL _Nullable)action;
        [Static]
        [Export("qmui_itemWithTitle:target:action:")]
        UIBarButtonItem Qmui_itemWithTitle(string title, [NullAllowed] NSObject target, [NullAllowed] Selector action);

        // +(instancetype _Nonnull)qmui_itemWithBoldTitle:(NSString * _Nonnull)title target:(id _Nullable)target action:(SEL _Nullable)action;
        [Static]
        [Export("qmui_itemWithBoldTitle:target:action:")]
        UIBarButtonItem Qmui_itemWithBoldTitle(string title, [NullAllowed] NSObject target, [NullAllowed] Selector action);

        // +(instancetype _Nonnull)qmui_backItemWithTitle:(NSString * _Nullable)title target:(id _Nullable)target action:(SEL _Nullable)action;
        [Static]
        [Export("qmui_backItemWithTitle:target:action:")]
        UIBarButtonItem Qmui_backItemWithTitle([NullAllowed] string title, [NullAllowed] NSObject target, [NullAllowed] Selector action);

        // +(instancetype _Nonnull)qmui_backItemWithTarget:(id _Nullable)target action:(SEL _Nullable)action;
        [Static]
        [Export("qmui_backItemWithTarget:action:")]
        UIBarButtonItem Qmui_backItemWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector action);

        // +(instancetype _Nonnull)qmui_closeItemWithTarget:(id _Nullable)target action:(SEL _Nullable)action;
        [Static]
        [Export("qmui_closeItemWithTarget:action:")]
        UIBarButtonItem Qmui_closeItemWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector action);

        // +(instancetype _Nonnull)qmui_fixedSpaceItemWithWidth:(CGFloat)width;
        [Static]
        [Export("qmui_fixedSpaceItemWithWidth:")]
        UIBarButtonItem Qmui_fixedSpaceItemWithWidth(nfloat width);

        // +(instancetype _Nonnull)qmui_flexibleSpaceItem;
        [Static]
        [Export("qmui_flexibleSpaceItem")]
        UIBarButtonItem Qmui_flexibleSpaceItem();
    }

    // @protocol QMUINavigationTitleViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUINavigationTitleViewDelegate
    {
        // @optional -(void)didTouchTitleView:(QMUINavigationTitleView *)titleView isActive:(BOOL)isActive;
        [Export("didTouchTitleView:isActive:")]
        void DidTouchTitleView(QMUINavigationTitleView titleView, bool isActive);

        // @optional -(void)didChangedActive:(BOOL)active forTitleView:(QMUINavigationTitleView *)titleView;
        [Export("didChangedActive:forTitleView:")]
        void DidChangedActive(bool active, QMUINavigationTitleView titleView);
    }

    // @interface QMUINavigationTitleView : UIControl
    [BaseType(typeof(UIControl))]
    interface QMUINavigationTitleView
    {
        [Wrap("WeakDelegate")]
        QMUINavigationTitleViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<QMUINavigationTitleViewDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) QMUINavigationTitleViewStyle style;
        [Export("style", ArgumentSemantic.Assign)]
        QMUINavigationTitleViewStyle Style { get; set; }

        // @property (getter = isActive, assign, nonatomic) BOOL active;
        [Export("active")]
        bool Active { [Bind("isActive")] get; set; }

        // @property (assign, nonatomic) CGFloat maximumWidth __attribute__((annotate("ui_appearance_selector")));
        [Export("maximumWidth")]
        nfloat MaximumWidth { get; set; }

        // @property (readonly, nonatomic, strong) UILabel * titleLabel;
        [Export("titleLabel", ArgumentSemantic.Strong)]
        UILabel TitleLabel { get; }

        // @property (copy, nonatomic) NSString * title;
        [Export("title")]
        string Title { get; set; }

        // @property (readonly, nonatomic, strong) UILabel * subtitleLabel;
        [Export("subtitleLabel", ArgumentSemantic.Strong)]
        UILabel SubtitleLabel { get; }

        // @property (copy, nonatomic) NSString * subtitle;
        [Export("subtitle")]
        string Subtitle { get; set; }

        // @property (assign, nonatomic) BOOL adjustsSubviewsTintColorAutomatically __attribute__((annotate("ui_appearance_selector")));
        [Export("adjustsSubviewsTintColorAutomatically")]
        bool AdjustsSubviewsTintColorAutomatically { get; set; }

        // @property (nonatomic, strong) UIFont * horizontalTitleFont __attribute__((annotate("ui_appearance_selector")));
        [Export("horizontalTitleFont", ArgumentSemantic.Strong)]
        UIFont HorizontalTitleFont { get; set; }

        // @property (nonatomic, strong) UIFont * horizontalSubtitleFont __attribute__((annotate("ui_appearance_selector")));
        [Export("horizontalSubtitleFont", ArgumentSemantic.Strong)]
        UIFont HorizontalSubtitleFont { get; set; }

        // @property (nonatomic, strong) UIFont * verticalTitleFont __attribute__((annotate("ui_appearance_selector")));
        [Export("verticalTitleFont", ArgumentSemantic.Strong)]
        UIFont VerticalTitleFont { get; set; }

        // @property (nonatomic, strong) UIFont * verticalSubtitleFont __attribute__((annotate("ui_appearance_selector")));
        [Export("verticalSubtitleFont", ArgumentSemantic.Strong)]
        UIFont VerticalSubtitleFont { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets titleEdgeInsets __attribute__((annotate("ui_appearance_selector")));
        [Export("titleEdgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets TitleEdgeInsets { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets subtitleEdgeInsets __attribute__((annotate("ui_appearance_selector")));
        [Export("subtitleEdgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets SubtitleEdgeInsets { get; set; }

        // @property (readonly, nonatomic, strong) UIActivityIndicatorView * loadingView;
        [Export("loadingView", ArgumentSemantic.Strong)]
        UIActivityIndicatorView LoadingView { get; }

        // @property (assign, nonatomic) BOOL needsLoadingView;
        [Export("needsLoadingView")]
        bool NeedsLoadingView { get; set; }

        // @property (assign, nonatomic) BOOL loadingViewHidden;
        [Export("loadingViewHidden")]
        bool LoadingViewHidden { get; set; }

        // @property (assign, nonatomic) BOOL needsLoadingPlaceholderSpace;
        [Export("needsLoadingPlaceholderSpace")]
        bool NeedsLoadingPlaceholderSpace { get; set; }

        // @property (assign, nonatomic) CGSize loadingViewSize __attribute__((annotate("ui_appearance_selector")));
        [Export("loadingViewSize", ArgumentSemantic.Assign)]
        CGSize LoadingViewSize { get; set; }

        // @property (assign, nonatomic) CGFloat loadingViewMarginRight __attribute__((annotate("ui_appearance_selector")));
        [Export("loadingViewMarginRight")]
        nfloat LoadingViewMarginRight { get; set; }

        // @property (nonatomic, strong) UIView * accessoryView;
        [Export("accessoryView", ArgumentSemantic.Strong)]
        UIView AccessoryView { get; set; }

        // @property (assign, nonatomic) QMUINavigationTitleViewAccessoryType accessoryType;
        [Export("accessoryType", ArgumentSemantic.Assign)]
        QMUINavigationTitleViewAccessoryType AccessoryType { get; set; }

        // @property (assign, nonatomic) CGPoint accessoryViewOffset __attribute__((annotate("ui_appearance_selector")));
        [Export("accessoryViewOffset", ArgumentSemantic.Assign)]
        CGPoint AccessoryViewOffset { get; set; }

        // @property (assign, nonatomic) BOOL needsAccessoryPlaceholderSpace;
        [Export("needsAccessoryPlaceholderSpace")]
        bool NeedsAccessoryPlaceholderSpace { get; set; }

        // @property (nonatomic, strong) UIView * subAccessoryView;
        [Export("subAccessoryView", ArgumentSemantic.Strong)]
        UIView SubAccessoryView { get; set; }

        // @property (assign, nonatomic) CGPoint subAccessoryViewOffset __attribute__((annotate("ui_appearance_selector")));
        [Export("subAccessoryViewOffset", ArgumentSemantic.Assign)]
        CGPoint SubAccessoryViewOffset { get; set; }

        // @property (assign, nonatomic) BOOL needsSubAccessoryPlaceholderSpace;
        [Export("needsSubAccessoryPlaceholderSpace")]
        bool NeedsSubAccessoryPlaceholderSpace { get; set; }

        // -(instancetype)initWithStyle:(QMUINavigationTitleViewStyle)style;
        [Export("initWithStyle:")]
        IntPtr Constructor(QMUINavigationTitleViewStyle style);
    }

    // audit-objc-generics: @interface QMUIOrderedDictionary<__covariant KeyType, __covariant ObjectType> : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIOrderedDictionary
    {
        // -(instancetype _Nonnull)initWithKeysAndObjects:(id _Nonnull)firstKey, ...;
        [Internal]
        [Export("initWithKeysAndObjects:", IsVariadic = true)]
        IntPtr Constructor(NSObject firstKey, IntPtr varArgs);

        // @property (readonly) NSUInteger count;
        [Export("count")]
        nuint Count { get; }

        // @property (readonly, copy, nonatomic) NSArray<KeyType> * _Nonnull allKeys;
        [Export("allKeys", ArgumentSemantic.Copy)]
        NSObject[] AllKeys { get; }

        // @property (readonly, copy, nonatomic) NSArray<ObjectType> * _Nonnull allValues;
        [Export("allValues", ArgumentSemantic.Copy)]
        NSObject[] AllValues { get; }

        // -(void)setObject:(ObjectType _Nonnull)object forKey:(KeyType _Nonnull)key;
        [Export("setObject:forKey:")]
        void SetObject(NSObject @object, NSObject key);

        // -(void)addObject:(ObjectType _Nonnull)object forKey:(KeyType _Nonnull)key;
        [Export("addObject:forKey:")]
        void AddObject(NSObject @object, NSObject key);

        // -(void)addObjects:(NSArray<ObjectType> * _Nonnull)objects forKeys:(NSArray<KeyType> * _Nonnull)keys;
        [Export("addObjects:forKeys:")]
        void AddObjects(NSObject[] objects, NSObject[] keys);

        // -(void)insertObject:(ObjectType _Nonnull)object forKey:(KeyType _Nonnull)key atIndex:(NSInteger)index;
        [Export("insertObject:forKey:atIndex:")]
        void InsertObject(NSObject @object, NSObject key, nint index);

        // -(void)insertObjects:(NSArray<ObjectType> * _Nonnull)objects forKeys:(NSArray<KeyType> * _Nonnull)keys atIndex:(NSInteger)index;
        [Export("insertObjects:forKeys:atIndex:")]
        void InsertObjects(NSObject[] objects, NSObject[] keys, nint index);

        // -(void)removeObject:(ObjectType _Nonnull)object forKey:(KeyType _Nonnull)key;
        [Export("removeObject:forKey:")]
        void RemoveObject(NSObject @object, NSObject key);

        // -(void)removeObject:(ObjectType _Nonnull)object atIndex:(NSInteger)index;
        [Export("removeObject:atIndex:")]
        void RemoveObject(NSObject @object, nint index);

        // -(ObjectType _Nullable)objectForKey:(KeyType _Nonnull)key;
        [Export("objectForKey:")]
        [return: NullAllowed]
        NSObject ObjectForKey(NSObject key);

        // -(ObjectType _Nonnull)objectAtIndex:(NSInteger)index;
        [Export("objectAtIndex:")]
        NSObject ObjectAtIndex(nint index);

        // -(ObjectType _Nullable)objectForKeyedSubscript:(KeyType _Nonnull)key;
        [Export("objectForKeyedSubscript:")]
        [return: NullAllowed]
        NSObject ObjectForKeyedSubscript(NSObject key);

        // -(ObjectType _Nonnull)objectAtIndexedSubscript:(NSUInteger)idx;
        [Export("objectAtIndexedSubscript:")]
        NSObject ObjectAtIndexedSubscript(nuint idx);
    }

    // @interface QMUIPieProgressView : UIControl
    [BaseType(typeof(UIControl))]
    interface QMUIPieProgressView
    {
        // @property (assign, nonatomic) CFTimeInterval progressAnimationDuration;
        [Export("progressAnimationDuration")]
        double ProgressAnimationDuration { get; set; }

        // @property (assign, nonatomic) float progress;
        [Export("progress")]
        float Progress { get; set; }

        // @property (assign, nonatomic) CGFloat borderWidth;
        [Export("borderWidth")]
        nfloat BorderWidth { get; set; }

        // @property (assign, nonatomic) CGFloat borderInset;
        [Export("borderInset")]
        nfloat BorderInset { get; set; }

        // @property (assign, nonatomic) CGFloat lineWidth;
        [Export("lineWidth")]
        nfloat LineWidth { get; set; }

        // @property (assign, nonatomic) QMUIPieProgressViewShape shape;
        [Export("shape", ArgumentSemantic.Assign)]
        QMUIPieProgressViewShape Shape { get; set; }

        // -(void)setProgress:(float)progress animated:(BOOL)animated;
        [Export("setProgress:animated:")]
        void SetProgress(float progress, bool animated);
    }

    // @interface QMUI (UIControl)
    [Category]
    [BaseType(typeof(UIControl))]
    interface UIControl_QMUI
    {
        // @property (assign, nonatomic) BOOL qmui_automaticallyAdjustTouchHighlightedInScrollView;
        [Export("qmui_automaticallyAdjustTouchHighlightedInScrollView")]
        bool Qmui_automaticallyAdjustTouchHighlightedInScrollView { get; set; }

        // @property (assign, nonatomic) BOOL qmui_preventsRepeatedTouchUpInsideEvent;
        [Export("qmui_preventsRepeatedTouchUpInsideEvent")]
        bool Qmui_preventsRepeatedTouchUpInsideEvent { get; set; }

        // @property (copy, nonatomic) void (^qmui_setHighlightedBlock)(BOOL);
        [Export("qmui_setHighlightedBlock", ArgumentSemantic.Copy)]
        Action<bool> Qmui_setHighlightedBlock { get; set; }

        // @property (copy, nonatomic) void (^qmui_tapBlock)(__kindof UIControl *);
        [Export("qmui_tapBlock", ArgumentSemantic.Copy)]
        Action<UIControl> Qmui_tapBlock { get; set; }
    }

    // @interface QMUIPopupContainerView : UIControl
    [BaseType(typeof(UIControl))]
    interface QMUIPopupContainerView
    {
        // @property (assign, nonatomic) BOOL debug;
        [Export("debug")]
        bool Debug { get; set; }

        // @property (assign, nonatomic) BOOL automaticallyHidesWhenUserTap;
        [Export("automaticallyHidesWhenUserTap")]
        bool AutomaticallyHidesWhenUserTap { get; set; }

        // @property (readonly, nonatomic, strong) UIView * contentView;
        [Export("contentView", ArgumentSemantic.Strong)]
        UIView ContentView { get; }

        // @property (readonly, nonatomic, strong) UIImageView * imageView;
        [Export("imageView", ArgumentSemantic.Strong)]
        UIImageView ImageView { get; }

        // @property (readonly, nonatomic, strong) UILabel * textLabel;
        [Export("textLabel", ArgumentSemantic.Strong)]
        UILabel TextLabel { get; }

        // @property (assign, nonatomic) UIEdgeInsets contentEdgeInsets __attribute__((annotate("ui_appearance_selector")));
        [Export("contentEdgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets ContentEdgeInsets { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets imageEdgeInsets __attribute__((annotate("ui_appearance_selector")));
        [Export("imageEdgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets ImageEdgeInsets { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets textEdgeInsets __attribute__((annotate("ui_appearance_selector")));
        [Export("textEdgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets TextEdgeInsets { get; set; }

        // @property (assign, nonatomic) CGSize arrowSize __attribute__((annotate("ui_appearance_selector")));
        [Export("arrowSize", ArgumentSemantic.Assign)]
        CGSize ArrowSize { get; set; }

        // @property (nonatomic, strong) UIImage * arrowImage __attribute__((annotate("ui_appearance_selector")));
        [Export("arrowImage", ArgumentSemantic.Strong)]
        UIImage ArrowImage { get; set; }

        // @property (assign, nonatomic) CGFloat maximumWidth __attribute__((annotate("ui_appearance_selector")));
        [Export("maximumWidth")]
        nfloat MaximumWidth { get; set; }

        // @property (assign, nonatomic) CGFloat minimumWidth __attribute__((annotate("ui_appearance_selector")));
        [Export("minimumWidth")]
        nfloat MinimumWidth { get; set; }

        // @property (assign, nonatomic) CGFloat maximumHeight __attribute__((annotate("ui_appearance_selector")));
        [Export("maximumHeight")]
        nfloat MaximumHeight { get; set; }

        // @property (assign, nonatomic) CGFloat minimumHeight __attribute__((annotate("ui_appearance_selector")));
        [Export("minimumHeight")]
        nfloat MinimumHeight { get; set; }

        // @property (assign, nonatomic) QMUIPopupContainerViewLayoutDirection preferLayoutDirection __attribute__((annotate("ui_appearance_selector")));
        [Export("preferLayoutDirection", ArgumentSemantic.Assign)]
        QMUIPopupContainerViewLayoutDirection PreferLayoutDirection { get; set; }

        // @property (readonly, assign, nonatomic) QMUIPopupContainerViewLayoutDirection currentLayoutDirection;
        [Export("currentLayoutDirection", ArgumentSemantic.Assign)]
        QMUIPopupContainerViewLayoutDirection CurrentLayoutDirection { get; }

        // @property (assign, nonatomic) CGFloat distanceBetweenSource __attribute__((annotate("ui_appearance_selector")));
        [Export("distanceBetweenSource")]
        nfloat DistanceBetweenSource { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets safetyMarginsOfSuperview __attribute__((annotate("ui_appearance_selector")));
        [Export("safetyMarginsOfSuperview", ArgumentSemantic.Assign)]
        UIEdgeInsets SafetyMarginsOfSuperview { get; set; }

        // @property (nonatomic, strong) UIColor * backgroundColor __attribute__((annotate("ui_appearance_selector")));
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * highlightedBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [Export("highlightedBackgroundColor", ArgumentSemantic.Strong)]
        UIColor HighlightedBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * maskViewBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [Export("maskViewBackgroundColor", ArgumentSemantic.Strong)]
        UIColor MaskViewBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * shadowColor __attribute__((annotate("ui_appearance_selector")));
        [Export("shadowColor", ArgumentSemantic.Strong)]
        UIColor ShadowColor { get; set; }

        // @property (nonatomic, strong) UIColor * borderColor __attribute__((annotate("ui_appearance_selector")));
        [Export("borderColor", ArgumentSemantic.Strong)]
        UIColor BorderColor { get; set; }

        // @property (assign, nonatomic) CGFloat borderWidth __attribute__((annotate("ui_appearance_selector")));
        [Export("borderWidth")]
        nfloat BorderWidth { get; set; }

        // @property (assign, nonatomic) CGFloat cornerRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (nonatomic, weak) __kindof UIBarItem * sourceBarItem;
        [Export("sourceBarItem", ArgumentSemantic.Weak)]
        UIBarItem SourceBarItem { get; set; }

        // @property (nonatomic, weak) __kindof UIView * sourceView;
        [Export("sourceView", ArgumentSemantic.Weak)]
        UIView SourceView { get; set; }

        // @property (assign, nonatomic) CGRect sourceRect;
        [Export("sourceRect", ArgumentSemantic.Assign)]
        CGRect SourceRect { get; set; }

        // -(void)updateLayout;
        [Export("updateLayout")]
        void UpdateLayout();

        // -(void)showWithAnimated:(BOOL)animated;
        [Export("showWithAnimated:")]
        void ShowWithAnimated(bool animated);

        // -(void)showWithAnimated:(BOOL)animated completion:(void (^)(BOOL))completion;
        [Export("showWithAnimated:completion:")]
        void ShowWithAnimated(bool animated, Action<bool> completion);

        // -(void)hideWithAnimated:(BOOL)animated;
        [Export("hideWithAnimated:")]
        void HideWithAnimated(bool animated);

        // -(void)hideWithAnimated:(BOOL)animated completion:(void (^)(BOOL))completion;
        [Export("hideWithAnimated:completion:")]
        void HideWithAnimated(bool animated, Action<bool> completion);

        // -(BOOL)isShowing;
        [Export("isShowing")]
        [Verify(MethodToProperty)]
        bool IsShowing { get; }

        // @property (copy, nonatomic) void (^willShowBlock)(BOOL);
        [Export("willShowBlock", ArgumentSemantic.Copy)]
        Action<bool> WillShowBlock { get; set; }

        // @property (copy, nonatomic) void (^willHideBlock)(BOOL, BOOL);
        [Export("willHideBlock", ArgumentSemantic.Copy)]
        Action<bool, bool> WillHideBlock { get; set; }

        // @property (copy, nonatomic) void (^didHideBlock)(BOOL);
        [Export("didHideBlock", ArgumentSemantic.Copy)]
        Action<bool> DidHideBlock { get; set; }
    }

    // @interface UISubclassingHooks (QMUIPopupContainerView)
    [Category]
    [BaseType(typeof(QMUIPopupContainerView))]
    interface QMUIPopupContainerView_UISubclassingHooks
    {
        // -(void)didInitialize __attribute__((objc_requires_super));
        [Export("didInitialize")]
        [RequiresSuper]
        void DidInitialize();

        // -(CGSize)sizeThatFitsInContentView:(CGSize)size;
        [Export("sizeThatFitsInContentView:")]
        CGSize SizeThatFitsInContentView(CGSize size);
    }

    // @protocol QMUIPopupMenuItemProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIPopupMenuItemProtocol
    {
        // @required @property (copy, nonatomic) NSString * _Nullable title;
        [Abstract]
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // @required @property (assign, nonatomic) CGFloat height;
        [Abstract]
        [Export("height")]
        nfloat Height { get; set; }

        // @required @property (copy, nonatomic) void (^ _Nullable)(__kindof NSObject<QMUIPopupMenuItemProtocol> * _Nonnull) handler;
        [Abstract]
        [NullAllowed, Export("handler", ArgumentSemantic.Copy)]
        Action<QMUIPopupMenuItemProtocol> Handler { get; set; }

        // @required @property (nonatomic, weak) QMUIPopupMenuView * _Nullable menuView;
        [Abstract]
        [NullAllowed, Export("menuView", ArgumentSemantic.Weak)]
        QMUIPopupMenuView MenuView { get; set; }

        // @required -(void)updateAppearance;
        [Abstract]
        [Export("updateAppearance")]
        void UpdateAppearance();
    }

    // @interface QMUIPopupMenuBaseItem : UIView <QMUIPopupMenuItemProtocol>
    [BaseType(typeof(UIView))]
    interface QMUIPopupMenuBaseItem : IQMUIPopupMenuItemProtocol
    {
    }

    // @interface QMUIPopupMenuButtonItem : QMUIPopupMenuBaseItem
    [BaseType(typeof(QMUIPopupMenuBaseItem))]
    interface QMUIPopupMenuButtonItem
    {
        // @property (nonatomic, strong) UIImage * _Nullable image;
        [NullAllowed, Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // @property (readonly, nonatomic, strong) QMUIButton * _Nonnull button;
        [Export("button", ArgumentSemantic.Strong)]
        QMUIButton Button { get; }

        // @property (nonatomic, strong) UIColor * _Nullable highlightedBackgroundColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("highlightedBackgroundColor", ArgumentSemantic.Strong)]
        UIColor HighlightedBackgroundColor { get; set; }

        // @property (assign, nonatomic) CGFloat imageMarginRight __attribute__((annotate("ui_appearance_selector")));
        [Export("imageMarginRight")]
        nfloat ImageMarginRight { get; set; }

        // +(instancetype _Nonnull)itemWithImage:(UIImage * _Nullable)image title:(NSString * _Nullable)title handler:(void (^ _Nullable)(QMUIPopupMenuButtonItem * _Nonnull))handler;
        [Static]
        [Export("itemWithImage:title:handler:")]
        QMUIPopupMenuButtonItem ItemWithImage([NullAllowed] UIImage image, [NullAllowed] string title, [NullAllowed] Action<QMUIPopupMenuButtonItem> handler);
    }

    // @interface QMUIPopupMenuView : QMUIPopupContainerView
    [BaseType(typeof(QMUIPopupContainerView))]
    interface QMUIPopupMenuView
    {
        // @property (assign, nonatomic) BOOL shouldShowItemSeparator __attribute__((annotate("ui_appearance_selector")));
        [Export("shouldShowItemSeparator")]
        bool ShouldShowItemSeparator { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable itemSeparatorColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("itemSeparatorColor", ArgumentSemantic.Strong)]
        UIColor ItemSeparatorColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets itemSeparatorInset __attribute__((annotate("ui_appearance_selector")));
        [Export("itemSeparatorInset", ArgumentSemantic.Assign)]
        UIEdgeInsets ItemSeparatorInset { get; set; }

        // @property (assign, nonatomic) BOOL shouldShowSectionSeparator __attribute__((annotate("ui_appearance_selector")));
        [Export("shouldShowSectionSeparator")]
        bool ShouldShowSectionSeparator { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable sectionSeparatorColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("sectionSeparatorColor", ArgumentSemantic.Strong)]
        UIColor SectionSeparatorColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets sectionSeparatorInset __attribute__((annotate("ui_appearance_selector")));
        [Export("sectionSeparatorInset", ArgumentSemantic.Assign)]
        UIEdgeInsets SectionSeparatorInset { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable itemTitleFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("itemTitleFont", ArgumentSemantic.Strong)]
        UIFont ItemTitleFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable itemTitleColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("itemTitleColor", ArgumentSemantic.Strong)]
        UIColor ItemTitleColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets padding __attribute__((annotate("ui_appearance_selector")));
        [Export("padding", ArgumentSemantic.Assign)]
        UIEdgeInsets Padding { get; set; }

        // @property (assign, nonatomic) CGFloat itemHeight __attribute__((annotate("ui_appearance_selector")));
        [Export("itemHeight")]
        nfloat ItemHeight { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(QMUIPopupMenuView * _Nonnull, __kindof QMUIPopupMenuBaseItem * _Nonnull, NSInteger, NSInteger) itemConfigurationHandler;
        [NullAllowed, Export("itemConfigurationHandler", ArgumentSemantic.Copy)]
        Action<QMUIPopupMenuView, QMUIPopupMenuBaseItem, nint, nint> ItemConfigurationHandler { get; set; }

        // @property (copy, nonatomic) NSArray<__kindof QMUIPopupMenuBaseItem *> * _Nullable items;
        [NullAllowed, Export("items", ArgumentSemantic.Copy)]
        QMUIPopupMenuBaseItem[] Items { get; set; }

        // @property (copy, nonatomic) NSArray<NSArray<__kindof QMUIPopupMenuBaseItem *> *> * _Nullable itemSections;
        [NullAllowed, Export("itemSections", ArgumentSemantic.Copy)]
        NSArray<QMUIPopupMenuBaseItem>[] ItemSections { get; set; }
    }

    // @interface QMUISearchBar : UISearchBar
    [BaseType(typeof(UISearchBar))]
    interface QMUISearchBar
    {
    }

    // @protocol QMUISearchControllerDelegate <QMUITableViewDataSource, QMUITableViewDelegate>
    [Protocol, Model]
    interface QMUISearchControllerDelegate : IQMUITableViewDataSource, IQMUITableViewDelegate
    {
        // @required -(void)searchController:(QMUISearchController *)searchController updateResultsForSearchString:(NSString *)searchString;
        [Abstract]
        [Export("searchController:updateResultsForSearchString:")]
        void SearchController(QMUISearchController searchController, string searchString);

        // @optional -(void)willPresentSearchController:(QMUISearchController *)searchController;
        [Export("willPresentSearchController:")]
        void WillPresentSearchController(QMUISearchController searchController);

        // @optional -(void)didPresentSearchController:(QMUISearchController *)searchController;
        [Export("didPresentSearchController:")]
        void DidPresentSearchController(QMUISearchController searchController);

        // @optional -(void)willDismissSearchController:(QMUISearchController *)searchController;
        [Export("willDismissSearchController:")]
        void WillDismissSearchController(QMUISearchController searchController);

        // @optional -(void)didDismissSearchController:(QMUISearchController *)searchController;
        [Export("didDismissSearchController:")]
        void DidDismissSearchController(QMUISearchController searchController);

        // @optional -(void)searchController:(QMUISearchController *)searchController didLoadSearchResultsTableView:(UITableView *)tableView;
        [Export("searchController:didLoadSearchResultsTableView:")]
        void SearchController(QMUISearchController searchController, UITableView tableView);

        // @optional -(void)searchController:(QMUISearchController *)searchController willShowEmptyView:(QMUIEmptyView *)emptyView;
        [Export("searchController:willShowEmptyView:")]
        void SearchController(QMUISearchController searchController, QMUIEmptyView emptyView);
    }

    // @interface QMUISearchController : QMUICommonViewController <UISearchResultsUpdating, UISearchControllerDelegate>
    [BaseType(typeof(QMUICommonViewController))]
    interface QMUISearchController : IUISearchResultsUpdating, IUISearchControllerDelegate
    {
        // -(instancetype)initWithContentsViewController:(UIViewController *)viewController;
        [Export("initWithContentsViewController:")]
        IntPtr Constructor(UIViewController viewController);

        [Wrap("WeakSearchResultsDelegate")]
        QMUISearchControllerDelegate SearchResultsDelegate { get; set; }

        // @property (nonatomic, weak) id<QMUISearchControllerDelegate> searchResultsDelegate;
        [NullAllowed, Export("searchResultsDelegate", ArgumentSemantic.Weak)]
        NSObject WeakSearchResultsDelegate { get; set; }

        // @property (readonly, nonatomic, strong) UISearchBar * searchBar;
        [Export("searchBar", ArgumentSemantic.Strong)]
        UISearchBar SearchBar { get; }

        // @property (readonly, nonatomic, strong) QMUITableView * tableView;
        [Export("tableView", ArgumentSemantic.Strong)]
        QMUITableView TableView { get; }

        // @property (nonatomic, strong) UIView * launchView;
        [Export("launchView", ArgumentSemantic.Strong)]
        UIView LaunchView { get; set; }

        // @property (getter = isActive, assign, nonatomic) BOOL active;
        [Export("active")]
        bool Active { [Bind("isActive")] get; set; }

        // -(void)setActive:(BOOL)active animated:(BOOL)animated;
        [Export("setActive:animated:")]
        void SetActive(bool active, bool animated);

        // @property (assign, nonatomic) BOOL hidesNavigationBarDuringPresentation;
        [Export("hidesNavigationBarDuringPresentation")]
        bool HidesNavigationBarDuringPresentation { get; set; }
    }

    // @interface Search (QMUICommonTableViewController) <QMUISearchControllerDelegate>
    [Category]
    [BaseType(typeof(QMUICommonTableViewController))]
    interface QMUICommonTableViewController_Search : IQMUISearchControllerDelegate
    {
        // @property (assign, nonatomic) BOOL shouldShowSearchBar;
        [Export("shouldShowSearchBar")]
        bool ShouldShowSearchBar { get; set; }

        // @property (readonly, nonatomic, strong) QMUISearchController * searchController;
        [Export("searchController", ArgumentSemantic.Strong)]
        QMUISearchController SearchController { get; }

        // @property (readonly, nonatomic, strong) UISearchBar * searchBar;
        [Export("searchBar", ArgumentSemantic.Strong)]
        UISearchBar SearchBar { get; }

        // -(BOOL)shouldHideSearchBarWhenEmptyViewShowing;
        [Export("shouldHideSearchBarWhenEmptyViewShowing")]
        [Verify(MethodToProperty)]
        bool ShouldHideSearchBarWhenEmptyViewShowing { get; }

        // -(void)initSearchController;
        [Export("initSearchController")]
        void InitSearchController();
    }

    // @interface QMUISegmentedControl : UISegmentedControl
    [BaseType(typeof(UISegmentedControl))]
    interface QMUISegmentedControl
    {
        // @property (readonly, copy, nonatomic) NSArray * segmentItems;
        [Export("segmentItems", ArgumentSemantic.Copy)]
        [Verify(StronglyTypedNSArray)]
        NSObject[] SegmentItems { get; }

        // -(void)updateSegmentedUIWithTintColor:(UIColor *)tintColor selectedTextColor:(UIColor *)selectedTextColor fontSize:(UIFont *)fontSize;
        [Export("updateSegmentedUIWithTintColor:selectedTextColor:fontSize:")]
        void UpdateSegmentedUIWithTintColor(UIColor tintColor, UIColor selectedTextColor, UIFont fontSize);

        // -(void)setBackgroundWithNormalImage:(UIImage *)normalImage selectedImage:(UIImage *)selectedImage devideImage00:(UIImage *)devideImage00 devideImage01:(UIImage *)devideImage01 devideImage10:(UIImage *)devideImage10 textColor:(UIColor *)textColor selectedTextColor:(UIColor *)selectedTextColor fontSize:(UIFont *)fontSize;
        [Export("setBackgroundWithNormalImage:selectedImage:devideImage00:devideImage01:devideImage10:textColor:selectedTextColor:fontSize:")]
        void SetBackgroundWithNormalImage(UIImage normalImage, UIImage selectedImage, UIImage devideImage00, UIImage devideImage01, UIImage devideImage10, UIColor textColor, UIColor selectedTextColor, UIFont fontSize);
    }

    // @interface QMUISlider : UISlider
    [BaseType(typeof(UISlider))]
    interface QMUISlider
    {
        // @property (assign, nonatomic) CGFloat trackHeight __attribute__((annotate("ui_appearance_selector")));
        [Export("trackHeight")]
        nfloat TrackHeight { get; set; }

        // @property (assign, nonatomic) CGSize thumbSize __attribute__((annotate("ui_appearance_selector")));
        [Export("thumbSize", ArgumentSemantic.Assign)]
        CGSize ThumbSize { get; set; }

        // @property (nonatomic, strong) UIColor * thumbColor __attribute__((annotate("ui_appearance_selector")));
        [Export("thumbColor", ArgumentSemantic.Strong)]
        UIColor ThumbColor { get; set; }

        // @property (nonatomic, strong) UIColor * thumbShadowColor __attribute__((annotate("ui_appearance_selector")));
        [Export("thumbShadowColor", ArgumentSemantic.Strong)]
        UIColor ThumbShadowColor { get; set; }

        // @property (assign, nonatomic) CGSize thumbShadowOffset __attribute__((annotate("ui_appearance_selector")));
        [Export("thumbShadowOffset", ArgumentSemantic.Assign)]
        CGSize ThumbShadowOffset { get; set; }

        // @property (assign, nonatomic) CGFloat thumbShadowRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("thumbShadowRadius")]
        nfloat ThumbShadowRadius { get; set; }
    }

    // @interface QMUIStaticTableViewCellData : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIStaticTableViewCellData
    {
        // @property (assign, nonatomic) NSInteger identifier;
        [Export("identifier")]
        nint Identifier { get; set; }

        // @property (readonly, nonatomic, strong) NSIndexPath * _Nullable indexPath;
        [NullAllowed, Export("indexPath", ArgumentSemantic.Strong)]
        NSIndexPath IndexPath { get; }

        // @property (assign, nonatomic) Class _Nonnull cellClass;
        [Export("cellClass", ArgumentSemantic.Assign)]
        Class CellClass { get; set; }

        // @property (assign, nonatomic) UITableViewCellStyle style;
        [Export("style", ArgumentSemantic.Assign)]
        UITableViewCellStyle Style { get; set; }

        // @property (assign, nonatomic) CGFloat height;
        [Export("height")]
        nfloat Height { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable image;
        [NullAllowed, Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable text;
        [NullAllowed, Export("text")]
        string Text { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable detailText;
        [NullAllowed, Export("detailText")]
        string DetailText { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(UITableView * _Nonnull, __kindof QMUITableViewCell * _Nonnull, QMUIStaticTableViewCellData * _Nonnull) cellForRowBlock;
        [NullAllowed, Export("cellForRowBlock", ArgumentSemantic.Copy)]
        Action<UITableView, QMUITableViewCell, QMUIStaticTableViewCellData> CellForRowBlock { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(UITableView * _Nonnull, QMUIStaticTableViewCellData * _Nonnull) didSelectBlock;
        [NullAllowed, Export("didSelectBlock", ArgumentSemantic.Copy)]
        Action<UITableView, QMUIStaticTableViewCellData> DidSelectBlock { get; set; }

        // @property (assign, nonatomic) id _Nullable didSelectTarget;
        [NullAllowed, Export("didSelectTarget", ArgumentSemantic.Assign)]
        NSObject DidSelectTarget { get; set; }

        // @property (assign, nonatomic) SEL _Nullable didSelectAction;
        [NullAllowed, Export("didSelectAction", ArgumentSemantic.Assign)]
        Selector DidSelectAction { get; set; }

        // @property (assign, nonatomic) QMUIStaticTableViewCellAccessoryType accessoryType;
        [Export("accessoryType", ArgumentSemantic.Assign)]
        QMUIStaticTableViewCellAccessoryType AccessoryType { get; set; }

        // @property (nonatomic, strong) NSObject * _Nullable accessoryValueObject;
        [NullAllowed, Export("accessoryValueObject", ArgumentSemantic.Strong)]
        NSObject AccessoryValueObject { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(UITableView * _Nonnull, QMUIStaticTableViewCellData * _Nonnull) accessoryBlock;
        [NullAllowed, Export("accessoryBlock", ArgumentSemantic.Copy)]
        Action<UITableView, QMUIStaticTableViewCellData> AccessoryBlock { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(UITableView * _Nonnull, QMUIStaticTableViewCellData * _Nonnull, UISwitch * _Nonnull) accessorySwitchBlock;
        [NullAllowed, Export("accessorySwitchBlock", ArgumentSemantic.Copy)]
        Action<UITableView, QMUIStaticTableViewCellData, UISwitch> AccessorySwitchBlock { get; set; }

        // @property (assign, nonatomic) id _Nullable accessoryTarget;
        [NullAllowed, Export("accessoryTarget", ArgumentSemantic.Assign)]
        NSObject AccessoryTarget { get; set; }

        // @property (assign, nonatomic) SEL _Nullable accessoryAction;
        [NullAllowed, Export("accessoryAction", ArgumentSemantic.Assign)]
        Selector AccessoryAction { get; set; }

        // +(instancetype _Nonnull)staticTableViewCellDataWithIdentifier:(NSInteger)identifier image:(UIImage * _Nullable)image text:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText didSelectTarget:(id _Nullable)didSelectTarget didSelectAction:(SEL _Nullable)didSelectAction accessoryType:(QMUIStaticTableViewCellAccessoryType)accessoryType;
        [Static]
        [Export("staticTableViewCellDataWithIdentifier:image:text:detailText:didSelectTarget:didSelectAction:accessoryType:")]
        QMUIStaticTableViewCellData StaticTableViewCellDataWithIdentifier(nint identifier, [NullAllowed] UIImage image, [NullAllowed] string text, [NullAllowed] string detailText, [NullAllowed] NSObject didSelectTarget, [NullAllowed] Selector didSelectAction, QMUIStaticTableViewCellAccessoryType accessoryType);

        // +(instancetype _Nonnull)staticTableViewCellDataWithIdentifier:(NSInteger)identifier cellClass:(Class _Nonnull)cellClass style:(UITableViewCellStyle)style height:(CGFloat)height image:(UIImage * _Nullable)image text:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText didSelectTarget:(id _Nullable)didSelectTarget didSelectAction:(SEL _Nullable)didSelectAction accessoryType:(QMUIStaticTableViewCellAccessoryType)accessoryType accessoryValueObject:(NSObject * _Nullable)accessoryValueObject accessoryTarget:(id _Nullable)accessoryTarget accessoryAction:(SEL _Nullable)accessoryAction;
        [Static]
        [Export("staticTableViewCellDataWithIdentifier:cellClass:style:height:image:text:detailText:didSelectTarget:didSelectAction:accessoryType:accessoryValueObject:accessoryTarget:accessoryAction:")]
        QMUIStaticTableViewCellData StaticTableViewCellDataWithIdentifier(nint identifier, Class cellClass, UITableViewCellStyle style, nfloat height, [NullAllowed] UIImage image, [NullAllowed] string text, [NullAllowed] string detailText, [NullAllowed] NSObject didSelectTarget, [NullAllowed] Selector didSelectAction, QMUIStaticTableViewCellAccessoryType accessoryType, [NullAllowed] NSObject accessoryValueObject, [NullAllowed] NSObject accessoryTarget, [NullAllowed] Selector accessoryAction);

        // +(UITableViewCellAccessoryType)tableViewCellAccessoryTypeWithStaticAccessoryType:(QMUIStaticTableViewCellAccessoryType)type;
        [Static]
        [Export("tableViewCellAccessoryTypeWithStaticAccessoryType:")]
        UITableViewCellAccessoryType TableViewCellAccessoryTypeWithStaticAccessoryType(QMUIStaticTableViewCellAccessoryType type);
    }

    // @interface QMUIStaticTableViewCellDataSource : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIStaticTableViewCellDataSource
    {
        // @property (copy, nonatomic) NSArray<NSArray<QMUIStaticTableViewCellData *> *> * cellDataSections;
        [Export("cellDataSections", ArgumentSemantic.Copy)]
        NSArray<QMUIStaticTableViewCellData>[] CellDataSections { get; set; }

        // @property (readonly, nonatomic, weak) UITableView * tableView;
        [Export("tableView", ArgumentSemantic.Weak)]
        UITableView TableView { get; }

        // -(instancetype)initWithCellDataSections:(NSArray<NSArray<QMUIStaticTableViewCellData *> *> *)cellDataSections __attribute__((objc_designated_initializer));
        [Export("initWithCellDataSections:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSArray<QMUIStaticTableViewCellData>[] cellDataSections);
    }

    // @interface Manual (QMUIStaticTableViewCellDataSource)
    [Category]
    [BaseType(typeof(QMUIStaticTableViewCellDataSource))]
    interface QMUIStaticTableViewCellDataSource_Manual
    {
        // -(QMUIStaticTableViewCellData *)cellDataAtIndexPath:(NSIndexPath *)indexPath;
        [Export("cellDataAtIndexPath:")]
        QMUIStaticTableViewCellData CellDataAtIndexPath(NSIndexPath indexPath);

        // -(NSString *)reuseIdentifierForCellAtIndexPath:(NSIndexPath *)indexPath;
        [Export("reuseIdentifierForCellAtIndexPath:")]
        string ReuseIdentifierForCellAtIndexPath(NSIndexPath indexPath);

        // -(__kindof QMUITableViewCell *)cellForRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export("cellForRowAtIndexPath:")]
        QMUITableViewCell CellForRowAtIndexPath(NSIndexPath indexPath);

        // -(CGFloat)heightForRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export("heightForRowAtIndexPath:")]
        nfloat HeightForRowAtIndexPath(NSIndexPath indexPath);

        // -(void)didSelectRowAtIndexPath:(NSIndexPath *)indexPath;
        [Export("didSelectRowAtIndexPath:")]
        void DidSelectRowAtIndexPath(NSIndexPath indexPath);

        // -(void)accessoryButtonTappedForRowWithIndexPath:(NSIndexPath *)indexPath;
        [Export("accessoryButtonTappedForRowWithIndexPath:")]
        void AccessoryButtonTappedForRowWithIndexPath(NSIndexPath indexPath);
    }

    // @interface QMUITabBarViewController : UITabBarController
    [BaseType(typeof(UITabBarController))]
    interface QMUITabBarViewController
    {
        // -(void)didInitialize __attribute__((objc_requires_super));
        [Export("didInitialize")]
        [RequiresSuper]
        void DidInitialize();
    }

    // @interface QMUITableViewHeaderFooterView : UITableViewHeaderFooterView
    [BaseType(typeof(UITableViewHeaderFooterView))]
    interface QMUITableViewHeaderFooterView
    {
        // @property (nonatomic, weak) UITableView * parentTableView;
        [Export("parentTableView", ArgumentSemantic.Weak)]
        UITableView ParentTableView { get; set; }

        // @property (assign, nonatomic) QMUITableViewHeaderFooterViewType type;
        [Export("type", ArgumentSemantic.Assign)]
        QMUITableViewHeaderFooterViewType Type { get; set; }

        // @property (readonly, nonatomic, strong) UILabel * titleLabel;
        [Export("titleLabel", ArgumentSemantic.Strong)]
        UILabel TitleLabel { get; }

        // @property (nonatomic, strong) UIView * accessoryView;
        [Export("accessoryView", ArgumentSemantic.Strong)]
        UIView AccessoryView { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets contentEdgeInsets;
        [Export("contentEdgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets ContentEdgeInsets { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets accessoryViewMargins;
        [Export("accessoryViewMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets AccessoryViewMargins { get; set; }
    }

    // @interface UISubclassingHooks (QMUITableViewHeaderFooterView)
    [Category]
    [BaseType(typeof(QMUITableViewHeaderFooterView))]
    interface QMUITableViewHeaderFooterView_UISubclassingHooks
    {
        // -(void)updateAppearance;
        [Export("updateAppearance")]
        void UpdateAppearance();
    }

    // @interface QMUITestView : UIView
    [BaseType(typeof(UIView))]
    interface QMUITestView
    {
    }

    // @interface QMUITestWindow : UIWindow
    [BaseType(typeof(UIWindow))]
    interface QMUITestWindow
    {
    }

    // @protocol QMUITextFieldDelegate <UITextFieldDelegate>
    [Protocol, Model]
    interface QMUITextFieldDelegate : IUITextFieldDelegate
    {
        // @optional -(void)textField:(QMUITextField *)textField didPreventTextChangeInRange:(NSRange)range replacementString:(NSString *)replacementString;
        [Export("textField:didPreventTextChangeInRange:replacementString:")]
        void DidPreventTextChangeInRange(QMUITextField textField, NSRange range, string replacementString);
    }

    // @interface QMUITextField : UITextField
    [BaseType(typeof(UITextField))]
    interface QMUITextField
    {
        [Wrap("WeakDelegate")]
        QMUITextFieldDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<QMUITextFieldDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) UIColor * placeholderColor;
        [Export("placeholderColor", ArgumentSemantic.Strong)]
        UIColor PlaceholderColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets textInsets;
        [Export("textInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets TextInsets { get; set; }

        // @property (assign, nonatomic) UIOffset clearButtonPositionAdjustment __attribute__((annotate("ui_appearance_selector")));
        [Export("clearButtonPositionAdjustment", ArgumentSemantic.Assign)]
        UIOffset ClearButtonPositionAdjustment { get; set; }

        // @property (assign, nonatomic) BOOL shouldResponseToProgrammaticallyTextChanges;
        [Export("shouldResponseToProgrammaticallyTextChanges")]
        bool ShouldResponseToProgrammaticallyTextChanges { get; set; }

        // @property (assign, nonatomic) NSUInteger maximumTextLength;
        [Export("maximumTextLength")]
        nuint MaximumTextLength { get; set; }

        // @property (assign, nonatomic) BOOL shouldCountingNonASCIICharacterAsTwo;
        [Export("shouldCountingNonASCIICharacterAsTwo")]
        bool ShouldCountingNonASCIICharacterAsTwo { get; set; }
    }

    // @protocol QMUITextViewDelegate <UITextViewDelegate>
    [Protocol, Model]
    interface QMUITextViewDelegate : IUITextViewDelegate
    {
        // @optional -(void)textView:(QMUITextView *)textView newHeightAfterTextChanged:(CGFloat)height;
        [Export("textView:newHeightAfterTextChanged:")]
        void TextView(QMUITextView textView, nfloat height);

        // @optional -(BOOL)textViewShouldReturn:(QMUITextView *)textView;
        [Export("textViewShouldReturn:")]
        bool TextViewShouldReturn(QMUITextView textView);

        // @optional -(void)textView:(QMUITextView *)textView didPreventTextChangeInRange:(NSRange)range replacementText:(NSString *)replacementText;
        [Export("textView:didPreventTextChangeInRange:replacementText:")]
        void TextView(QMUITextView textView, NSRange range, string replacementText);
    }

    // @interface QMUITextView : UITextView
    [BaseType(typeof(UITextView))]
    interface QMUITextView
    {
        [Wrap("WeakDelegate")]
        QMUITextViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<QMUITextViewDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) BOOL shouldResponseToProgrammaticallyTextChanges;
        [Export("shouldResponseToProgrammaticallyTextChanges")]
        bool ShouldResponseToProgrammaticallyTextChanges { get; set; }

        // @property (assign, nonatomic) NSUInteger maximumTextLength;
        [Export("maximumTextLength")]
        nuint MaximumTextLength { get; set; }

        // @property (assign, nonatomic) BOOL shouldCountingNonASCIICharacterAsTwo;
        [Export("shouldCountingNonASCIICharacterAsTwo")]
        bool ShouldCountingNonASCIICharacterAsTwo { get; set; }

        // @property (copy, nonatomic) NSString * placeholder;
        [Export("placeholder")]
        string Placeholder { get; set; }

        // @property (nonatomic, strong) UIColor * placeholderColor;
        [Export("placeholderColor", ArgumentSemantic.Strong)]
        UIColor PlaceholderColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets placeholderMargins;
        [Export("placeholderMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets PlaceholderMargins { get; set; }

        // @property (assign, nonatomic) CGFloat maximumHeight;
        [Export("maximumHeight")]
        nfloat MaximumHeight { get; set; }

        // @property (copy, nonatomic) BOOL (^canPerformPasteActionBlock)(id, BOOL);
        [Export("canPerformPasteActionBlock", ArgumentSemantic.Copy)]
        Func<NSObject, bool, bool> CanPerformPasteActionBlock { get; set; }

        // @property (copy, nonatomic) BOOL (^pasteBlock)(id);
        [Export("pasteBlock", ArgumentSemantic.Copy)]
        Func<NSObject, bool> PasteBlock { get; set; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const NSNotificationName _Nonnull QMUIThemeDidChangeNotification;
        [Field("QMUIThemeDidChangeNotification", "__Internal")]
        NSString QMUIThemeDidChangeNotification { get; }
    }

    // @interface QMUIThemeManager : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface QMUIThemeManager
    {
        // +(instancetype _Nonnull)sharedInstance __attribute__((deprecated("QMUIThemeManager 不再主动初始化，请使用 QMUIThemeManagerCenter.defaultThemeManager 或者 -[QMUIThemeManagerCenter themeManagerWithName:] 获取")));
        [Static]
        [Export("sharedInstance")]
        QMUIThemeManager SharedInstance();

        // @property (readonly, copy, nonatomic) __kindof NSObject<NSCopying> * _Nonnull name;
        [Export("name", ArgumentSemantic.Copy)]
        NSCopying Name { get; }

        // @property (assign, nonatomic) BOOL respondsSystemStyleAutomatically __attribute__((availability(ios, introduced=13.0)));
        [iOS(13, 0)]
        [Export("respondsSystemStyleAutomatically")]
        bool RespondsSystemStyleAutomatically { get; set; }

        // @property (copy, nonatomic) __kindof NSObject<NSCopying> * _Nonnull (^ _Nullable)(UITraitCollection * _Nonnull) identifierForTrait __attribute__((availability(ios, introduced=13.0)));
        [iOS(13, 0)]
        [NullAllowed, Export("identifierForTrait", ArgumentSemantic.Copy)]
        Func<UITraitCollection, NSCopying> IdentifierForTrait { get; set; }

        // @property (readonly, copy, nonatomic) NSArray<__kindof NSObject<NSCopying> *> * _Nullable themeIdentifiers;
        [NullAllowed, Export("themeIdentifiers", ArgumentSemantic.Copy)]
        NSCopying[] ThemeIdentifiers { get; }

        // @property (readonly, copy, nonatomic) NSArray<__kindof NSObject *> * _Nullable themes;
        [NullAllowed, Export("themes", ArgumentSemantic.Copy)]
        NSObject[] Themes { get; }

        // @property (copy, nonatomic) __kindof NSObject<NSCopying> * _Nullable currentThemeIdentifier;
        [Export("currentThemeIdentifier", ArgumentSemantic.Copy)]
        NSCopying CurrentThemeIdentifier { get; set; }

        // @property (nonatomic, strong) __kindof NSObject * _Nullable currentTheme;
        [Export("currentTheme", ArgumentSemantic.Strong)]
        NSObject CurrentTheme { get; set; }

        // @property (copy, nonatomic) __kindof NSObject * _Nullable (^ _Nullable)(__kindof NSObject<NSCopying> * _Nonnull) themeGenerator;
        [NullAllowed, Export("themeGenerator", ArgumentSemantic.Copy)]
        Func<NSCopying, NSObject> ThemeGenerator { get; set; }

        // @property (copy, nonatomic) __kindof NSObject<NSCopying> * _Nullable (^ _Nullable)(__kindof NSObject * _Nonnull) themeIdentifierGenerator;
        [NullAllowed, Export("themeIdentifierGenerator", ArgumentSemantic.Copy)]
        Func<NSObject, NSCopying> ThemeIdentifierGenerator { get; set; }

        // -(void)addThemeIdentifier:(__kindof NSObject<NSCopying> * _Nonnull)identifier theme:(__kindof NSObject * _Nonnull)theme;
        [Export("addThemeIdentifier:theme:")]
        void AddThemeIdentifier(NSCopying identifier, NSObject theme);

        // -(void)removeThemeIdentifier:(__kindof NSObject<NSCopying> * _Nonnull)identifier;
        [Export("removeThemeIdentifier:")]
        void RemoveThemeIdentifier(NSCopying identifier);

        // -(void)removeTheme:(__kindof NSObject * _Nonnull)theme;
        [Export("removeTheme:")]
        void RemoveTheme(NSObject theme);

        // -(__kindof NSObject * _Nullable)themeForIdentifier:(__kindof NSObject<NSCopying> * _Nonnull)identifier;
        [Export("themeForIdentifier:")]
        NSObject ThemeForIdentifier(NSCopying identifier);

        // -(__kindof NSObject<NSCopying> * _Nullable)identifierForTheme:(__kindof NSObject * _Nonnull)theme;
        [Export("identifierForTheme:")]
        NSCopying IdentifierForTheme(NSObject theme);
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull QMUIThemeManagerNameDefault;
        [Field("QMUIThemeManagerNameDefault", "__Internal")]
        NSString QMUIThemeManagerNameDefault { get; }
    }

    // @interface QMUIThemeManagerCenter : NSObject
    [BaseType(typeof(NSObject))]
    interface QMUIThemeManagerCenter
    {
        // @property (readonly, nonatomic, strong, class) QMUIThemeManager * _Nonnull defaultThemeManager;
        [Static]
        [Export("defaultThemeManager", ArgumentSemantic.Strong)]
        QMUIThemeManager DefaultThemeManager { get; }

        // @property (readonly, copy, nonatomic, class) NSArray<QMUIThemeManager *> * _Nonnull themeManagers;
        [Static]
        [Export("themeManagers", ArgumentSemantic.Copy)]
        QMUIThemeManager[] ThemeManagers { get; }

        // +(QMUIThemeManager * _Nullable)themeManagerWithName:(__kindof NSObject<NSCopying> * _Nonnull)name;
        [Static]
        [Export("themeManagerWithName:")]
        [return: NullAllowed]
        QMUIThemeManager ThemeManagerWithName(NSCopying name);
    }

    // @interface QMUITheme (UIColor)
    [Category]
    [BaseType(typeof(UIColor))]
    interface UIColor_QMUITheme
    {
        // +(UIColor * _Nonnull)qmui_colorWithThemeProvider:(UIColor * _Nonnull (^ _Nonnull)(__kindof QMUIThemeManager * _Nonnull, __kindof NSObject<NSCopying> * _Nullable, __kindof NSObject * _Nullable))provider;
        [Static]
        [Export("qmui_colorWithThemeProvider:")]
        UIColor Qmui_colorWithThemeProvider(Func<QMUIThemeManager, NSCopying, NSObject, UIColor> provider);

        // +(UIColor * _Nonnull)qmui_colorWithThemeManagerName:(__kindof NSObject<NSCopying> * _Nonnull)name provider:(UIColor * _Nonnull (^ _Nonnull)(__kindof QMUIThemeManager * _Nonnull, __kindof NSObject<NSCopying> * _Nullable, __kindof NSObject * _Nullable))provider;
        [Static]
        [Export("qmui_colorWithThemeManagerName:provider:")]
        UIColor Qmui_colorWithThemeManagerName(NSCopying name, Func<QMUIThemeManager, NSCopying, NSObject, UIColor> provider);
    }

    // @protocol QMUIDynamicImageProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIDynamicImageProtocol
    {
        // @required @property (readonly, nonatomic, strong) UIImage * _Nonnull qmui_rawImage;
        [Abstract]
        [Export("qmui_rawImage", ArgumentSemantic.Strong)]
        UIImage Qmui_rawImage { get; }

        // @required @property (readonly, assign, nonatomic) BOOL qmui_isDynamicImage;
        [Abstract]
        [Export("qmui_isDynamicImage")]
        bool Qmui_isDynamicImage { get; }
    }

    // @interface QMUITheme (UIImage) <QMUIDynamicImageProtocol>
    [Category]
    [BaseType(typeof(UIImage))]
    interface UIImage_QMUITheme : IQMUIDynamicImageProtocol
    {
        // +(UIImage * _Nonnull)qmui_imageWithThemeProvider:(UIImage * _Nonnull (^ _Nonnull)(__kindof QMUIThemeManager * _Nonnull, __kindof NSObject<NSCopying> * _Nullable, __kindof NSObject * _Nullable))provider;
        [Static]
        [Export("qmui_imageWithThemeProvider:")]
        UIImage Qmui_imageWithThemeProvider(Func<QMUIThemeManager, NSCopying, NSObject, UIImage> provider);

        // +(UIImage * _Nonnull)qmui_imageWithThemeManagerName:(__kindof NSObject<NSCopying> * _Nonnull)name provider:(UIImage * _Nonnull (^ _Nonnull)(__kindof QMUIThemeManager * _Nonnull, __kindof NSObject<NSCopying> * _Nullable, __kindof NSObject * _Nullable))provider;
        [Static]
        [Export("qmui_imageWithThemeManagerName:provider:")]
        UIImage Qmui_imageWithThemeManagerName(NSCopying name, Func<QMUIThemeManager, NSCopying, NSObject, UIImage> provider);
    }

    // @protocol QMUIDynamicEffectProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIDynamicEffectProtocol
    {
        // @required @property (readonly, nonatomic, strong) __kindof UIVisualEffect * _Nonnull qmui_rawEffect;
        [Abstract]
        [Export("qmui_rawEffect", ArgumentSemantic.Strong)]
        UIVisualEffect Qmui_rawEffect { get; }

        // @required @property (readonly, assign, nonatomic) BOOL qmui_isDynamicEffect;
        [Abstract]
        [Export("qmui_isDynamicEffect")]
        bool Qmui_isDynamicEffect { get; }
    }

    // @interface QMUITheme (UIVisualEffect) <QMUIDynamicEffectProtocol>
    [Category]
    [BaseType(typeof(UIVisualEffect))]
    interface UIVisualEffect_QMUITheme : IQMUIDynamicEffectProtocol
    {
        // +(UIVisualEffect * _Nonnull)qmui_effectWithThemeProvider:(UIVisualEffect * _Nonnull (^ _Nonnull)(__kindof QMUIThemeManager * _Nonnull, __kindof NSObject<NSCopying> * _Nullable, __kindof NSObject * _Nullable))provider;
        [Static]
        [Export("qmui_effectWithThemeProvider:")]
        UIVisualEffect Qmui_effectWithThemeProvider(Func<QMUIThemeManager, NSCopying, NSObject, UIVisualEffect> provider);

        // +(UIVisualEffect * _Nonnull)qmui_effectWithThemeManagerName:(__kindof NSObject<NSCopying> * _Nonnull)name provider:(UIVisualEffect * _Nonnull (^ _Nonnull)(__kindof QMUIThemeManager * _Nonnull, __kindof NSObject<NSCopying> * _Nullable, __kindof NSObject * _Nullable))provider;
        [Static]
        [Export("qmui_effectWithThemeManagerName:provider:")]
        UIVisualEffect Qmui_effectWithThemeManagerName(NSCopying name, Func<QMUIThemeManager, NSCopying, NSObject, UIVisualEffect> provider);
    }

    // @interface QMUITheme (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_QMUITheme
    {
        // -(void)qmui_registerThemeColorProperties:(NSArray<NSString *> * _Nonnull)getters;
        [Export("qmui_registerThemeColorProperties:")]
        void Qmui_registerThemeColorProperties(string[] getters);

        // -(void)qmui_unregisterThemeColorProperties:(NSArray<NSString *> * _Nonnull)getters;
        [Export("qmui_unregisterThemeColorProperties:")]
        void Qmui_unregisterThemeColorProperties(string[] getters);

        // -(void)qmui_themeDidChangeByManager:(QMUIThemeManager * _Nullable)manager identifier:(__kindof NSObject<NSCopying> * _Nullable)identifier theme:(__kindof NSObject * _Nullable)theme __attribute__((objc_requires_super));
        [Export("qmui_themeDidChangeByManager:identifier:theme:")]
        [RequiresSuper]
        void Qmui_themeDidChangeByManager([NullAllowed] QMUIThemeManager manager, NSCopying identifier, NSObject theme);

        // @property (copy, nonatomic) void (^ _Nullable)(void) qmui_themeDidChangeBlock;
        [NullAllowed, Export("qmui_themeDidChangeBlock", ArgumentSemantic.Copy)]
        Action Qmui_themeDidChangeBlock { get; set; }
    }

    // @interface QMUITheme (UIViewController)
    [Category]
    [BaseType(typeof(UIViewController))]
    interface UIViewController_QMUITheme
    {
        // -(void)qmui_themeDidChangeByManager:(QMUIThemeManager * _Nonnull)manager identifier:(__kindof NSObject<NSCopying> * _Nonnull)identifier theme:(__kindof NSObject * _Nonnull)theme __attribute__((objc_requires_super));
        [Export("qmui_themeDidChangeByManager:identifier:theme:")]
        [RequiresSuper]
        void Qmui_themeDidChangeByManager(QMUIThemeManager manager, NSCopying identifier, NSObject theme);
    }

    // @interface QMUIToastView : UIView
    [BaseType(typeof(UIView))]
    interface QMUIToastView
    {
        // -(instancetype _Nonnull)initWithView:(UIView * _Nonnull)view __attribute__((objc_designated_initializer));
        [Export("initWithView:")]
        [DesignatedInitializer]
        IntPtr Constructor(UIView view);

        // @property (readonly, nonatomic, weak) UIView * _Nullable parentView;
        [NullAllowed, Export("parentView", ArgumentSemantic.Weak)]
        UIView ParentView { get; }

        // -(void)showAnimated:(BOOL)animated;
        [Export("showAnimated:")]
        void ShowAnimated(bool animated);

        // -(void)hideAnimated:(BOOL)animated;
        [Export("hideAnimated:")]
        void HideAnimated(bool animated);

        // -(void)hideAnimated:(BOOL)animated afterDelay:(NSTimeInterval)delay;
        [Export("hideAnimated:afterDelay:")]
        void HideAnimated(bool animated, double delay);

        // @property (copy, nonatomic) void (^ _Nullable)(UIView * _Nonnull, BOOL) willShowBlock;
        [NullAllowed, Export("willShowBlock", ArgumentSemantic.Copy)]
        Action<UIView, bool> WillShowBlock { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(UIView * _Nonnull, BOOL) didShowBlock;
        [NullAllowed, Export("didShowBlock", ArgumentSemantic.Copy)]
        Action<UIView, bool> DidShowBlock { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(UIView * _Nonnull, BOOL) willHideBlock;
        [NullAllowed, Export("willHideBlock", ArgumentSemantic.Copy)]
        Action<UIView, bool> WillHideBlock { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(UIView * _Nonnull, BOOL) didHideBlock;
        [NullAllowed, Export("didHideBlock", ArgumentSemantic.Copy)]
        Action<UIView, bool> DidHideBlock { get; set; }

        // @property (nonatomic, strong) QMUIToastAnimator * _Nullable toastAnimator;
        [NullAllowed, Export("toastAnimator", ArgumentSemantic.Strong)]
        QMUIToastAnimator ToastAnimator { get; set; }

        // @property (assign, nonatomic) QMUIToastViewPosition toastPosition;
        [Export("toastPosition", ArgumentSemantic.Assign)]
        QMUIToastViewPosition ToastPosition { get; set; }

        // @property (assign, nonatomic) BOOL removeFromSuperViewWhenHide;
        [Export("removeFromSuperViewWhenHide")]
        bool RemoveFromSuperViewWhenHide { get; set; }

        // @property (readonly, nonatomic, strong) UIView * _Nonnull maskView;
        [Export("maskView", ArgumentSemantic.Strong)]
        UIView MaskView { get; }

        // @property (nonatomic, strong) __kindof UIView * _Nonnull contentView;
        [Export("contentView", ArgumentSemantic.Strong)]
        UIView ContentView { get; set; }

        // @property (nonatomic, strong) __kindof UIView * _Nonnull backgroundView;
        [Export("backgroundView", ArgumentSemantic.Strong)]
        UIView BackgroundView { get; set; }

        // @property (assign, nonatomic) CGPoint offset __attribute__((annotate("ui_appearance_selector")));
        [Export("offset", ArgumentSemantic.Assign)]
        CGPoint Offset { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets marginInsets __attribute__((annotate("ui_appearance_selector")));
        [Export("marginInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets MarginInsets { get; set; }
    }

    // @interface ToastTool (QMUIToastView)
    [Category]
    [BaseType(typeof(QMUIToastView))]
    interface QMUIToastView_ToastTool
    {
        // +(BOOL)hideAllToastInView:(UIView * _Nullable)view animated:(BOOL)animated;
        [Static]
        [Export("hideAllToastInView:animated:")]
        bool HideAllToastInView([NullAllowed] UIView view, bool animated);

        // +(__kindof UIView * _Nullable)toastInView:(UIView * _Nonnull)view;
        [Static]
        [Export("toastInView:")]
        UIView ToastInView(UIView view);

        // +(NSArray<QMUIToastView *> * _Nullable)allToastInView:(UIView * _Nonnull)view;
        [Static]
        [Export("allToastInView:")]
        [return: NullAllowed]
        QMUIToastView[] AllToastInView(UIView view);
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const NSInteger QMUITipsAutomaticallyHideToastSeconds;
        [Field("QMUITipsAutomaticallyHideToastSeconds", "__Internal")]
        nint QMUITipsAutomaticallyHideToastSeconds { get; }
    }

    // @interface QMUITips : QMUIToastView
    [BaseType(typeof(QMUIToastView))]
    interface QMUITips
    {
        // -(void)showLoading;
        [Export("showLoading")]
        void ShowLoading();

        // -(void)showLoading:(NSString * _Nullable)text;
        [Export("showLoading:")]
        void ShowLoading([NullAllowed] string text);

        // -(void)showLoadingHideAfterDelay:(NSTimeInterval)delay;
        [Export("showLoadingHideAfterDelay:")]
        void ShowLoadingHideAfterDelay(double delay);

        // -(void)showLoading:(NSString * _Nullable)text hideAfterDelay:(NSTimeInterval)delay;
        [Export("showLoading:hideAfterDelay:")]
        void ShowLoading([NullAllowed] string text, double delay);

        // -(void)showLoading:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText;
        [Export("showLoading:detailText:")]
        void ShowLoading([NullAllowed] string text, [NullAllowed] string detailText);

        // -(void)showLoading:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText hideAfterDelay:(NSTimeInterval)delay;
        [Export("showLoading:detailText:hideAfterDelay:")]
        void ShowLoading([NullAllowed] string text, [NullAllowed] string detailText, double delay);

        // -(void)showWithText:(NSString * _Nullable)text;
        [Export("showWithText:")]
        void ShowWithText([NullAllowed] string text);

        // -(void)showWithText:(NSString * _Nullable)text hideAfterDelay:(NSTimeInterval)delay;
        [Export("showWithText:hideAfterDelay:")]
        void ShowWithText([NullAllowed] string text, double delay);

        // -(void)showWithText:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText;
        [Export("showWithText:detailText:")]
        void ShowWithText([NullAllowed] string text, [NullAllowed] string detailText);

        // -(void)showWithText:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText hideAfterDelay:(NSTimeInterval)delay;
        [Export("showWithText:detailText:hideAfterDelay:")]
        void ShowWithText([NullAllowed] string text, [NullAllowed] string detailText, double delay);

        // -(void)showSucceed:(NSString * _Nullable)text;
        [Export("showSucceed:")]
        void ShowSucceed([NullAllowed] string text);

        // -(void)showSucceed:(NSString * _Nullable)text hideAfterDelay:(NSTimeInterval)delay;
        [Export("showSucceed:hideAfterDelay:")]
        void ShowSucceed([NullAllowed] string text, double delay);

        // -(void)showSucceed:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText;
        [Export("showSucceed:detailText:")]
        void ShowSucceed([NullAllowed] string text, [NullAllowed] string detailText);

        // -(void)showSucceed:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText hideAfterDelay:(NSTimeInterval)delay;
        [Export("showSucceed:detailText:hideAfterDelay:")]
        void ShowSucceed([NullAllowed] string text, [NullAllowed] string detailText, double delay);

        // -(void)showError:(NSString * _Nullable)text;
        [Export("showError:")]
        void ShowError([NullAllowed] string text);

        // -(void)showError:(NSString * _Nullable)text hideAfterDelay:(NSTimeInterval)delay;
        [Export("showError:hideAfterDelay:")]
        void ShowError([NullAllowed] string text, double delay);

        // -(void)showError:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText;
        [Export("showError:detailText:")]
        void ShowError([NullAllowed] string text, [NullAllowed] string detailText);

        // -(void)showError:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText hideAfterDelay:(NSTimeInterval)delay;
        [Export("showError:detailText:hideAfterDelay:")]
        void ShowError([NullAllowed] string text, [NullAllowed] string detailText, double delay);

        // -(void)showInfo:(NSString * _Nullable)text;
        [Export("showInfo:")]
        void ShowInfo([NullAllowed] string text);

        // -(void)showInfo:(NSString * _Nullable)text hideAfterDelay:(NSTimeInterval)delay;
        [Export("showInfo:hideAfterDelay:")]
        void ShowInfo([NullAllowed] string text, double delay);

        // -(void)showInfo:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText;
        [Export("showInfo:detailText:")]
        void ShowInfo([NullAllowed] string text, [NullAllowed] string detailText);

        // -(void)showInfo:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText hideAfterDelay:(NSTimeInterval)delay;
        [Export("showInfo:detailText:hideAfterDelay:")]
        void ShowInfo([NullAllowed] string text, [NullAllowed] string detailText, double delay);

        // +(QMUITips * _Nonnull)createTipsToView:(UIView * _Nonnull)view;
        [Static]
        [Export("createTipsToView:")]
        QMUITips CreateTipsToView(UIView view);

        // +(QMUITips * _Nonnull)showLoadingInView:(UIView * _Nonnull)view;
        [Static]
        [Export("showLoadingInView:")]
        QMUITips ShowLoadingInView(UIView view);

        // +(QMUITips * _Nonnull)showLoading:(NSString * _Nullable)text inView:(UIView * _Nonnull)view;
        [Static]
        [Export("showLoading:inView:")]
        QMUITips ShowLoading([NullAllowed] string text, UIView view);

        // +(QMUITips * _Nonnull)showLoadingInView:(UIView * _Nonnull)view hideAfterDelay:(NSTimeInterval)delay;
        [Static]
        [Export("showLoadingInView:hideAfterDelay:")]
        QMUITips ShowLoadingInView(UIView view, double delay);

        // +(QMUITips * _Nonnull)showLoading:(NSString * _Nullable)text inView:(UIView * _Nonnull)view hideAfterDelay:(NSTimeInterval)delay;
        [Static]
        [Export("showLoading:inView:hideAfterDelay:")]
        QMUITips ShowLoading([NullAllowed] string text, UIView view, double delay);

        // +(QMUITips * _Nonnull)showLoading:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText inView:(UIView * _Nonnull)view;
        [Static]
        [Export("showLoading:detailText:inView:")]
        QMUITips ShowLoading([NullAllowed] string text, [NullAllowed] string detailText, UIView view);

        // +(QMUITips * _Nonnull)showLoading:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText inView:(UIView * _Nonnull)view hideAfterDelay:(NSTimeInterval)delay;
        [Static]
        [Export("showLoading:detailText:inView:hideAfterDelay:")]
        QMUITips ShowLoading([NullAllowed] string text, [NullAllowed] string detailText, UIView view, double delay);

        // +(QMUITips * _Nonnull)showWithText:(NSString * _Nullable)text;
        [Static]
        [Export("showWithText:")]
        QMUITips ShowWithTextStatic([NullAllowed] string text);

        // +(QMUITips * _Nonnull)showWithText:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText;
        [Static]
        [Export("showWithText:detailText:")]
        QMUITips ShowWithTextStatic([NullAllowed] string text, [NullAllowed] string detailText);

        // +(QMUITips * _Nonnull)showWithText:(NSString * _Nullable)text inView:(UIView * _Nonnull)view;
        [Static]
        [Export("showWithText:inView:")]
        QMUITips ShowWithTextStatic([NullAllowed] string text, UIView view);

        // +(QMUITips * _Nonnull)showWithText:(NSString * _Nullable)text inView:(UIView * _Nonnull)view hideAfterDelay:(NSTimeInterval)delay;
        [Static]
        [Export("showWithText:inView:hideAfterDelay:")]
        QMUITips ShowWithTextStatic([NullAllowed] string text, UIView view, double delay);

        // +(QMUITips * _Nonnull)showWithText:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText inView:(UIView * _Nonnull)view;
        [Static]
        [Export("showWithText:detailText:inView:")]
        QMUITips ShowWithTextStatic([NullAllowed] string text, [NullAllowed] string detailText, UIView view);

        // +(QMUITips * _Nonnull)showWithText:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText inView:(UIView * _Nonnull)view hideAfterDelay:(NSTimeInterval)delay;
        [Static]
        [Export("showWithText:detailText:inView:hideAfterDelay:")]
        QMUITips ShowWithTextStatic([NullAllowed] string text, [NullAllowed] string detailText, UIView view, double delay);

        // +(QMUITips * _Nonnull)showSucceed:(NSString * _Nullable)text;
        [Static]
        [Export("showSucceed:")]
        QMUITips ShowSucceedStatic([NullAllowed] string text);

        // +(QMUITips * _Nonnull)showSucceed:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText;
        [Static]
        [Export("showSucceed:detailText:")]
        QMUITips ShowSucceedStatic([NullAllowed] string text, [NullAllowed] string detailText);

        // +(QMUITips * _Nonnull)showSucceed:(NSString * _Nullable)text inView:(UIView * _Nonnull)view;
        [Static]
        [Export("showSucceed:inView:")]
        QMUITips ShowSucceedStatic([NullAllowed] string text, UIView view);

        // +(QMUITips * _Nonnull)showSucceed:(NSString * _Nullable)text inView:(UIView * _Nonnull)view hideAfterDelay:(NSTimeInterval)delay;
        [Static]
        [Export("showSucceed:inView:hideAfterDelay:")]
        QMUITips ShowSucceedStatic([NullAllowed] string text, UIView view, double delay);

        // +(QMUITips * _Nonnull)showSucceed:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText inView:(UIView * _Nonnull)view;
        [Static]
        [Export("showSucceed:detailText:inView:")]
        QMUITips ShowSucceedStatic([NullAllowed] string text, [NullAllowed] string detailText, UIView view);

        // +(QMUITips * _Nonnull)showSucceed:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText inView:(UIView * _Nonnull)view hideAfterDelay:(NSTimeInterval)delay;
        [Static]
        [Export("showSucceed:detailText:inView:hideAfterDelay:")]
        QMUITips ShowSucceedStatic([NullAllowed] string text, [NullAllowed] string detailText, UIView view, double delay);

        // +(QMUITips * _Nonnull)showError:(NSString * _Nullable)text;
        [Static]
        [Export("showError:")]
        QMUITips ShowErrorStatic([NullAllowed] string text);

        // +(QMUITips * _Nonnull)showError:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText;
        [Static]
        [Export("showError:detailText:")]
        QMUITips ShowErrorStatic([NullAllowed] string text, [NullAllowed] string detailText);

        // +(QMUITips * _Nonnull)showError:(NSString * _Nullable)text inView:(UIView * _Nonnull)view;
        [Static]
        [Export("showError:inView:")]
        QMUITips ShowErrorStatic([NullAllowed] string text, UIView view);

        // +(QMUITips * _Nonnull)showError:(NSString * _Nullable)text inView:(UIView * _Nonnull)view hideAfterDelay:(NSTimeInterval)delay;
        [Static]
        [Export("showError:inView:hideAfterDelay:")]
        QMUITips ShowErrorStatic([NullAllowed] string text, UIView view, double delay);

        // +(QMUITips * _Nonnull)showError:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText inView:(UIView * _Nonnull)view;
        [Static]
        [Export("showError:detailText:inView:")]
        QMUITips ShowErrorStatic([NullAllowed] string text, [NullAllowed] string detailText, UIView view);

        // +(QMUITips * _Nonnull)showError:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText inView:(UIView * _Nonnull)view hideAfterDelay:(NSTimeInterval)delay;
        [Static]
        [Export("showError:detailText:inView:hideAfterDelay:")]
        QMUITips ShowErrorStatic([NullAllowed] string text, [NullAllowed] string detailText, UIView view, double delay);

        // +(QMUITips * _Nonnull)showInfo:(NSString * _Nullable)text;
        [Static]
        [Export("showInfo:")]
        QMUITips ShowInfoStatic([NullAllowed] string text);

        // +(QMUITips * _Nonnull)showInfo:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText;
        [Static]
        [Export("showInfo:detailText:")]
        QMUITips ShowInfoStatic([NullAllowed] string text, [NullAllowed] string detailText);

        // +(QMUITips * _Nonnull)showInfo:(NSString * _Nullable)text inView:(UIView * _Nonnull)view;
        [Static]
        [Export("showInfo:inView:")]
        QMUITips ShowInfoStatic([NullAllowed] string text, UIView view);

        // +(QMUITips * _Nonnull)showInfo:(NSString * _Nullable)text inView:(UIView * _Nonnull)view hideAfterDelay:(NSTimeInterval)delay;
        [Static]
        [Export("showInfo:inView:hideAfterDelay:")]
        QMUITips ShowInfoStatic([NullAllowed] string text, UIView view, double delay);

        // +(QMUITips * _Nonnull)showInfo:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText inView:(UIView * _Nonnull)view;
        [Static]
        [Export("showInfo:detailText:inView:")]
        QMUITips ShowInfoStatic([NullAllowed] string text, [NullAllowed] string detailText, UIView view);

        // +(QMUITips * _Nonnull)showInfo:(NSString * _Nullable)text detailText:(NSString * _Nullable)detailText inView:(UIView * _Nonnull)view hideAfterDelay:(NSTimeInterval)delay;
        [Static]
        [Export("showInfo:detailText:inView:hideAfterDelay:")]
        QMUITips ShowInfoStatic([NullAllowed] string text, [NullAllowed] string detailText, UIView view, double delay);

        // +(void)hideAllTipsInView:(UIView * _Nonnull)view;
        [Static]
        [Export("hideAllTipsInView:")]
        void HideAllTipsInView(UIView view);

        // +(void)hideAllTips;
        [Static]
        [Export("hideAllTips")]
        void HideAllTips();

        // +(NSTimeInterval)smartDelaySecondsForTipsText:(NSString * _Nonnull)text;
        [Static]
        [Export("smartDelaySecondsForTipsText:")]
        double SmartDelaySecondsForTipsText(string text);
    }

    // @protocol QMUIToastAnimatorDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIToastAnimatorDelegate
    {
        // @required -(void)showWithCompletion:(void (^)(BOOL))completion;
        [Abstract]
        [Export("showWithCompletion:")]
        void ShowWithCompletion(Action<bool> completion);

        // @required -(void)hideWithCompletion:(void (^)(BOOL))completion;
        [Abstract]
        [Export("hideWithCompletion:")]
        void HideWithCompletion(Action<bool> completion);

        // @required -(BOOL)isShowing;
        [Abstract]
        [Export("isShowing")]
        [Verify(MethodToProperty)]
        bool IsShowing { get; }

        // @required -(BOOL)isAnimating;
        [Abstract]
        [Export("isAnimating")]
        [Verify(MethodToProperty)]
        bool IsAnimating { get; }
    }

    // @interface QMUIToastAnimator : NSObject <QMUIToastAnimatorDelegate>
    [BaseType(typeof(NSObject))]
    interface QMUIToastAnimator : IQMUIToastAnimatorDelegate
    {
        // -(instancetype)initWithToastView:(QMUIToastView *)toastView __attribute__((objc_designated_initializer));
        [Export("initWithToastView:")]
        [DesignatedInitializer]
        IntPtr Constructor(QMUIToastView toastView);

        // @property (readonly, nonatomic, weak) QMUIToastView * toastView;
        [Export("toastView", ArgumentSemantic.Weak)]
        QMUIToastView ToastView { get; }

        // @property (assign, nonatomic) QMUIToastAnimationType animationType;
        [Export("animationType", ArgumentSemantic.Assign)]
        QMUIToastAnimationType AnimationType { get; set; }
    }

    // @interface QMUIToastBackgroundView : UIView
    [BaseType(typeof(UIView))]
    interface QMUIToastBackgroundView
    {
        // @property (assign, nonatomic) BOOL shouldBlurBackgroundView;
        [Export("shouldBlurBackgroundView")]
        bool ShouldBlurBackgroundView { get; set; }

        // @property (readonly, nonatomic, strong) QMUIVisualEffectView * _Nullable effectView;
        [NullAllowed, Export("effectView", ArgumentSemantic.Strong)]
        QMUIVisualEffectView EffectView { get; }

        // @property (nonatomic, strong) UIColor * _Nullable styleColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("styleColor", ArgumentSemantic.Strong)]
        UIColor StyleColor { get; set; }

        // @property (assign, nonatomic) CGFloat cornerRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }
    }

    // @interface QMUIToastContentView : UIView
    [BaseType(typeof(UIView))]
    interface QMUIToastContentView
    {
        // @property (nonatomic, strong) UIView * customView;
        [Export("customView", ArgumentSemantic.Strong)]
        UIView CustomView { get; set; }

        // @property (readonly, nonatomic, strong) UILabel * textLabel;
        [Export("textLabel", ArgumentSemantic.Strong)]
        UILabel TextLabel { get; }

        // @property (copy, nonatomic) NSString * textLabelText;
        [Export("textLabelText")]
        string TextLabelText { get; set; }

        // @property (readonly, nonatomic, strong) UILabel * detailTextLabel;
        [Export("detailTextLabel", ArgumentSemantic.Strong)]
        UILabel DetailTextLabel { get; }

        // @property (copy, nonatomic) NSString * detailTextLabelText;
        [Export("detailTextLabelText")]
        string DetailTextLabelText { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets insets __attribute__((annotate("ui_appearance_selector")));
        [Export("insets", ArgumentSemantic.Assign)]
        UIEdgeInsets Insets { get; set; }

        // @property (assign, nonatomic) CGSize minimumSize __attribute__((annotate("ui_appearance_selector")));
        [Export("minimumSize", ArgumentSemantic.Assign)]
        CGSize MinimumSize { get; set; }

        // @property (assign, nonatomic) CGFloat customViewMarginBottom __attribute__((annotate("ui_appearance_selector")));
        [Export("customViewMarginBottom")]
        nfloat CustomViewMarginBottom { get; set; }

        // @property (assign, nonatomic) CGFloat textLabelMarginBottom __attribute__((annotate("ui_appearance_selector")));
        [Export("textLabelMarginBottom")]
        nfloat TextLabelMarginBottom { get; set; }

        // @property (assign, nonatomic) CGFloat detailTextLabelMarginBottom __attribute__((annotate("ui_appearance_selector")));
        [Export("detailTextLabelMarginBottom")]
        nfloat DetailTextLabelMarginBottom { get; set; }

        // @property (nonatomic, strong) NSDictionary<NSString *,id> * textLabelAttributes __attribute__((annotate("ui_appearance_selector")));
        [Export("textLabelAttributes", ArgumentSemantic.Strong)]
        NSDictionary<NSString, NSObject> TextLabelAttributes { get; set; }

        // @property (nonatomic, strong) NSDictionary<NSString *,id> * detailTextLabelAttributes __attribute__((annotate("ui_appearance_selector")));
        [Export("detailTextLabelAttributes", ArgumentSemantic.Strong)]
        NSDictionary<NSString, NSObject> DetailTextLabelAttributes { get; set; }
    }

    // @interface QMUIToolbarButton : UIButton
    [BaseType(typeof(UIButton))]
    interface QMUIToolbarButton
    {
        // @property (readonly, assign, nonatomic) QMUIToolbarButtonType type;
        [Export("type", ArgumentSemantic.Assign)]
        QMUIToolbarButtonType Type { get; }

        // -(instancetype _Nonnull)initWithType:(QMUIToolbarButtonType)type;
        [Export("initWithType:")]
        IntPtr Constructor(QMUIToolbarButtonType type);

        // -(instancetype _Nonnull)initWithType:(QMUIToolbarButtonType)type title:(NSString * _Nullable)title;
        [Export("initWithType:title:")]
        IntPtr Constructor(QMUIToolbarButtonType type, [NullAllowed] string title);

        // -(instancetype _Nonnull)initWithImage:(UIImage * _Nonnull)image;
        [Export("initWithImage:")]
        IntPtr Constructor(UIImage image);

        // +(UIBarButtonItem * _Nullable)barButtonItemWithToolbarButton:(QMUIToolbarButton * _Nonnull)button target:(id _Nullable)target action:(SEL _Nullable)selector;
        [Static]
        [Export("barButtonItemWithToolbarButton:target:action:")]
        [return: NullAllowed]
        UIBarButtonItem BarButtonItemWithToolbarButton(QMUIToolbarButton button, [NullAllowed] NSObject target, [NullAllowed] Selector selector);

        // +(UIBarButtonItem * _Nullable)barButtonItemWithType:(QMUIToolbarButtonType)type title:(NSString * _Nullable)title target:(id _Nullable)target action:(SEL _Nullable)selector;
        [Static]
        [Export("barButtonItemWithType:title:target:action:")]
        [return: NullAllowed]
        UIBarButtonItem BarButtonItemWithType(QMUIToolbarButtonType type, [NullAllowed] string title, [NullAllowed] NSObject target, [NullAllowed] Selector selector);

        // +(UIBarButtonItem * _Nullable)barButtonItemWithImage:(UIImage * _Nullable)image target:(id _Nullable)target action:(SEL _Nullable)selector;
        [Static]
        [Export("barButtonItemWithImage:target:action:")]
        [return: NullAllowed]
        UIBarButtonItem BarButtonItemWithImage([NullAllowed] UIImage image, [NullAllowed] NSObject target, [NullAllowed] Selector selector);
    }

    // @interface QMUIVisualEffectView : UIVisualEffectView
    [BaseType(typeof(UIVisualEffectView))]
    interface QMUIVisualEffectView
    {
        // @property (nonatomic, strong) UIColor * foregroundColor __attribute__((annotate("ui_appearance_selector")));
        [Export("foregroundColor", ArgumentSemantic.Strong)]
        UIColor ForegroundColor { get; set; }
    }

    // @protocol QMUIWindowSizeMonitorProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIWindowSizeMonitorProtocol
    {
        // @optional -(void)windowDidTransitionToSize:(CGSize)size;
        [Export("windowDidTransitionToSize:")]
        void WindowDidTransitionToSize(CGSize size);
    }
 
    //// @interface QMUIWindowSizeMonitor (UIResponder) <QMUIWindowSizeMonitorProtocol>
    //[Category]
    //[BaseType(typeof(UIResponder))]
    //interface UIResponder_QMUIWindowSizeMonitor : IQMUIWindowSizeMonitorProtocol
    //{
    //}

    // typedef void (^QMUIWindowSizeObserverHandler)(CGSize);
    delegate void QMUIWindowSizeObserverHandler(CGSize arg0);

    // @interface QMUIWindowSizeMonitor (NSObject)
    [Category]
    [BaseType(typeof(NSObject))]
    interface NSObject_QMUIWindowSizeMonitor
    {
        // -(void)qmui_addSizeObserverForMainWindow:(QMUIWindowSizeObserverHandler _Nonnull)handler;
        [Export("qmui_addSizeObserverForMainWindow:")]
        void Qmui_addSizeObserverForMainWindow(QMUIWindowSizeObserverHandler handler);

        // -(void)qmui_addSizeObserverForWindow:(UIWindow * _Nonnull)window handler:(QMUIWindowSizeObserverHandler _Nonnull)handler;
        [Export("qmui_addSizeObserverForWindow:handler:")]
        void Qmui_addSizeObserverForWindow(UIWindow window, QMUIWindowSizeObserverHandler handler);
    }

    // @interface QMUI (UIActivityIndicatorView)
    [Category]
    [BaseType(typeof(UIActivityIndicatorView))]
    interface UIActivityIndicatorView_QMUI
    {
        // -(instancetype)initWithActivityIndicatorStyle:(UIActivityIndicatorViewStyle)style size:(CGSize)size;
        [Export("initWithActivityIndicatorStyle:size:")]
        IntPtr Constructor(UIActivityIndicatorViewStyle style, CGSize size);
    }

    // @interface QMUI (UIBarItem)
    [Category]
    [BaseType(typeof(UIBarItem))]
    interface UIBarItem_QMUI
    {
        // @property (readonly, nonatomic, weak) UIView * _Nullable qmui_view;
        [NullAllowed, Export("qmui_view", ArgumentSemantic.Weak)]
        UIView Qmui_view { get; }

        // @property (copy, nonatomic) void (^ _Nullable)(__kindof UIBarItem * _Nonnull, UIView * _Nullable) qmui_viewDidSetBlock;
        [NullAllowed, Export("qmui_viewDidSetBlock", ArgumentSemantic.Copy)]
        Action<UIBarItem, UIView> Qmui_viewDidSetBlock { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(__kindof UIBarItem * _Nonnull, UIView * _Nullable) qmui_viewDidLayoutSubviewsBlock;
        [NullAllowed, Export("qmui_viewDidLayoutSubviewsBlock", ArgumentSemantic.Copy)]
        Action<UIBarItem, UIView> Qmui_viewDidLayoutSubviewsBlock { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(__kindof UIBarItem * _Nonnull, UIView * _Nullable) qmui_viewLayoutDidChangeBlock;
        [NullAllowed, Export("qmui_viewLayoutDidChangeBlock", ArgumentSemantic.Copy)]
        Action<UIBarItem, UIView> Qmui_viewLayoutDidChangeBlock { get; set; }
    }

    interface IQMUIBadgeProtocol
    {
    }

    // @interface QMUIBadge (UIBarItem) <QMUIBadgeProtocol>
    [Category]
    [BaseType(typeof(UIBarItem))]
    interface UIBarItem_QMUIBadge : IQMUIBadgeProtocol
    {
    }

    // @interface QMUI (UIBezierPath)
    [Category]
    [BaseType(typeof(UIBezierPath))]
    interface UIBezierPath_QMUI
    {
        // +(UIBezierPath *)qmui_bezierPathWithRoundedRect:(CGRect)rect cornerRadiusArray:(NSArray<NSNumber *> *)cornerRadius lineWidth:(CGFloat)lineWidth;
        [Static]
        [Export("qmui_bezierPathWithRoundedRect:cornerRadiusArray:lineWidth:")]
        UIBezierPath Qmui_bezierPathWithRoundedRect(CGRect rect, NSNumber[] cornerRadius, nfloat lineWidth);
    }

    // @interface QMUI (UIButton)
    [Category]
    [BaseType(typeof(UIButton))]
    interface UIButton_QMUI
    {
        // -(instancetype)qmui_initWithImage:(UIImage *)image title:(NSString *)title;
        [Export("qmui_initWithImage:title:")]
        UIButton Qmui_initWithImage(UIImage image, string title);

        // -(BOOL)qmui_hasCustomizedButtonPropForState:(UIControlState)state;
        [Export("qmui_hasCustomizedButtonPropForState:")]
        bool Qmui_hasCustomizedButtonPropForState(UIControlState state);

        // -(BOOL)qmui_hasCustomizedButtonPropWithType:(QMUICustomizeButtonPropType)type forState:(UIControlState)state;
        [Export("qmui_hasCustomizedButtonPropWithType:forState:")]
        bool Qmui_hasCustomizedButtonPropWithType(QMUICustomizeButtonPropType type, UIControlState state);

        // -(void)qmui_calculateHeightAfterSetAppearance;
        [Export("qmui_calculateHeightAfterSetAppearance")]
        void Qmui_calculateHeightAfterSetAppearance();

        // -(void)qmui_setTitleAttributes:(NSDictionary<NSAttributedStringKey,id> *)attributes forState:(UIControlState)state;
        [Export("qmui_setTitleAttributes:forState:")]
        void Qmui_setTitleAttributes(NSDictionary<NSString, NSObject> attributes, UIControlState state);
    }

    // @interface QMUI (UICollectionView)
    [Category]
    [BaseType(typeof(UICollectionView))]
    interface UICollectionView_QMUI
    {
        // -(void)qmui_clearsSelection;
        [Export("qmui_clearsSelection")]
        void Qmui_clearsSelection();

        // -(void)qmui_reloadDataKeepingSelection;
        [Export("qmui_reloadDataKeepingSelection")]
        void Qmui_reloadDataKeepingSelection();

        // -(NSIndexPath *)qmui_indexPathForItemAtView:(id)sender;
        [Export("qmui_indexPathForItemAtView:")]
        NSIndexPath Qmui_indexPathForItemAtView(NSObject sender);

        // -(BOOL)qmui_itemVisibleAtIndexPath:(NSIndexPath *)indexPath;
        [Export("qmui_itemVisibleAtIndexPath:")]
        bool Qmui_itemVisibleAtIndexPath(NSIndexPath indexPath);

        // -(NSArray<NSIndexPath *> *)qmui_indexPathsForVisibleItems;
        [Export("qmui_indexPathsForVisibleItems")]
        [Verify(MethodToProperty)]
        NSIndexPath[] Qmui_indexPathsForVisibleItems { get; }

        // -(NSIndexPath *)qmui_indexPathForFirstVisibleCell;
        [Export("qmui_indexPathForFirstVisibleCell")]
        [Verify(MethodToProperty)]
        NSIndexPath Qmui_indexPathForFirstVisibleCell { get; }
    }

    // @protocol QMUICellSizeKeyCache_UICollectionViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUICellSizeKeyCache_UICollectionViewDelegate
    {
        // @optional -(id<NSCopying> _Nonnull)qmui_collectionView:(UICollectionView * _Nonnull)collectionView cacheKeyForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("qmui_collectionView:cacheKeyForItemAtIndexPath:")]
        NSCopying CacheKeyForItemAtIndexPath(UICollectionView collectionView, NSIndexPath indexPath);
    }

    // @interface QMUICellSizeKeyCache (UICollectionView)
    [Category]
    [BaseType(typeof(UICollectionView))]
    interface UICollectionView_QMUICellSizeKeyCache
    {
        // @property (assign, nonatomic) BOOL qmui_cacheCellSizeByKeyAutomatically;
        [Export("qmui_cacheCellSizeByKeyAutomatically")]
        bool Qmui_cacheCellSizeByKeyAutomatically { get; set; }

        // @property (readonly, nonatomic, weak) QMUICellSizeKeyCache * _Nullable qmui_currentCellSizeKeyCache;
        [NullAllowed, Export("qmui_currentCellSizeKeyCache", ArgumentSemantic.Weak)]
        QMUICellSizeKeyCache Qmui_currentCellSizeKeyCache { get; }
    }

    // @interface QMUI (UIColor)
    [Category]
    [BaseType(typeof(UIColor))]
    interface UIColor_QMUI
    {
        // +(UIColor * _Nullable)qmui_colorWithHexString:(NSString * _Nullable)hexString;
        [Static]
        [Export("qmui_colorWithHexString:")]
        [return: NullAllowed]
        UIColor Qmui_colorWithHexString([NullAllowed] string hexString);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull qmui_hexString;
        [Export("qmui_hexString")]
        string Qmui_hexString { get; }

        // +(UIColor * _Nullable)qmui_colorWithRGBAString:(NSString * _Nullable)rgbaString;
        [Static]
        [Export("qmui_colorWithRGBAString:")]
        [return: NullAllowed]
        UIColor Qmui_colorWithRGBAString([NullAllowed] string rgbaString);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull qmui_RGBAString;
        [Export("qmui_RGBAString")]
        string Qmui_RGBAString { get; }

        // @property (readonly, assign, nonatomic) CGFloat qmui_red;
        [Export("qmui_red")]
        nfloat Qmui_red { get; }

        // @property (readonly, assign, nonatomic) CGFloat qmui_green;
        [Export("qmui_green")]
        nfloat Qmui_green { get; }

        // @property (readonly, assign, nonatomic) CGFloat qmui_blue;
        [Export("qmui_blue")]
        nfloat Qmui_blue { get; }

        // @property (readonly, assign, nonatomic) CGFloat qmui_alpha;
        [Export("qmui_alpha")]
        nfloat Qmui_alpha { get; }

        // @property (readonly, assign, nonatomic) CGFloat qmui_hue;
        [Export("qmui_hue")]
        nfloat Qmui_hue { get; }

        // @property (readonly, assign, nonatomic) CGFloat qmui_saturation;
        [Export("qmui_saturation")]
        nfloat Qmui_saturation { get; }

        // @property (readonly, assign, nonatomic) CGFloat qmui_brightness;
        [Export("qmui_brightness")]
        nfloat Qmui_brightness { get; }

        // -(UIColor * _Nullable)qmui_colorWithoutAlpha;
        [NullAllowed, Export("qmui_colorWithoutAlpha")]
        [Verify(MethodToProperty)]
        UIColor Qmui_colorWithoutAlpha { get; }

        // -(UIColor * _Nonnull)qmui_colorWithAlpha:(CGFloat)alpha backgroundColor:(UIColor * _Nullable)backgroundColor;
        [Export("qmui_colorWithAlpha:backgroundColor:")]
        UIColor Qmui_colorWithAlpha(nfloat alpha, [NullAllowed] UIColor backgroundColor);

        // -(UIColor * _Nonnull)qmui_colorWithAlphaAddedToWhite:(CGFloat)alpha;
        [Export("qmui_colorWithAlphaAddedToWhite:")]
        UIColor Qmui_colorWithAlphaAddedToWhite(nfloat alpha);

        // -(UIColor * _Nonnull)qmui_transitionToColor:(UIColor * _Nullable)toColor progress:(CGFloat)progress;
        [Export("qmui_transitionToColor:progress:")]
        UIColor Qmui_transitionToColor([NullAllowed] UIColor toColor, nfloat progress);

        // @property (readonly, assign, nonatomic) BOOL qmui_colorIsDark;
        [Export("qmui_colorIsDark")]
        bool Qmui_colorIsDark { get; }

        // -(UIColor * _Nonnull)qmui_inverseColor;
        [Export("qmui_inverseColor")]
        [Verify(MethodToProperty)]
        UIColor Qmui_inverseColor { get; }

        // @property (readonly, assign, nonatomic) BOOL qmui_isSystemTintColor;
        [Export("qmui_isSystemTintColor")]
        bool Qmui_isSystemTintColor { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull qmui_systemTintColor;
        [Static]
        [Export("qmui_systemTintColor", ArgumentSemantic.Strong)]
        UIColor Qmui_systemTintColor { get; }

        // +(UIColor * _Nonnull)qmui_colorWithBackendColor:(UIColor * _Nonnull)backendColor frontColor:(UIColor * _Nonnull)frontColor;
        [Static]
        [Export("qmui_colorWithBackendColor:frontColor:")]
        UIColor Qmui_colorWithBackendColor(UIColor backendColor, UIColor frontColor);

        // +(UIColor * _Nonnull)qmui_colorFromColor:(UIColor * _Nonnull)fromColor toColor:(UIColor * _Nonnull)toColor progress:(CGFloat)progress;
        [Static]
        [Export("qmui_colorFromColor:toColor:progress:")]
        UIColor Qmui_colorFromColor(UIColor fromColor, UIColor toColor, nfloat progress);

        // +(UIColor * _Nonnull)qmui_randomColor;
        [Static]
        [Export("qmui_randomColor")]
        [Verify(MethodToProperty)]
        UIColor Qmui_randomColor { get; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const _Nonnull QMUICGColorOriginalColorBindKey;
        [Field("QMUICGColorOriginalColorBindKey", "__Internal")]
        NSString QMUICGColorOriginalColorBindKey { get; }
    }

    // @protocol QMUIDynamicColorProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface QMUIDynamicColorProtocol
    {
        // @required @property (readonly, nonatomic, strong) UIColor * _Nonnull qmui_rawColor;
        [Abstract]
        [Export("qmui_rawColor", ArgumentSemantic.Strong)]
        UIColor Qmui_rawColor { get; }

        // @required @property (readonly, assign, nonatomic) BOOL qmui_isDynamicColor;
        [Abstract]
        [Export("qmui_isDynamicColor")]
        bool Qmui_isDynamicColor { get; }

        // @required @property (readonly, assign, nonatomic) BOOL qmui_isQMUIDynamicColor;
        [Abstract]
        [Export("qmui_isQMUIDynamicColor")]
        bool Qmui_isQMUIDynamicColor { get; }

        // @optional @property (readonly, assign, nonatomic) BOOL _isDynamic;
        [Export("_isDynamic")]
        bool _isDynamic { get; }
    }

    // @interface QMUI_DynamicColor (UIColor) <QMUIDynamicColorProtocol>
    [Category]
    [BaseType(typeof(UIColor))]
    interface UIColor_QMUI_DynamicColor : IQMUIDynamicColorProtocol
    {
    }

    // @interface QMUI (UIFont)
    [Category]
    [BaseType(typeof(UIFont))]
    interface UIFont_QMUI
    {
        // +(UIFont *)qmui_lightSystemFontOfSize:(CGFloat)fontSize;
        [Static]
        [Export("qmui_lightSystemFontOfSize:")]
        UIFont Qmui_lightSystemFontOfSize(nfloat fontSize);

        // +(UIFont *)qmui_systemFontOfSize:(CGFloat)size weight:(QMUIFontWeight)weight italic:(BOOL)italic;
        [Static]
        [Export("qmui_systemFontOfSize:weight:italic:")]
        UIFont Qmui_systemFontOfSize(nfloat size, QMUIFontWeight weight, bool italic);

        // +(UIFont *)qmui_dynamicSystemFontOfSize:(CGFloat)size weight:(QMUIFontWeight)weight italic:(BOOL)italic;
        [Static]
        [Export("qmui_dynamicSystemFontOfSize:weight:italic:")]
        UIFont Qmui_dynamicSystemFontOfSize(nfloat size, QMUIFontWeight weight, bool italic);

        // +(UIFont *)qmui_dynamicSystemFontOfSize:(CGFloat)pointSize upperLimitSize:(CGFloat)upperLimitSize lowerLimitSize:(CGFloat)lowerLimitSize weight:(QMUIFontWeight)weight italic:(BOOL)italic;
        [Static]
        [Export("qmui_dynamicSystemFontOfSize:upperLimitSize:lowerLimitSize:weight:italic:")]
        UIFont Qmui_dynamicSystemFontOfSize(nfloat pointSize, nfloat upperLimitSize, nfloat lowerLimitSize, QMUIFontWeight weight, bool italic);
    }

    // @interface QMUI (UIGestureRecognizer)
    [Category]
    [BaseType(typeof(UIGestureRecognizer))]
    interface UIGestureRecognizer_QMUI
    {
        // @property (readonly, nonatomic, weak) UIView * _Nullable qmui_targetView;
        [NullAllowed, Export("qmui_targetView", ArgumentSemantic.Weak)]
        UIView Qmui_targetView { get; }
    }

    // @interface QMUI (UIImage)
    [Category]
    [BaseType(typeof(UIImage))]
    interface UIImage_QMUI
    {
        // +(UIImage * _Nullable)qmui_imageWithSize:(CGSize)size opaque:(BOOL)opaque scale:(CGFloat)scale actions:(void (^ _Nonnull)(CGContextRef _Nonnull))actionBlock;
        [Static]
        [Export("qmui_imageWithSize:opaque:scale:actions:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithSize(CGSize size, bool opaque, nfloat scale, Action<CoreGraphics.CGContextRef> actionBlock);

        // @property (readonly, assign, nonatomic) BOOL qmui_resizable;
        [Export("qmui_resizable")]
        bool Qmui_resizable { get; }

        // @property (readonly, assign, nonatomic) CGSize qmui_sizeInPixel;
        [Export("qmui_sizeInPixel", ArgumentSemantic.Assign)]
        CGSize Qmui_sizeInPixel { get; }

        // -(BOOL)qmui_opaque;
        [Export("qmui_opaque")]
        [Verify(MethodToProperty)]
        bool Qmui_opaque { get; }

        // -(UIColor * _Nonnull)qmui_averageColor;
        [Export("qmui_averageColor")]
        [Verify(MethodToProperty)]
        UIColor Qmui_averageColor { get; }

        // -(UIImage * _Nullable)qmui_grayImage;
        [NullAllowed, Export("qmui_grayImage")]
        [Verify(MethodToProperty)]
        UIImage Qmui_grayImage { get; }

        // -(UIImage * _Nullable)qmui_imageWithAlpha:(CGFloat)alpha;
        [Export("qmui_imageWithAlpha:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithAlpha(nfloat alpha);

        // -(UIImage * _Nullable)qmui_imageWithTintColor:(UIColor * _Nullable)tintColor;
        [Export("qmui_imageWithTintColor:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithTintColor([NullAllowed] UIColor tintColor);

        // -(UIImage * _Nullable)qmui_imageWithBlendColor:(UIColor * _Nullable)blendColor;
        [Export("qmui_imageWithBlendColor:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithBlendColor([NullAllowed] UIColor blendColor);

        // -(UIImage * _Nullable)qmui_imageWithImageAbove:(UIImage * _Nonnull)image atPoint:(CGPoint)point;
        [Export("qmui_imageWithImageAbove:atPoint:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithImageAbove(UIImage image, CGPoint point);

        // -(UIImage * _Nullable)qmui_imageWithSpacingExtensionInsets:(UIEdgeInsets)extension;
        [Export("qmui_imageWithSpacingExtensionInsets:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithSpacingExtensionInsets(UIEdgeInsets extension);

        // -(UIImage * _Nullable)qmui_imageWithClippedRect:(CGRect)rect;
        [Export("qmui_imageWithClippedRect:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithClippedRect(CGRect rect);

        // -(UIImage * _Nullable)qmui_imageWithClippedCornerRadius:(CGFloat)cornerRadius;
        [Export("qmui_imageWithClippedCornerRadius:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithClippedCornerRadius(nfloat cornerRadius);

        // -(UIImage * _Nullable)qmui_imageWithClippedCornerRadius:(CGFloat)cornerRadius scale:(CGFloat)scale;
        [Export("qmui_imageWithClippedCornerRadius:scale:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithClippedCornerRadius(nfloat cornerRadius, nfloat scale);

        // -(UIImage * _Nullable)qmui_imageResizedInLimitedSize:(CGSize)size;
        [Export("qmui_imageResizedInLimitedSize:")]
        [return: NullAllowed]
        UIImage Qmui_imageResizedInLimitedSize(CGSize size);

        // -(UIImage * _Nullable)qmui_imageResizedInLimitedSize:(CGSize)size resizingMode:(QMUIImageResizingMode)resizingMode;
        [Export("qmui_imageResizedInLimitedSize:resizingMode:")]
        [return: NullAllowed]
        UIImage Qmui_imageResizedInLimitedSize(CGSize size, QMUIImageResizingMode resizingMode);

        // -(UIImage * _Nullable)qmui_imageResizedInLimitedSize:(CGSize)size resizingMode:(QMUIImageResizingMode)resizingMode scale:(CGFloat)scale;
        [Export("qmui_imageResizedInLimitedSize:resizingMode:scale:")]
        [return: NullAllowed]
        UIImage Qmui_imageResizedInLimitedSize(CGSize size, QMUIImageResizingMode resizingMode, nfloat scale);

        // -(UIImage * _Nullable)qmui_imageWithOrientation:(UIImageOrientation)direction;
        [Export("qmui_imageWithOrientation:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithOrientation(UIImageOrientation direction);

        // -(UIImage * _Nullable)qmui_imageWithBorderColor:(UIColor * _Nullable)borderColor path:(UIBezierPath * _Nullable)path;
        [Export("qmui_imageWithBorderColor:path:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithBorderColor([NullAllowed] UIColor borderColor, [NullAllowed] UIBezierPath path);

        // -(UIImage * _Nullable)qmui_imageWithBorderColor:(UIColor * _Nullable)borderColor borderWidth:(CGFloat)borderWidth cornerRadius:(CGFloat)cornerRadius dashedLengths:(const CGFloat * _Nullable)dashedLengths;
        [Export("qmui_imageWithBorderColor:borderWidth:cornerRadius:dashedLengths:")]
        [return: NullAllowed]
        unsafe UIImage Qmui_imageWithBorderColor([NullAllowed] UIColor borderColor, nfloat borderWidth, nfloat cornerRadius, [NullAllowed] nfloat* dashedLengths);

        // -(UIImage * _Nullable)qmui_imageWithBorderColor:(UIColor * _Nullable)borderColor borderWidth:(CGFloat)borderWidth cornerRadius:(CGFloat)cornerRadius;
        [Export("qmui_imageWithBorderColor:borderWidth:cornerRadius:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithBorderColor([NullAllowed] UIColor borderColor, nfloat borderWidth, nfloat cornerRadius);

        // -(UIImage * _Nullable)qmui_imageWithBorderColor:(UIColor * _Nullable)borderColor borderWidth:(CGFloat)borderWidth borderPosition:(QMUIImageBorderPosition)borderPosition;
        [Export("qmui_imageWithBorderColor:borderWidth:borderPosition:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithBorderColor([NullAllowed] UIColor borderColor, nfloat borderWidth, QMUIImageBorderPosition borderPosition);

        // -(UIImage * _Nullable)qmui_imageWithMaskImage:(UIImage * _Nonnull)maskImage usingMaskImageMode:(BOOL)usingMaskImageMode;
        [Export("qmui_imageWithMaskImage:usingMaskImageMode:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithMaskImage(UIImage maskImage, bool usingMaskImageMode);

        // +(UIImage * _Nullable)qmui_animatedImageWithData:(NSData * _Nonnull)data;
        [Static]
        [Export("qmui_animatedImageWithData:")]
        [return: NullAllowed]
        UIImage Qmui_animatedImageWithData(NSData data);

        // +(UIImage * _Nullable)qmui_animatedImageWithData:(NSData * _Nonnull)data scale:(CGFloat)scale;
        [Static]
        [Export("qmui_animatedImageWithData:scale:")]
        [return: NullAllowed]
        UIImage Qmui_animatedImageWithData(NSData data, nfloat scale);

        // +(UIImage * _Nullable)qmui_animatedImageNamed:(NSString * _Nonnull)name;
        [Static]
        [Export("qmui_animatedImageNamed:")]
        [return: NullAllowed]
        UIImage Qmui_animatedImageNamed(string name);

        // +(UIImage * _Nullable)qmui_animatedImageNamed:(NSString * _Nonnull)name scale:(CGFloat)scale;
        [Static]
        [Export("qmui_animatedImageNamed:scale:")]
        [return: NullAllowed]
        UIImage Qmui_animatedImageNamed(string name, nfloat scale);

        // +(UIImage * _Nullable)qmui_imageWithColor:(UIColor * _Nullable)color;
        [Static]
        [Export("qmui_imageWithColor:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithColor([NullAllowed] UIColor color);

        // +(UIImage * _Nullable)qmui_imageWithColor:(UIColor * _Nullable)color size:(CGSize)size cornerRadius:(CGFloat)cornerRadius;
        [Static]
        [Export("qmui_imageWithColor:size:cornerRadius:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithColor([NullAllowed] UIColor color, CGSize size, nfloat cornerRadius);

        // +(UIImage * _Nullable)qmui_imageWithColor:(UIColor * _Nullable)color size:(CGSize)size cornerRadiusArray:(NSArray<NSNumber *> * _Nullable)cornerRadius;
        [Static]
        [Export("qmui_imageWithColor:size:cornerRadiusArray:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithColor([NullAllowed] UIColor color, CGSize size, [NullAllowed] NSNumber[] cornerRadius);

        // +(UIImage * _Nullable)qmui_imageWithStrokeColor:(UIColor * _Nullable)strokeColor size:(CGSize)size path:(UIBezierPath * _Nullable)path addClip:(BOOL)addClip;
        [Static]
        [Export("qmui_imageWithStrokeColor:size:path:addClip:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithStrokeColor([NullAllowed] UIColor strokeColor, CGSize size, [NullAllowed] UIBezierPath path, bool addClip);

        // +(UIImage * _Nullable)qmui_imageWithStrokeColor:(UIColor * _Nullable)strokeColor size:(CGSize)size lineWidth:(CGFloat)lineWidth cornerRadius:(CGFloat)cornerRadius;
        [Static]
        [Export("qmui_imageWithStrokeColor:size:lineWidth:cornerRadius:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithStrokeColor([NullAllowed] UIColor strokeColor, CGSize size, nfloat lineWidth, nfloat cornerRadius);

        // +(UIImage * _Nullable)qmui_imageWithStrokeColor:(UIColor * _Nullable)strokeColor size:(CGSize)size lineWidth:(CGFloat)lineWidth borderPosition:(QMUIImageBorderPosition)borderPosition;
        [Static]
        [Export("qmui_imageWithStrokeColor:size:lineWidth:borderPosition:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithStrokeColor([NullAllowed] UIColor strokeColor, CGSize size, nfloat lineWidth, QMUIImageBorderPosition borderPosition);

        // +(UIImage * _Nullable)qmui_imageWithShape:(QMUIImageShape)shape size:(CGSize)size tintColor:(UIColor * _Nullable)tintColor;
        [Static]
        [Export("qmui_imageWithShape:size:tintColor:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithShape(QMUIImageShape shape, CGSize size, [NullAllowed] UIColor tintColor);

        // +(UIImage * _Nullable)qmui_imageWithShape:(QMUIImageShape)shape size:(CGSize)size lineWidth:(CGFloat)lineWidth tintColor:(UIColor * _Nullable)tintColor;
        [Static]
        [Export("qmui_imageWithShape:size:lineWidth:tintColor:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithShape(QMUIImageShape shape, CGSize size, nfloat lineWidth, [NullAllowed] UIColor tintColor);

        // +(UIImage * _Nullable)qmui_imageWithAttributedString:(NSAttributedString * _Nonnull)attributedString;
        [Static]
        [Export("qmui_imageWithAttributedString:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithAttributedString(NSAttributedString attributedString);

        // +(UIImage * _Nullable)qmui_imageWithView:(UIView * _Nonnull)view;
        [Static]
        [Export("qmui_imageWithView:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithView(UIView view);

        // +(UIImage * _Nullable)qmui_imageWithView:(UIView * _Nonnull)view afterScreenUpdates:(BOOL)afterUpdates;
        [Static]
        [Export("qmui_imageWithView:afterScreenUpdates:")]
        [return: NullAllowed]
        UIImage Qmui_imageWithView(UIView view, bool afterUpdates);
    }

    // @interface QMUI (UIImageView)
    [Category]
    [BaseType(typeof(UIImageView))]
    interface UIImageView_QMUI
    {
        // @property (assign, nonatomic) BOOL qmui_pause;
        [Export("qmui_pause")]
        bool Qmui_pause { get; set; }

        // @property (assign, nonatomic) BOOL qmui_smoothAnimation;
        [Export("qmui_smoothAnimation")]
        bool Qmui_smoothAnimation { get; set; }

        // -(void)qmui_sizeToFitKeepingImageAspectRatioInSize:(CGSize)limitSize;
        [Export("qmui_sizeToFitKeepingImageAspectRatioInSize:")]
        void Qmui_sizeToFitKeepingImageAspectRatioInSize(CGSize limitSize);
    }

    // @interface QMUI_Interface (QMUIHelper)
    [Category]
    [BaseType(typeof(QMUIHelper))]
    interface QMUIHelper_QMUI_Interface
    {
        // +(BOOL)rotateToDeviceOrientation:(UIDeviceOrientation)orientation;
        [Static]
        [Export("rotateToDeviceOrientation:")]
        bool RotateToDeviceOrientation(UIDeviceOrientation orientation);

        // @property (assign, nonatomic) UIDeviceOrientation orientationBeforeChangingByHelper;
        [Export("orientationBeforeChangingByHelper", ArgumentSemantic.Assign)]
        UIDeviceOrientation OrientationBeforeChangingByHelper { get; set; }

        // +(UIDeviceOrientation)deviceOrientationWithInterfaceOrientationMask:(UIInterfaceOrientationMask)mask;
        [Static]
        [Export("deviceOrientationWithInterfaceOrientationMask:")]
        UIDeviceOrientation DeviceOrientationWithInterfaceOrientationMask(UIInterfaceOrientationMask mask);

        // +(BOOL)interfaceOrientationMask:(UIInterfaceOrientationMask)mask containsDeviceOrientation:(UIDeviceOrientation)deviceOrientation;
        [Static]
        [Export("interfaceOrientationMask:containsDeviceOrientation:")]
        bool InterfaceOrientationMask(UIInterfaceOrientationMask mask, UIDeviceOrientation deviceOrientation);

        // +(BOOL)interfaceOrientationMask:(UIInterfaceOrientationMask)mask containsInterfaceOrientation:(UIInterfaceOrientation)interfaceOrientation;
        [Static]
        [Export("interfaceOrientationMask:containsInterfaceOrientation:")]
        bool InterfaceOrientationMask(UIInterfaceOrientationMask mask, UIInterfaceOrientation interfaceOrientation);

        // +(CGFloat)angleForTransformWithInterfaceOrientation:(UIInterfaceOrientation)orientation;
        [Static]
        [Export("angleForTransformWithInterfaceOrientation:")]
        nfloat AngleForTransformWithInterfaceOrientation(UIInterfaceOrientation orientation);

        // +(CGAffineTransform)transformForCurrentInterfaceOrientation;
        [Static]
        [Export("transformForCurrentInterfaceOrientation")]
        [Verify(MethodToProperty)]
        CGAffineTransform TransformForCurrentInterfaceOrientation { get; }

        // +(CGAffineTransform)transformWithInterfaceOrientation:(UIInterfaceOrientation)orientation;
        [Static]
        [Export("transformWithInterfaceOrientation:")]
        CGAffineTransform TransformWithInterfaceOrientation(UIInterfaceOrientation orientation);

        // -(void)handleDeviceOrientationNotification:(NSNotification * _Nonnull)notification;
        [Export("handleDeviceOrientationNotification:")]
        void HandleDeviceOrientationNotification(NSNotification notification);
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const CGFloat QMUILineHeightIdentity;
        [Field("QMUILineHeightIdentity", "__Internal")]
        nfloat QMUILineHeightIdentity { get; }
    }

    // @interface QMUI (UILabel)
    [Category]
    [BaseType(typeof(UILabel))]
    interface UILabel_QMUI
    {
        // -(instancetype _Nonnull)qmui_initWithFont:(UIFont * _Nullable)font textColor:(UIColor * _Nullable)textColor;
        [Export("qmui_initWithFont:textColor:")]
        UILabel Qmui_initWithFont([NullAllowed] UIFont font, [NullAllowed] UIColor textColor);

        // @property (copy, nonatomic) NSDictionary<NSAttributedStringKey,id> * _Nullable qmui_textAttributes;
        [NullAllowed, Export("qmui_textAttributes", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> Qmui_textAttributes { get; set; }

        // @property (assign, nonatomic) CGFloat qmui_lineHeight;
        [Export("qmui_lineHeight")]
        nfloat Qmui_lineHeight { get; set; }

        // -(void)qmui_setTheSameAppearanceAsLabel:(UILabel * _Nonnull)label;
        [Export("qmui_setTheSameAppearanceAsLabel:")]
        void Qmui_setTheSameAppearanceAsLabel(UILabel label);

        // -(void)qmui_calculateHeightAfterSetAppearance;
        [Export("qmui_calculateHeightAfterSetAppearance")]
        void Qmui_calculateHeightAfterSetAppearance();

        // -(void)qmui_avoidBlendedLayersIfShowingChineseWithBackgroundColor:(UIColor * _Nonnull)color;
        [Export("qmui_avoidBlendedLayersIfShowingChineseWithBackgroundColor:")]
        void Qmui_avoidBlendedLayersIfShowingChineseWithBackgroundColor(UIColor color);
    }

    // @interface QMUI (UIMenuController)
    [Category]
    [BaseType(typeof(UIMenuController))]
    interface UIMenuController_QMUI
    {
    }

    // @interface QMUI (UINavigationBar)
    [Category]
    [BaseType(typeof(UINavigationBar))]
    interface UINavigationBar_QMUI
    {
        // @property (readonly, nonatomic, strong) UIView * _Nullable qmui_contentView __attribute__((availability(ios, introduced=11.0)));
        [iOS(11, 0)]
        [NullAllowed, Export("qmui_contentView", ArgumentSemantic.Strong)]
        UIView Qmui_contentView { get; }

        // @property (readonly, nonatomic, strong) UIView * _Nullable qmui_backgroundView;
        [NullAllowed, Export("qmui_backgroundView", ArgumentSemantic.Strong)]
        UIView Qmui_backgroundView { get; }

        // @property (readonly, nonatomic, strong) __kindof UIView * _Nullable qmui_backgroundContentView;
        [Export("qmui_backgroundContentView", ArgumentSemantic.Strong)]
        UIView Qmui_backgroundContentView { get; }

        // @property (readonly, nonatomic, strong) UIImageView * _Nullable qmui_shadowImageView;
        [NullAllowed, Export("qmui_shadowImageView", ArgumentSemantic.Strong)]
        UIImageView Qmui_shadowImageView { get; }
    }

    // @interface Transition (UINavigationBar)
    [Category]
    [BaseType(typeof(UINavigationBar))]
    interface UINavigationBar_Transition
    {
        // @property (nonatomic, strong) UINavigationBar * transitionNavigationBar;
        [Export("transitionNavigationBar", ArgumentSemantic.Strong)]
        UINavigationBar TransitionNavigationBar { get; set; }
    }

    // @interface NavigationBarTransition (UINavigationController)
    [Category]
    [BaseType(typeof(UINavigationController))]
    interface UINavigationController_NavigationBarTransition
    {
    }

    // typedef void (^QMUINavigationActionDidChangeBlock)(QMUINavigationAction, BOOL, __kindof UINavigationController * _Nullable, __kindof UIViewController * _Nullable, NSArray<__kindof UIViewController *> * _Nullable);
    delegate void QMUINavigationActionDidChangeBlock(QMUINavigationAction arg0, bool arg1, UINavigationController arg2, UIViewController arg3, [NullAllowed] UIViewController[] arg4);

    // @interface QMUI (UINavigationController) <UIGestureRecognizerDelegate>
    [Category]
    [BaseType(typeof(UINavigationController))]
    interface UINavigationController_QMUI : IUIGestureRecognizerDelegate
    {
        // -(void)qmui_didInitialize __attribute__((objc_requires_super));
        [Export("qmui_didInitialize")]
        [RequiresSuper]
        void Qmui_didInitialize();

        // @property (readonly, assign, nonatomic) QMUINavigationAction qmui_navigationAction;
        [Export("qmui_navigationAction", ArgumentSemantic.Assign)]
        QMUINavigationAction Qmui_navigationAction { get; }

        // -(void)qmui_addNavigationActionDidChangeBlock:(QMUINavigationActionDidChangeBlock _Nonnull)block;
        [Export("qmui_addNavigationActionDidChangeBlock:")]
        void Qmui_addNavigationActionDidChangeBlock(QMUINavigationActionDidChangeBlock block);

        // @property (readonly, nonatomic) BOOL qmui_isPushing;
        [Export("qmui_isPushing")]
        bool Qmui_isPushing { get; }

        // @property (readonly, nonatomic) BOOL qmui_isPopping;
        [Export("qmui_isPopping")]
        bool Qmui_isPopping { get; }

        // @property (readonly, nonatomic) UIViewController * _Nullable qmui_topViewController;
        [NullAllowed, Export("qmui_topViewController")]
        UIViewController Qmui_topViewController { get; }

        // @property (readonly, nonatomic) UIViewController * _Nullable qmui_rootViewController;
        [NullAllowed, Export("qmui_rootViewController")]
        UIViewController Qmui_rootViewController { get; }

        [Wrap("WeakQmui_interactivePopGestureRecognizerDelegate")]
        [NullAllowed]
        UIGestureRecognizerDelegate Qmui_interactivePopGestureRecognizerDelegate { get; }

        // @property (readonly, nonatomic, weak) id<UIGestureRecognizerDelegate> _Nullable qmui_interactivePopGestureRecognizerDelegate;
        [NullAllowed, Export("qmui_interactivePopGestureRecognizerDelegate", ArgumentSemantic.Weak)]
        NSObject WeakQmui_interactivePopGestureRecognizerDelegate { get; }

        // -(void)qmui_pushViewController:(UIViewController * _Nonnull)viewController animated:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
        [Export("qmui_pushViewController:animated:completion:")]
        void Qmui_pushViewController(UIViewController viewController, bool animated, [NullAllowed] Action completion);

        // -(UIViewController * _Nonnull)qmui_popViewControllerAnimated:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
        [Export("qmui_popViewControllerAnimated:completion:")]
        UIViewController Qmui_popViewControllerAnimated(bool animated, [NullAllowed] Action completion);

        // -(NSArray<UIViewController *> * _Nonnull)qmui_popToViewController:(UIViewController * _Nonnull)viewController animated:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
        [Export("qmui_popToViewController:animated:completion:")]
        UIViewController[] Qmui_popToViewController(UIViewController viewController, bool animated, [NullAllowed] Action completion);

        // -(NSArray<UIViewController *> * _Nonnull)qmui_popToRootViewControllerAnimated:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
        [Export("qmui_popToRootViewControllerAnimated:completion:")]
        UIViewController[] Qmui_popToRootViewControllerAnimated(bool animated, [NullAllowed] Action completion);
    }

    // @protocol UINavigationControllerBackButtonHandlerProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UINavigationControllerBackButtonHandlerProtocol
    {
        // @optional -(BOOL)shouldPopViewControllerByBackButtonOrPopGesture:(BOOL)byPopGesture;
        [Export("shouldPopViewControllerByBackButtonOrPopGesture:")]
        bool ShouldPopViewControllerByBackButtonOrPopGesture(bool byPopGesture);

        // @optional -(BOOL)forceEnableInteractivePopGestureRecognizer;
        [Export("forceEnableInteractivePopGestureRecognizer")]
        [Verify(MethodToProperty)]
        bool ForceEnableInteractivePopGestureRecognizer { get; }
    }

    // @interface BackBarButtonSupport (UIViewController) <UINavigationControllerBackButtonHandlerProtocol>
    [Category]
    [BaseType(typeof(UIViewController))]
    interface UIViewController_BackBarButtonSupport : IUINavigationControllerBackButtonHandlerProtocol
    {
    }

    // @interface QMUI (UINavigationItem)
    [Category]
    [BaseType(typeof(UINavigationItem))]
    interface UINavigationItem_QMUI
    {
        // @property (readonly, nonatomic, weak) UINavigationBar * _Nullable qmui_navigationBar;
        [NullAllowed, Export("qmui_navigationBar", ArgumentSemantic.Weak)]
        UINavigationBar Qmui_navigationBar { get; }

        // @property (readonly, nonatomic, weak) UINavigationController * _Nullable qmui_navigationController;
        [NullAllowed, Export("qmui_navigationController", ArgumentSemantic.Weak)]
        UINavigationController Qmui_navigationController { get; }

        // @property (readonly, nonatomic, weak) UIViewController * _Nullable qmui_viewController;
        [NullAllowed, Export("qmui_viewController", ArgumentSemantic.Weak)]
        UIViewController Qmui_viewController { get; }

        // @property (readonly, nonatomic, weak) UINavigationItem * _Nullable qmui_previousItem;
        [NullAllowed, Export("qmui_previousItem", ArgumentSemantic.Weak)]
        UINavigationItem Qmui_previousItem { get; }

        // @property (readonly, nonatomic, weak) UINavigationItem * _Nullable qmui_nextItem;
        [NullAllowed, Export("qmui_nextItem", ArgumentSemantic.Weak)]
        UINavigationItem Qmui_nextItem { get; }
    }

    // @interface QMUI (UIScrollView)
    [Category]
    [BaseType(typeof(UIScrollView))]
    interface UIScrollView_QMUI
    {
        // @property (readonly, assign, nonatomic) BOOL qmui_alreadyAtTop;
        [Export("qmui_alreadyAtTop")]
        bool Qmui_alreadyAtTop { get; }

        // @property (readonly, assign, nonatomic) BOOL qmui_alreadyAtBottom;
        [Export("qmui_alreadyAtBottom")]
        bool Qmui_alreadyAtBottom { get; }

        // @property (readonly, assign, nonatomic) UIEdgeInsets qmui_contentInset;
        [Export("qmui_contentInset", ArgumentSemantic.Assign)]
        UIEdgeInsets Qmui_contentInset { get; }

        // @property (assign, nonatomic) UIEdgeInsets qmui_initialContentInset;
        [Export("qmui_initialContentInset", ArgumentSemantic.Assign)]
        UIEdgeInsets Qmui_initialContentInset { get; set; }

        // -(BOOL)qmui_canScroll;
        [Export("qmui_canScroll")]
        [Verify(MethodToProperty)]
        bool Qmui_canScroll { get; }

        // -(void)qmui_scrollToTopForce:(BOOL)force animated:(BOOL)animated;
        [Export("qmui_scrollToTopForce:animated:")]
        void Qmui_scrollToTopForce(bool force, bool animated);

        // -(void)qmui_scrollToTopAnimated:(BOOL)animated;
        [Export("qmui_scrollToTopAnimated:")]
        void Qmui_scrollToTopAnimated(bool animated);

        // -(void)qmui_scrollToTop;
        [Export("qmui_scrollToTop")]
        void Qmui_scrollToTop();

        // -(void)qmui_scrollToTopUponContentInsetTopChange;
        [Export("qmui_scrollToTopUponContentInsetTopChange")]
        void Qmui_scrollToTopUponContentInsetTopChange();

        // -(void)qmui_scrollToBottomAnimated:(BOOL)animated;
        [Export("qmui_scrollToBottomAnimated:")]
        void Qmui_scrollToBottomAnimated(bool animated);

        // -(void)qmui_scrollToBottom;
        [Export("qmui_scrollToBottom")]
        void Qmui_scrollToBottom();

        // -(void)qmui_stopDeceleratingIfNeeded;
        [Export("qmui_stopDeceleratingIfNeeded")]
        void Qmui_stopDeceleratingIfNeeded();

        // -(void)qmui_setContentInset:(UIEdgeInsets)contentInset animated:(BOOL)animated;
        [Export("qmui_setContentInset:animated:")]
        void Qmui_setContentInset(UIEdgeInsets contentInset, bool animated);
    }

    // @interface QMUI (UISearchBar)
    [Category]
    [BaseType(typeof(UISearchBar))]
    interface UISearchBar_QMUI
    {
        // @property (assign, nonatomic) BOOL qmui_usedAsTableHeaderView;
        [Export("qmui_usedAsTableHeaderView")]
        bool Qmui_usedAsTableHeaderView { get; set; }

        // @property (assign, nonatomic) BOOL qmui_centerPlaceholder __attribute__((availability(ios, introduced=11.0))) __attribute__((annotate("ui_appearance_selector")));
        [iOS(11, 0)]
        [Export("qmui_centerPlaceholder")]
        bool Qmui_centerPlaceholder { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable qmui_placeholderColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("qmui_placeholderColor", ArgumentSemantic.Strong)]
        UIColor Qmui_placeholderColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable qmui_textColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("qmui_textColor", ArgumentSemantic.Strong)]
        UIColor Qmui_textColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable qmui_font __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("qmui_font", ArgumentSemantic.Strong)]
        UIFont Qmui_font { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets qmui_textFieldMargins __attribute__((annotate("ui_appearance_selector")));
        [Export("qmui_textFieldMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets Qmui_textFieldMargins { get; set; }

        // @property (copy, nonatomic) UIEdgeInsets (^ _Nonnull)(__kindof UISearchBar * _Nonnull, BOOL) qmui_textFieldMarginsBlock;
        [Export("qmui_textFieldMarginsBlock", ArgumentSemantic.Copy)]
        Func<UISearchBar, bool, UIEdgeInsets> Qmui_textFieldMarginsBlock { get; set; }

        // @property (readonly, nonatomic, weak) UITextField * _Nullable qmui_textField;
        [NullAllowed, Export("qmui_textField", ArgumentSemantic.Weak)]
        UITextField Qmui_textField { get; }

        // @property (readonly, nonatomic, weak) UIView * _Nullable qmui_backgroundView;
        [NullAllowed, Export("qmui_backgroundView", ArgumentSemantic.Weak)]
        UIView Qmui_backgroundView { get; }

        // @property (readonly, nonatomic, weak) UIButton * _Nullable qmui_cancelButton;
        [NullAllowed, Export("qmui_cancelButton", ArgumentSemantic.Weak)]
        UIButton Qmui_cancelButton { get; }

        // @property (nonatomic, strong) UIFont * _Nullable qmui_cancelButtonFont __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("qmui_cancelButtonFont", ArgumentSemantic.Strong)]
        UIFont Qmui_cancelButtonFont { get; set; }

        // @property (copy, nonatomic) UIEdgeInsets (^ _Nonnull)(__kindof UISearchBar * _Nonnull, BOOL) qmui_cancelButtonMarginsBlock;
        [Export("qmui_cancelButtonMarginsBlock", ArgumentSemantic.Copy)]
        Func<UISearchBar, bool, UIEdgeInsets> Qmui_cancelButtonMarginsBlock { get; set; }

        // @property (readonly, nonatomic, weak) UISegmentedControl * _Nullable qmui_segmentedControl;
        [NullAllowed, Export("qmui_segmentedControl", ArgumentSemantic.Weak)]
        UISegmentedControl Qmui_segmentedControl { get; }

        // @property (assign, nonatomic) BOOL qmui_showsLeftAccessoryView;
        [Export("qmui_showsLeftAccessoryView")]
        bool Qmui_showsLeftAccessoryView { get; set; }

        // -(void)qmui_setShowsLeftAccessoryView:(BOOL)showsLeftAccessoryView animated:(BOOL)animated;
        [Export("qmui_setShowsLeftAccessoryView:animated:")]
        void Qmui_setShowsLeftAccessoryView(bool showsLeftAccessoryView, bool animated);

        // @property (nonatomic, strong) UIView * _Nonnull qmui_leftAccessoryView;
        [Export("qmui_leftAccessoryView", ArgumentSemantic.Strong)]
        UIView Qmui_leftAccessoryView { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets qmui_leftAccessoryViewMargins __attribute__((annotate("ui_appearance_selector")));
        [Export("qmui_leftAccessoryViewMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets Qmui_leftAccessoryViewMargins { get; set; }

        // @property (assign, nonatomic) BOOL qmui_showsRightAccessoryView;
        [Export("qmui_showsRightAccessoryView")]
        bool Qmui_showsRightAccessoryView { get; set; }

        // -(void)qmui_setShowsRightAccessoryView:(BOOL)showsRightAccessoryView animated:(BOOL)animated;
        [Export("qmui_setShowsRightAccessoryView:animated:")]
        void Qmui_setShowsRightAccessoryView(bool showsRightAccessoryView, bool animated);

        // @property (nonatomic, strong) UIView * _Nonnull qmui_rightAccessoryView;
        [Export("qmui_rightAccessoryView", ArgumentSemantic.Strong)]
        UIView Qmui_rightAccessoryView { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets qmui_rightAccessoryViewMargins __attribute__((annotate("ui_appearance_selector")));
        [Export("qmui_rightAccessoryViewMargins", ArgumentSemantic.Assign)]
        UIEdgeInsets Qmui_rightAccessoryViewMargins { get; set; }

        // @property (assign, nonatomic) BOOL qmui_fixMaskViewLayoutBugAutomatically;
        [Export("qmui_fixMaskViewLayoutBugAutomatically")]
        bool Qmui_fixMaskViewLayoutBugAutomatically { get; set; }

        // -(void)qmui_styledAsQMUISearchBar;
        [Export("qmui_styledAsQMUISearchBar")]
        void Qmui_styledAsQMUISearchBar();

        // +(UIImage * _Nullable)qmui_generateTextFieldBackgroundImageWithColor:(UIColor * _Nullable)color;
        [Static]
        [Export("qmui_generateTextFieldBackgroundImageWithColor:")]
        [return: NullAllowed]
        UIImage Qmui_generateTextFieldBackgroundImageWithColor([NullAllowed] UIColor color);

        // +(UIImage * _Nullable)qmui_generateBackgroundImageWithColor:(UIColor * _Nullable)backgroundColor borderColor:(UIColor * _Nullable)borderColor;
        [Static]
        [Export("qmui_generateBackgroundImageWithColor:borderColor:")]
        [return: NullAllowed]
        UIImage Qmui_generateBackgroundImageWithColor([NullAllowed] UIColor backgroundColor, [NullAllowed] UIColor borderColor);
    }

    // @interface QMUI (UISearchController)
    [Category]
    [BaseType(typeof(UISearchController))]
    interface UISearchController_QMUI
    {
    }

    // @interface QMUI (UISwitch)
    [Category]
    [BaseType(typeof(UISwitch))]
    interface UISwitch_QMUI
    {
        // @property (nonatomic, strong) UIColor * _Nonnull qmui_offTintColor;
        [Export("qmui_offTintColor", ArgumentSemantic.Strong)]
        UIColor Qmui_offTintColor { get; set; }
    }

    // @interface QMUI (UITabBar)
    [Category]
    [BaseType(typeof(UITabBar))]
    interface UITabBar_QMUI
    {
        // @property (readonly, nonatomic, strong) UIView * _Nonnull qmui_backgroundView;
        [Export("qmui_backgroundView", ArgumentSemantic.Strong)]
        UIView Qmui_backgroundView { get; }

        // @property (readonly, nonatomic, strong) UIImageView * _Nonnull qmui_shadowImageView;
        [Export("qmui_shadowImageView", ArgumentSemantic.Strong)]
        UIImageView Qmui_shadowImageView { get; }
    }

    // @interface QMUI (UITabBarAppearance)
    [TV(13, 0), iOS(13, 0)]
    [Category]
    [BaseType(typeof(UITabBarAppearance))]
    interface UITabBarAppearance_QMUI
    {
        // -(void)qmui_applyItemAppearanceWithBlock:(void (^ _Nonnull)(UITabBarItemAppearance * _Nonnull))block;
        [Export("qmui_applyItemAppearanceWithBlock:")]
        void Qmui_applyItemAppearanceWithBlock(Action<UITabBarItemAppearance> block);
    }

    // @interface QMUI (UITabBarItem)
    [Category]
    [BaseType(typeof(UITabBarItem))]
    interface UITabBarItem_QMUI
    {
        // @property (copy, nonatomic) void (^ _Nullable)(UITabBarItem * _Nonnull, NSInteger) qmui_doubleTapBlock;
        [NullAllowed, Export("qmui_doubleTapBlock", ArgumentSemantic.Copy)]
        Action<UITabBarItem, nint> Qmui_doubleTapBlock { get; set; }

        // -(UIImageView * _Nullable)qmui_imageView;
        [NullAllowed, Export("qmui_imageView")]
        [Verify(MethodToProperty)]
        UIImageView Qmui_imageView { get; }

        // +(UIImageView * _Nullable)qmui_imageViewInTabBarButton:(UIView * _Nullable)tabBarButton;
        [Static]
        [Export("qmui_imageViewInTabBarButton:")]
        [return: NullAllowed]
        UIImageView Qmui_imageViewInTabBarButton([NullAllowed] UIView tabBarButton);
    }

    // @interface QMUICellHeightKeyCache (UITableView)
    [Category]
    [BaseType(typeof(UITableView))]
    interface UITableView_QMUICellHeightKeyCache
    {
        // @property (assign, nonatomic) BOOL qmui_cacheCellHeightByKeyAutomatically;
        [Export("qmui_cacheCellHeightByKeyAutomatically")]
        bool Qmui_cacheCellHeightByKeyAutomatically { get; set; }

        // @property (readonly, nonatomic, weak) QMUICellHeightKeyCache * _Nullable qmui_currentCellHeightKeyCache;
        [NullAllowed, Export("qmui_currentCellHeightKeyCache", ArgumentSemantic.Weak)]
        QMUICellHeightKeyCache Qmui_currentCellHeightKeyCache { get; }

        // -(void)qmui_invalidateCellHeightCachedForKey:(id<NSCopying> _Nonnull)key;
        [Export("qmui_invalidateCellHeightCachedForKey:")]
        void Qmui_invalidateCellHeightCachedForKey(NSCopying key);

        // -(void)qmui_invalidateAllCellHeightKeyCache;
        [Export("qmui_invalidateAllCellHeightKeyCache")]
        void Qmui_invalidateAllCellHeightKeyCache();
    }

    // @interface QMUI_StaticCell (UITableView)
    [Category]
    [BaseType(typeof(UITableView))]
    interface UITableView_QMUI_StaticCell
    {
        // @property (nonatomic, strong) QMUIStaticTableViewCellDataSource * qmui_staticCellDataSource;
        [Export("qmui_staticCellDataSource", ArgumentSemantic.Strong)]
        QMUIStaticTableViewCellDataSource Qmui_staticCellDataSource { get; set; }
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const UIEdgeInsets QMUITableViewCellSeparatorInsetsNone;
        [Field("QMUITableViewCellSeparatorInsetsNone", "__Internal")]
        UIEdgeInsets QMUITableViewCellSeparatorInsetsNone { get; }
    }

    // @interface QMUI (UITableViewCell)
    [Category]
    [BaseType(typeof(UITableViewCell))]
    interface UITableViewCell_QMUI
    {
        // @property (readonly, nonatomic, weak) UITableView * _Nullable qmui_tableView;
        [NullAllowed, Export("qmui_tableView", ArgumentSemantic.Weak)]
        UITableView Qmui_tableView { get; }

        // @property (readonly, assign, nonatomic) UITableViewCellStyle qmui_style;
        [Export("qmui_style", ArgumentSemantic.Assign)]
        UITableViewCellStyle Qmui_style { get; }

        // @property (readonly, assign, nonatomic) QMUITableViewCellPosition qmui_cellPosition;
        [Export("qmui_cellPosition", ArgumentSemantic.Assign)]
        QMUITableViewCellPosition Qmui_cellPosition { get; }

        // @property (copy, nonatomic) UIEdgeInsets (^ _Nonnull)(__kindof UITableView * _Nonnull, __kindof UITableViewCell * _Nonnull) qmui_separatorInsetsBlock;
        [Export("qmui_separatorInsetsBlock", ArgumentSemantic.Copy)]
        Func<UITableView, UITableViewCell, UIEdgeInsets> Qmui_separatorInsetsBlock { get; set; }

        // @property (copy, nonatomic) UIEdgeInsets (^ _Nonnull)(__kindof UITableView * _Nonnull, __kindof UITableViewCell * _Nonnull) qmui_topSeparatorInsetsBlock;
        [Export("qmui_topSeparatorInsetsBlock", ArgumentSemantic.Copy)]
        Func<UITableView, UITableViewCell, UIEdgeInsets> Qmui_topSeparatorInsetsBlock { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable qmui_selectedBackgroundColor;
        [NullAllowed, Export("qmui_selectedBackgroundColor", ArgumentSemantic.Strong)]
        UIColor Qmui_selectedBackgroundColor { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(BOOL, BOOL) qmui_setHighlightedBlock;
        [NullAllowed, Export("qmui_setHighlightedBlock", ArgumentSemantic.Copy)]
        Action<bool, bool> Qmui_setHighlightedBlock { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(BOOL, BOOL) qmui_setSelectedBlock;
        [NullAllowed, Export("qmui_setSelectedBlock", ArgumentSemantic.Copy)]
        Action<bool, bool> Qmui_setSelectedBlock { get; set; }

        // @property (readonly, nonatomic, strong) __kindof UIView * _Nullable qmui_accessoryView;
        [Export("qmui_accessoryView", ArgumentSemantic.Strong)]
        UIView Qmui_accessoryView { get; }
    }

    // @interface QMUI_Styled (UITableViewCell)
    [Category]
    [BaseType(typeof(UITableViewCell))]
    interface UITableViewCell_QMUI_Styled
    {
        // -(void)qmui_styledAsQMUITableViewCell;
        [Export("qmui_styledAsQMUITableViewCell")]
        void Qmui_styledAsQMUITableViewCell();

        // @property (readonly, nonatomic, strong) UIColor * _Nullable qmui_styledTextLabelColor;
        [NullAllowed, Export("qmui_styledTextLabelColor", ArgumentSemantic.Strong)]
        UIColor Qmui_styledTextLabelColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nullable qmui_styledDetailTextLabelColor;
        [NullAllowed, Export("qmui_styledDetailTextLabelColor", ArgumentSemantic.Strong)]
        UIColor Qmui_styledDetailTextLabelColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nullable qmui_styledBackgroundColor;
        [NullAllowed, Export("qmui_styledBackgroundColor", ArgumentSemantic.Strong)]
        UIColor Qmui_styledBackgroundColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nullable qmui_styledSelectedBackgroundColor;
        [NullAllowed, Export("qmui_styledSelectedBackgroundColor", ArgumentSemantic.Strong)]
        UIColor Qmui_styledSelectedBackgroundColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nullable qmui_styledWarningBackgroundColor;
        [NullAllowed, Export("qmui_styledWarningBackgroundColor", ArgumentSemantic.Strong)]
        UIColor Qmui_styledWarningBackgroundColor { get; }
    }

    // @interface QMUI (UITableViewHeaderFooterView)
    [Category]
    [BaseType(typeof(UITableViewHeaderFooterView))]
    interface UITableViewHeaderFooterView_QMUI
    {
        // @property (readonly, nonatomic, weak) UITableView * _Nullable qmui_tableView;
        [NullAllowed, Export("qmui_tableView", ArgumentSemantic.Weak)]
        UITableView Qmui_tableView { get; }
    }

    // @interface QMUI_InsetGrouped (UITableViewHeaderFooterView)
    [Category]
    [BaseType(typeof(UITableViewHeaderFooterView))]
    interface UITableViewHeaderFooterView_QMUI_InsetGrouped
    {
    }

    // @interface QMUI (UITextField)
    [Category]
    [BaseType(typeof(UITextField))]
    interface UITextField_QMUI
    {
        // @property (readonly, assign, nonatomic) NSRange qmui_selectedRange;
        [Export("qmui_selectedRange", ArgumentSemantic.Assign)]
        NSRange Qmui_selectedRange { get; }

        // @property (readonly, nonatomic, weak) UIButton * _Nullable qmui_clearButton;
        [NullAllowed, Export("qmui_clearButton", ArgumentSemantic.Weak)]
        UIButton Qmui_clearButton { get; }

        // @property (nonatomic, strong) UIImage * _Nullable qmui_clearButtonImage __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("qmui_clearButtonImage", ArgumentSemantic.Strong)]
        UIImage Qmui_clearButtonImage { get; set; }

        // -(NSRange)qmui_convertNSRangeFromUITextRange:(UITextRange * _Nonnull)textRange;
        [Export("qmui_convertNSRangeFromUITextRange:")]
        NSRange Qmui_convertNSRangeFromUITextRange(UITextRange textRange);

        // -(UITextRange * _Nullable)qmui_convertUITextRangeFromNSRange:(NSRange)range;
        [Export("qmui_convertUITextRangeFromNSRange:")]
        [return: NullAllowed]
        UITextRange Qmui_convertUITextRangeFromNSRange(NSRange range);
    }

    // @interface QMUITextInput (NSObject)
    [Category]
    [BaseType(typeof(NSObject))]
    interface NSObject_QMUITextInput
    {
    }

    // @interface QMUITextInput_Private (NSObject)
    [Category]
    [BaseType(typeof(NSObject))]
    interface NSObject_QMUITextInput_Private
    {
        // @property (assign, nonatomic) UIKeyboardAppearance qmui_keyboardAppearance;
        [Export("qmui_keyboardAppearance", ArgumentSemantic.Assign)]
        UIKeyboardAppearance Qmui_keyboardAppearance { get; set; }

        // @property (assign, nonatomic) BOOL qmui_hasCustomizedKeyboardAppearance;
        [Export("qmui_hasCustomizedKeyboardAppearance")]
        bool Qmui_hasCustomizedKeyboardAppearance { get; set; }
    }

    // @interface QMUI (UITextView)
    [Category]
    [BaseType(typeof(UITextView))]
    interface UITextView_QMUI
    {
        // -(NSRange)qmui_convertNSRangeFromUITextRange:(UITextRange * _Nonnull)textRange;
        [Export("qmui_convertNSRangeFromUITextRange:")]
        NSRange Qmui_convertNSRangeFromUITextRange(UITextRange textRange);

        // -(UITextRange * _Nullable)qmui_convertUITextRangeFromNSRange:(NSRange)range;
        [Export("qmui_convertUITextRangeFromNSRange:")]
        [return: NullAllowed]
        UITextRange Qmui_convertUITextRangeFromNSRange(NSRange range);

        // -(void)qmui_setTextKeepingSelectedRange:(NSString * _Nonnull)text;
        [Export("qmui_setTextKeepingSelectedRange:")]
        void Qmui_setTextKeepingSelectedRange(string text);

        // -(void)qmui_setAttributedTextKeepingSelectedRange:(NSAttributedString * _Nonnull)attributedText;
        [Export("qmui_setAttributedTextKeepingSelectedRange:")]
        void Qmui_setAttributedTextKeepingSelectedRange(NSAttributedString attributedText);

        // -(void)qmui_scrollRangeToVisible:(NSRange)range;
        [Export("qmui_scrollRangeToVisible:")]
        void Qmui_scrollRangeToVisible(NSRange range);

        // -(void)qmui_scrollCaretVisibleAnimated:(BOOL)animated;
        [Export("qmui_scrollCaretVisibleAnimated:")]
        void Qmui_scrollCaretVisibleAnimated(bool animated);
    }

    // @interface QMUI (UITraitCollection)
    [Category]
    [BaseType(typeof(UITraitCollection))]
    interface UITraitCollection_QMUI
    {
        // +(void)qmui_addUserInterfaceStyleWillChangeObserver:(id _Nonnull)observer selector:(SEL _Nonnull)aSelector __attribute__((availability(ios, introduced=13.0)));
        [iOS(13, 0)]
        [Static]
        [Export("qmui_addUserInterfaceStyleWillChangeObserver:selector:")]
        void Qmui_addUserInterfaceStyleWillChangeObserver(NSObject observer, Selector aSelector);
    }

    // @interface QMUIBorder (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_QMUIBorder
    {
        // @property (assign, nonatomic) QMUIViewBorderLocation qmui_borderLocation;
        [Export("qmui_borderLocation", ArgumentSemantic.Assign)]
        QMUIViewBorderLocation Qmui_borderLocation { get; set; }

        // @property (assign, nonatomic) QMUIViewBorderPosition qmui_borderPosition;
        [Export("qmui_borderPosition", ArgumentSemantic.Assign)]
        QMUIViewBorderPosition Qmui_borderPosition { get; set; }

        // @property (assign, nonatomic) CGFloat qmui_borderWidth;
        [Export("qmui_borderWidth")]
        nfloat Qmui_borderWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable qmui_borderColor;
        [NullAllowed, Export("qmui_borderColor", ArgumentSemantic.Strong)]
        UIColor Qmui_borderColor { get; set; }

        // @property (assign, nonatomic) CGFloat qmui_dashPhase;
        [Export("qmui_dashPhase")]
        nfloat Qmui_dashPhase { get; set; }

        // @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable qmui_dashPattern;
        [NullAllowed, Export("qmui_dashPattern", ArgumentSemantic.Copy)]
        NSNumber[] Qmui_dashPattern { get; set; }

        // @property (readonly, nonatomic, strong) CAShapeLayer * _Nullable qmui_borderLayer;
        [NullAllowed, Export("qmui_borderLayer", ArgumentSemantic.Strong)]
        CAShapeLayer Qmui_borderLayer { get; }
    }

    // @interface QMUI (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_QMUI
    {
        // -(instancetype _Nonnull)qmui_initWithSize:(CGSize)size;
        [Export("qmui_initWithSize:")]
        UIView Qmui_initWithSize(CGSize size);

        // @property (assign, nonatomic) CGRect qmui_frameApplyTransform;
        [Export("qmui_frameApplyTransform", ArgumentSemantic.Assign)]
        CGRect Qmui_frameApplyTransform { get; set; }

        // @property (readonly, assign, nonatomic) UIEdgeInsets qmui_safeAreaInsets;
        [Export("qmui_safeAreaInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets Qmui_safeAreaInsets { get; }

        // @property (readonly, assign, nonatomic) BOOL qmui_tintColorCustomized;
        [Export("qmui_tintColorCustomized")]
        bool Qmui_tintColorCustomized { get; }

        // @property (assign, nonatomic) UIEdgeInsets qmui_outsideEdge;
        [Export("qmui_outsideEdge", ArgumentSemantic.Assign)]
        UIEdgeInsets Qmui_outsideEdge { get; set; }

        // -(void)qmui_removeAllSubviews;
        [Export("qmui_removeAllSubviews")]
        void Qmui_removeAllSubviews();

        // -(CGPoint)qmui_convertPoint:(CGPoint)point toView:(UIView * _Nullable)view;
        [Export("qmui_convertPoint:toView:")]
        CGPoint Qmui_convertPoint(CGPoint point, [NullAllowed] UIView view);

        // -(CGPoint)qmui_convertPoint:(CGPoint)point fromView:(UIView * _Nullable)view;
        [Export("qmui_convertPoint:fromView:")]
        CGPoint Qmui_convertPoint(CGPoint point, [NullAllowed] UIView view);

        // -(CGRect)qmui_convertRect:(CGRect)rect toView:(UIView * _Nullable)view;
        [Export("qmui_convertRect:toView:")]
        CGRect Qmui_convertRect(CGRect rect, [NullAllowed] UIView view);

        // -(CGRect)qmui_convertRect:(CGRect)rect fromView:(UIView * _Nullable)view;
        [Export("qmui_convertRect:fromView:")]
        CGRect Qmui_convertRect(CGRect rect, [NullAllowed] UIView view);

        // +(void)qmui_animateWithAnimated:(BOOL)animated duration:(NSTimeInterval)duration delay:(NSTimeInterval)delay options:(UIViewAnimationOptions)options animations:(void (^ _Nonnull)(void))animations completion:(void (^ _Nullable)(BOOL))completion;
        [Static]
        [Export("qmui_animateWithAnimated:duration:delay:options:animations:completion:")]
        void Qmui_animateWithAnimated(bool animated, double duration, double delay, UIViewAnimationOptions options, Action animations, [NullAllowed] Action<bool> completion);

        // +(void)qmui_animateWithAnimated:(BOOL)animated duration:(NSTimeInterval)duration animations:(void (^ _Nullable)(void))animations completion:(void (^ _Nullable)(BOOL))completion;
        [Static]
        [Export("qmui_animateWithAnimated:duration:animations:completion:")]
        void Qmui_animateWithAnimated(bool animated, double duration, [NullAllowed] Action animations, [NullAllowed] Action<bool> completion);

        // +(void)qmui_animateWithAnimated:(BOOL)animated duration:(NSTimeInterval)duration animations:(void (^ _Nullable)(void))animations;
        [Static]
        [Export("qmui_animateWithAnimated:duration:animations:")]
        void Qmui_animateWithAnimated(bool animated, double duration, [NullAllowed] Action animations);

        // +(void)qmui_animateWithAnimated:(BOOL)animated duration:(NSTimeInterval)duration delay:(NSTimeInterval)delay usingSpringWithDamping:(CGFloat)dampingRatio initialSpringVelocity:(CGFloat)velocity options:(UIViewAnimationOptions)options animations:(void (^ _Nonnull)(void))animations completion:(void (^ _Nonnull)(BOOL))completion;
        [Static]
        [Export("qmui_animateWithAnimated:duration:delay:usingSpringWithDamping:initialSpringVelocity:options:animations:completion:")]
        void Qmui_animateWithAnimated(bool animated, double duration, double delay, nfloat dampingRatio, nfloat velocity, UIViewAnimationOptions options, Action animations, Action<bool> completion);
    }

    // @interface QMUI_Block (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_QMUI_Block
    {
        // @property (copy, nonatomic) CGRect (^ _Nullable)(__kindof UIView * _Nonnull, CGRect) qmui_frameWillChangeBlock;
        [NullAllowed, Export("qmui_frameWillChangeBlock", ArgumentSemantic.Copy)]
        Func<UIView, CGRect, CGRect> Qmui_frameWillChangeBlock { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(__kindof UIView * _Nonnull, CGRect) qmui_frameDidChangeBlock;
        [NullAllowed, Export("qmui_frameDidChangeBlock", ArgumentSemantic.Copy)]
        Action<UIView, CGRect> Qmui_frameDidChangeBlock { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(__kindof UIView * _Nonnull) qmui_layoutSubviewsBlock;
        [NullAllowed, Export("qmui_layoutSubviewsBlock", ArgumentSemantic.Copy)]
        Action<UIView> Qmui_layoutSubviewsBlock { get; set; }

        // @property (copy, nonatomic) CGSize (^ _Nullable)(__kindof UIView * _Nonnull, CGSize, CGSize) qmui_sizeThatFitsBlock;
        [NullAllowed, Export("qmui_sizeThatFitsBlock", ArgumentSemantic.Copy)]
        Func<UIView, CGSize, CGSize, CGSize> Qmui_sizeThatFitsBlock { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(__kindof UIView * _Nonnull) qmui_tintColorDidChangeBlock;
        [NullAllowed, Export("qmui_tintColorDidChangeBlock", ArgumentSemantic.Copy)]
        Action<UIView> Qmui_tintColorDidChangeBlock { get; set; }

        // @property (copy, nonatomic) __kindof UIView * _Nonnull (^ _Nullable)(CGPoint, UIEvent * _Nonnull, __kindof UIView * _Nonnull) qmui_hitTestBlock;
        [NullAllowed, Export("qmui_hitTestBlock", ArgumentSemantic.Copy)]
        Func<CGPoint, UIEvent, UIView, UIView> Qmui_hitTestBlock { get; set; }
    }

    // @interface QMUI_ViewController (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_QMUI_ViewController
    {
        // @property (readonly, assign, nonatomic) BOOL qmui_visible;
        [Export("qmui_visible")]
        bool Qmui_visible { get; }

        // @property (assign, nonatomic) BOOL qmui_isControllerRootView;
        [Export("qmui_isControllerRootView")]
        bool Qmui_isControllerRootView { get; set; }

        // @property (readonly, nonatomic, weak) __kindof UIViewController * _Nullable qmui_viewController;
        [Export("qmui_viewController", ArgumentSemantic.Weak)]
        UIViewController Qmui_viewController { get; }
    }

    // @interface QMUI_Runtime (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_QMUI_Runtime
    {
        // -(BOOL)qmui_hasOverrideUIKitMethod:(SEL _Nonnull)selector;
        [Export("qmui_hasOverrideUIKitMethod:")]
        bool Qmui_hasOverrideUIKitMethod(Selector selector);
    }

    // @interface QMUI_Snapshotting (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_QMUI_Snapshotting
    {
        // -(UIImage * _Nonnull)qmui_snapshotLayerImage;
        [Export("qmui_snapshotLayerImage")]
        [Verify(MethodToProperty)]
        UIImage Qmui_snapshotLayerImage { get; }

        // -(UIImage * _Nonnull)qmui_snapshotImageAfterScreenUpdates:(BOOL)afterScreenUpdates;
        [Export("qmui_snapshotImageAfterScreenUpdates:")]
        UIImage Qmui_snapshotImageAfterScreenUpdates(bool afterScreenUpdates);
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const CGFloat QMUIViewSelfSizingHeight;
        [Field("QMUIViewSelfSizingHeight", "__Internal")]
        nfloat QMUIViewSelfSizingHeight { get; }
    }

    // @interface QMUI_Layout (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_QMUI_Layout
    {
        // @property (assign, nonatomic) CGFloat qmui_top;
        [Export("qmui_top")]
        nfloat Qmui_top { get; set; }

        // @property (assign, nonatomic) CGFloat qmui_left;
        [Export("qmui_left")]
        nfloat Qmui_left { get; set; }

        // @property (assign, nonatomic) CGFloat qmui_bottom;
        [Export("qmui_bottom")]
        nfloat Qmui_bottom { get; set; }

        // @property (assign, nonatomic) CGFloat qmui_right;
        [Export("qmui_right")]
        nfloat Qmui_right { get; set; }

        // @property (assign, nonatomic) CGFloat qmui_width;
        [Export("qmui_width")]
        nfloat Qmui_width { get; set; }

        // @property (assign, nonatomic) CGFloat qmui_height;
        [Export("qmui_height")]
        nfloat Qmui_height { get; set; }

        // @property (assign, nonatomic) CGFloat qmui_extendToTop;
        [Export("qmui_extendToTop")]
        nfloat Qmui_extendToTop { get; set; }

        // @property (assign, nonatomic) CGFloat qmui_extendToLeft;
        [Export("qmui_extendToLeft")]
        nfloat Qmui_extendToLeft { get; set; }

        // @property (assign, nonatomic) CGFloat qmui_extendToBottom;
        [Export("qmui_extendToBottom")]
        nfloat Qmui_extendToBottom { get; set; }

        // @property (assign, nonatomic) CGFloat qmui_extendToRight;
        [Export("qmui_extendToRight")]
        nfloat Qmui_extendToRight { get; set; }

        // @property (readonly, assign, nonatomic) CGFloat qmui_leftWhenCenterInSuperview;
        [Export("qmui_leftWhenCenterInSuperview")]
        nfloat Qmui_leftWhenCenterInSuperview { get; }

        // @property (readonly, assign, nonatomic) CGFloat qmui_topWhenCenterInSuperview;
        [Export("qmui_topWhenCenterInSuperview")]
        nfloat Qmui_topWhenCenterInSuperview { get; }
    }

    // @interface CGAffineTransform (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_CGAffineTransform
    {
        // @property (readonly, assign, nonatomic) CGFloat qmui_scaleX;
        [Export("qmui_scaleX")]
        nfloat Qmui_scaleX { get; }

        // @property (readonly, assign, nonatomic) CGFloat qmui_scaleY;
        [Export("qmui_scaleY")]
        nfloat Qmui_scaleY { get; }

        // @property (readonly, assign, nonatomic) CGFloat qmui_translationX;
        [Export("qmui_translationX")]
        nfloat Qmui_translationX { get; }

        // @property (readonly, assign, nonatomic) CGFloat qmui_translationY;
        [Export("qmui_translationY")]
        nfloat Qmui_translationY { get; }
    }

    // @interface QMUI_Debug (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_QMUI_Debug
    {
        // @property (assign, nonatomic) BOOL qmui_shouldShowDebugColor;
        [Export("qmui_shouldShowDebugColor")]
        bool Qmui_shouldShowDebugColor { get; set; }

        // @property (assign, nonatomic) BOOL qmui_needsDifferentDebugColor;
        [Export("qmui_needsDifferentDebugColor")]
        bool Qmui_needsDifferentDebugColor { get; set; }

        // @property (readonly, assign, nonatomic) BOOL qmui_hasDebugColor;
        [Export("qmui_hasDebugColor")]
        bool Qmui_hasDebugColor { get; }
    }

    // @interface QMUIBadge (UIView) <QMUIBadgeProtocol>
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_QMUIBadge : IQMUIBadgeProtocol
    {
    }

    [Static]
    [Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const NSNotificationName _Nonnull QMUIAppSizeWillChangeNotification;
        [Field("QMUIAppSizeWillChangeNotification", "__Internal")]
        NSString QMUIAppSizeWillChangeNotification { get; }

        // extern NSString *const _Nonnull QMUIPrecedingAppSizeUserInfoKey;
        [Field("QMUIPrecedingAppSizeUserInfoKey", "__Internal")]
        NSString QMUIPrecedingAppSizeUserInfoKey { get; }

        // extern NSString *const _Nonnull QMUIFollowingAppSizeUserInfoKey;
        [Field("QMUIFollowingAppSizeUserInfoKey", "__Internal")]
        NSString QMUIFollowingAppSizeUserInfoKey { get; }
    }

    // @interface QMUI (UIViewController)
    [Category]
    [BaseType(typeof(UIViewController))]
    interface UIViewController_QMUI
    {
        // @property (readonly, nonatomic, weak) UIViewController * _Nullable qmui_previousViewController;
        [NullAllowed, Export("qmui_previousViewController", ArgumentSemantic.Weak)]
        UIViewController Qmui_previousViewController { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable qmui_previousViewControllerTitle;
        [NullAllowed, Export("qmui_previousViewControllerTitle")]
        string Qmui_previousViewControllerTitle { get; }

        // -(UIViewController * _Nullable)qmui_visibleViewControllerIfExist;
        [NullAllowed, Export("qmui_visibleViewControllerIfExist")]
        [Verify(MethodToProperty)]
        UIViewController Qmui_visibleViewControllerIfExist { get; }

        // -(BOOL)qmui_isPresented;
        [Export("qmui_isPresented")]
        [Verify(MethodToProperty)]
        bool Qmui_isPresented { get; }

        // -(BOOL)qmui_isViewLoadedAndVisible;
        [Export("qmui_isViewLoadedAndVisible")]
        [Verify(MethodToProperty)]
        bool Qmui_isViewLoadedAndVisible { get; }

        // -(BOOL)qmui_isDescendantOfViewController:(UIViewController * _Nonnull)viewController;
        [Export("qmui_isDescendantOfViewController:")]
        bool Qmui_isDescendantOfViewController(UIViewController viewController);

        // @property (readonly, assign, nonatomic) QMUIViewControllerVisibleState qmui_visibleState;
        [Export("qmui_visibleState", ArgumentSemantic.Assign)]
        QMUIViewControllerVisibleState Qmui_visibleState { get; }

        // @property (copy, nonatomic) void (^ _Nullable)(__kindof UIViewController * _Nonnull, QMUIViewControllerVisibleState) qmui_visibleStateDidChangeBlock;
        [NullAllowed, Export("qmui_visibleStateDidChangeBlock", ArgumentSemantic.Copy)]
        Action<UIViewController, QMUIViewControllerVisibleState> Qmui_visibleStateDidChangeBlock { get; set; }

        // @property (readonly, assign, nonatomic) CGFloat qmui_navigationBarMaxYInViewCoordinator;
        [Export("qmui_navigationBarMaxYInViewCoordinator")]
        nfloat Qmui_navigationBarMaxYInViewCoordinator { get; }

        // @property (readonly, assign, nonatomic) CGFloat qmui_toolbarSpacingInViewCoordinator;
        [Export("qmui_toolbarSpacingInViewCoordinator")]
        nfloat Qmui_toolbarSpacingInViewCoordinator { get; }

        // @property (readonly, assign, nonatomic) CGFloat qmui_tabBarSpacingInViewCoordinator;
        [Export("qmui_tabBarSpacingInViewCoordinator")]
        nfloat Qmui_tabBarSpacingInViewCoordinator { get; }

        // @property (copy, nonatomic) BOOL (^ _Nullable)(void) qmui_prefersStatusBarHiddenBlock;
        [NullAllowed, Export("qmui_prefersStatusBarHiddenBlock", ArgumentSemantic.Copy)]
        Func<bool> Qmui_prefersStatusBarHiddenBlock { get; set; }

        // @property (copy, nonatomic) UIStatusBarStyle (^ _Nullable)(void) qmui_preferredStatusBarStyleBlock;
        [NullAllowed, Export("qmui_preferredStatusBarStyleBlock", ArgumentSemantic.Copy)]
        Func<UIStatusBarStyle> Qmui_preferredStatusBarStyleBlock { get; set; }

        // @property (copy, nonatomic) UIStatusBarAnimation (^ _Nullable)(void) qmui_preferredStatusBarUpdateAnimationBlock;
        [NullAllowed, Export("qmui_preferredStatusBarUpdateAnimationBlock", ArgumentSemantic.Copy)]
        Func<UIStatusBarAnimation> Qmui_preferredStatusBarUpdateAnimationBlock { get; set; }

        // @property (copy, nonatomic) BOOL (^ _Nullable)(void) qmui_prefersHomeIndicatorAutoHiddenBlock __attribute__((availability(ios, introduced=11.0)));
        [iOS(11, 0)]
        [NullAllowed, Export("qmui_prefersHomeIndicatorAutoHiddenBlock", ArgumentSemantic.Copy)]
        Func<bool> Qmui_prefersHomeIndicatorAutoHiddenBlock { get; set; }

        // @property (readonly, assign, nonatomic) BOOL qmui_prefersStatusBarHidden;
        [Export("qmui_prefersStatusBarHidden")]
        bool Qmui_prefersStatusBarHidden { get; }

        // @property (readonly, assign, nonatomic) UIStatusBarStyle qmui_preferredStatusBarStyle;
        [Export("qmui_preferredStatusBarStyle", ArgumentSemantic.Assign)]
        UIStatusBarStyle Qmui_preferredStatusBarStyle { get; }

        // @property (readonly, assign, nonatomic) BOOL qmui_prefersLargeTitleDisplayed;
        [Export("qmui_prefersLargeTitleDisplayed")]
        bool Qmui_prefersLargeTitleDisplayed { get; }
    }

    // @interface Data (UIViewController)
    [Category]
    [BaseType(typeof(UIViewController))]
    interface UIViewController_Data
    {
        // @property (copy, nonatomic) void (^ _Nullable)(void) qmui_didAppearAndLoadDataBlock;
        [NullAllowed, Export("qmui_didAppearAndLoadDataBlock", ArgumentSemantic.Copy)]
        Action Qmui_didAppearAndLoadDataBlock { get; set; }

        // @property (getter = isQmui_dataLoaded, assign, nonatomic) BOOL qmui_dataLoaded;
        [Export("qmui_dataLoaded")]
        bool Qmui_dataLoaded { [Bind("isQmui_dataLoaded")] get; set; }
    }

    // @interface Runtime (UIViewController)
    [Category]
    [BaseType(typeof(UIViewController))]
    interface UIViewController_Runtime
    {
        // -(BOOL)qmui_hasOverrideUIKitMethod:(SEL _Nonnull)selector;
        [Export("qmui_hasOverrideUIKitMethod:")]
        bool Qmui_hasOverrideUIKitMethod(Selector selector);
    }

    // @interface RotateDeviceOrientation (UIViewController)
    [Category]
    [BaseType(typeof(UIViewController))]
    interface UIViewController_RotateDeviceOrientation
    {
        // -(BOOL)qmui_shouldForceRotateDeviceOrientation;
        [Export("qmui_shouldForceRotateDeviceOrientation")]
        [Verify(MethodToProperty)]
        bool Qmui_shouldForceRotateDeviceOrientation { get; }
    }

    // @interface QMUINavigationController (UIViewController)
    [Category]
    [BaseType(typeof(UIViewController))]
    interface UIViewController_QMUINavigationController
    {
        // @property (readonly, assign, nonatomic) BOOL qmui_navigationControllerPoppingInteracted;
        [Export("qmui_navigationControllerPoppingInteracted")]
        bool Qmui_navigationControllerPoppingInteracted { get; }

        // @property (assign, nonatomic) BOOL qmui_navigationControllerPopGestureRecognizerChanging;
        [Export("qmui_navigationControllerPopGestureRecognizerChanging")]
        bool Qmui_navigationControllerPopGestureRecognizerChanging { get; set; }

        // @property (assign, nonatomic) BOOL qmui_poppingByInteractivePopGestureRecognizer;
        [Export("qmui_poppingByInteractivePopGestureRecognizer")]
        bool Qmui_poppingByInteractivePopGestureRecognizer { get; set; }

        // @property (assign, nonatomic) BOOL qmui_willAppearByInteractivePopGestureRecognizer;
        [Export("qmui_willAppearByInteractivePopGestureRecognizer")]
        bool Qmui_willAppearByInteractivePopGestureRecognizer { get; set; }

        // -(void)qmui_animateAlongsideTransition:(void (^ _Nullable)(id<UIViewControllerTransitionCoordinatorContext> _Nonnull))animation completion:(void (^ _Nullable)(id<UIViewControllerTransitionCoordinatorContext> _Nonnull))completion;
        [Export("qmui_animateAlongsideTransition:completion:")]
        void Qmui_animateAlongsideTransition([NullAllowed] Action<UIViewControllerTransitionCoordinatorContext> animation, [NullAllowed] Action<UIViewControllerTransitionCoordinatorContext> completion);
    }

    // @interface ViewController (QMUIHelper)
    [Category]
    [BaseType(typeof(QMUIHelper))]
    interface QMUIHelper_ViewController
    {
        // +(UIViewController * _Nullable)visibleViewController;
        [Static]
        [NullAllowed, Export("visibleViewController")]
        [Verify(MethodToProperty)]
        UIViewController VisibleViewController { get; }
    }

    // @interface QMUI (UIVisualEffectView)
    [Category]
    [BaseType(typeof(UIVisualEffectView))]
    interface UIVisualEffectView_QMUI
    {
        // @property (nonatomic, strong) UIColor * _Nullable qmui_foregroundColor;
        [NullAllowed, Export("qmui_foregroundColor", ArgumentSemantic.Strong)]
        UIColor Qmui_foregroundColor { get; set; }
    }

    // @interface QMUI (UIWindow)
    [Category]
    [BaseType(typeof(UIWindow))]
    interface UIWindow_QMUI
    {
        // @property (assign, nonatomic) BOOL qmui_capturesStatusBarAppearance;
        [Export("qmui_capturesStatusBarAppearance")]
        bool Qmui_capturesStatusBarAppearance { get; set; }
    }

}

