using DG.Tweening;

namespace Kogane
{
    public static class TweenExtensionMethods
    {
        public static T AddToList<T>( this T self, TweenList tweenList ) where T : Tween
        {
            tweenList.Add( self );
            return self;
        }
    }
}