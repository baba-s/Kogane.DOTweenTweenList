using System.Collections.Generic;
using DG.Tweening;

namespace Kogane
{
    /// <summary>
    /// DOTween の Tween をリストで管理するクラス
    /// DOTween.Sequence で結合はしないが同時に完了させたい場合などに使用します
    /// </summary>
    public sealed class TweenList
    {
        //================================================================================
        // 変数(readonly)
        //================================================================================
        private readonly List<Tween> m_list = new();

        //================================================================================
        // 関数
        //================================================================================
        /// <summary>
        /// 管理したい Tween を追加します
        /// </summary>
        public void Add( Tween tween )
        {
            m_list.Add( tween );
        }

        /// <summary>
        /// すべての Tween を完了してリストから削除します
        /// </summary>
        public void CompleteAll()
        {
            // 非同期処理を使う関係で foreach だと以下の例外が発生するため for で記述しています
            // InvalidOperationException: Collection was modified; enumeration operation may not execute.
            for ( var i = 0; i < m_list.Count; i++ )
            {
                var tween = m_list[ i ];
                tween?.Complete();
            }

            m_list.Clear();
        }

        /// <summary>
        /// すべての Tween を Kill してリストから削除します
        /// </summary>
        public void KillAll()
        {
            // 非同期処理を使う関係で foreach だと以下の例外が発生するため for で記述しています
            // InvalidOperationException: Collection was modified; enumeration operation may not execute.
            for ( var i = 0; i < m_list.Count; i++ )
            {
                var tween = m_list[ i ];
                tween?.Kill();
            }

            m_list.Clear();
        }
    }
}