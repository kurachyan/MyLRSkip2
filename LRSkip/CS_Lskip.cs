using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRSkip
{
    public class CS_Lskip
    {
        #region 共有領域
        private static String _wbuf;
        private static Boolean _empty;
        public String Wbuf
        {
            get
            {
                return (_wbuf);
            }
            set
            {
                _wbuf = value;
                if (_wbuf == null)
                {   // 設定情報は無し？
                    _empty = true;
                }
                else
                {
                    _empty = false;
                }
            }
        }
        private static readonly char[] _trim = { ' ', '\t', '\r', '\n' };
        #endregion

        #region コンストラクタ
        public CS_Lskip()
        {   // コンストラクタ
            _wbuf = null;       // 設定情報無し
            _empty = true;
        }
        #endregion

        #region モジュール
        public void Clear()
        {   // 作業領域の初期化
            _wbuf = null;       // 設定情報無し
            _empty = true;
        }

        // '14.01.07 : 評価対象に"￥ｒ"追加
        public void Exec()
        {   // 左側余白情報を削除（固定区切り）
            if (!_empty)
            {   // バッファーに実装有り
                _wbuf = _wbuf.TrimStart(_trim);       // 左側余白情報を削除

                if (_wbuf.Length == 0 || _wbuf == null)
                {   // バッファー情報無し
                    Clear();           // 作業領域の初期化
                }

            }
        }
        public void Exec(char[] __trim)
        {   // 左側余白情報を削除（指定区切り）
            if (!_empty)
            {   // バッファーに実装有り
                _wbuf = _wbuf.TrimStart(__trim);       // 左側余白情報を削除

                if (_wbuf.Length == 0 || _wbuf == null)
                {   // バッファー情報無し
                    Clear();           // 作業領域の初期化
                }

            }
        }

        public void Exec(String msg)
        {   // 左側余白情報を削除（固定区切り）
            Setbuf(msg);                 // 入力内容の作業領域設定

            if (!_empty)
            {   // バッファーに実装有り
                _wbuf = _wbuf.TrimStart(_trim);       // 左側余白情報を削除

                if (_wbuf.Length == 0 || _wbuf == null)
                {   // バッファー情報無し
                    Clear();           // 作業領域の初期化
                }

            }
        }
        public void Exec(String msg, char[] __trim)
        {   // 左側余白情報を削除（指定区切り）
            Setbuf(msg);                 // 入力内容の作業領域設定

            if (!_empty)
            {   // バッファーに実装有り
                _wbuf = _wbuf.TrimStart(__trim);       // 左側余白情報を削除

                if (_wbuf.Length == 0 || _wbuf == null)
                {   // バッファー情報無し
                    Clear();           // 作業領域の初期化
                }

            }
        }

        private void Setbuf(String _strbuf)
        {   // [_wbuf]情報設定
            _wbuf = _strbuf;
            if (_wbuf == null)
            {   // 設定情報は無し？
                _empty = true;
            }
            else
            {
                _empty = false;
            }
        }
        #endregion
    }
}
