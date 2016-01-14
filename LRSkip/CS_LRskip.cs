using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRSkip
{
    public class CS_LRskip
    {
        #region 共有領域
        private String _wbuf;
        private Boolean _empty;
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
        private char[] _trim = { ' ', '\t', '\r', '\n' };
        #endregion

        #region コンストラクタ
        public CS_LRskip()
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

        public void Exec()
        {   // 両側余白情報を削除（固定区切り）
            if (!_empty)
            {   // バッファーに実装有り
/*
                _wbuf = _wbuf.TrimStart(_trim);     // 左側余白情報を削除
                _wbuf = _wbuf.TrimEnd(_trim);       // 右側余白情報を削除
*/

                _wbuf = _wbuf.Trim(_trim);          // 両側余白情報を削除

                if (_wbuf.Length == 0 || _wbuf == null)
                {   // バッファー情報無し
                    Clear();           // 作業領域の初期化
                }
            }
        }
        public void Exec(char[] __trim)
        {   // 両側余白情報を削除（指定区切り）
            if (!_empty)
            {   // バッファーに実装有り
/*
                _wbuf = _wbuf.TrimStart(__trim);      // 左側余白情報を削除
                _wbuf = _wbuf.TrimEnd(__trim);       // 右側余白情報を削除
*/

                _wbuf = _wbuf.Trim(__trim);          // 両側余白情報を削除

                if (_wbuf.Length == 0 || _wbuf == null)
                {   // バッファー情報無し
                    Clear();           // 作業領域の初期化
                }
            }
        }

        public void Exec(String msg)
        {   // 両側余白情報を削除（固定区切り）
            Setbuf(msg);                 // 入力内容の作業領域設定

            if (!_empty)
            {   // バッファーに実装有り
/*
                _wbuf = _wbuf.TrimStart(_trim);     // 左側余白情報を削除
                _wbuf = _wbuf.TrimEnd(_trim);       // 右側余白情報を削除
*/

                _wbuf = _wbuf.Trim(_trim);          // 両側余白情報を削除

                if (_wbuf.Length == 0 || _wbuf == null)
                {   // バッファー情報無し
                    Clear();           // 作業領域の初期化
                }
            }
        }
        public void Exec(String msg, char[] __trim)
        {   // 両側余白情報を削除（指定区切り）
            Setbuf(msg);                 // 入力内容の作業領域設定

            if (!_empty)
            {   // バッファーに実装有り
/*
                _wbuf = _wbuf.TrimStart(__trim);     // 左側余白情報を削除
                _wbuf = _wbuf.TrimEnd(__trim);       // 右側余白情報を削除
*/

                _wbuf = _wbuf.Trim(__trim);          // 両側余白情報を削除

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
