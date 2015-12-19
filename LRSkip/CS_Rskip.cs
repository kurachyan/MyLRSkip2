using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRSkip
{
    class CS_Rskip
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
        public CS_Rskip()
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
        {   // 右側余白情報を削除
            if (!_empty)
            {   // バッファーに実装有り
                _wbuf = _wbuf.TrimEnd(_trim);       // 右側余白情報を削除

                if (_wbuf.Length == 0 || _wbuf == null)
                {   // バッファー情報無し
                    this.Clear();           // 作業領域の初期化
                }
            }
        }
        #endregion
    }
}
