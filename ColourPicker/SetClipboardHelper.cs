﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColourPicker
{
    class SetClipboardHelper : StaHelper
    {
        readonly string _format;
        readonly object _data;

        public SetClipboardHelper(string format, object data)
        {
            _format = format;
            _data = data;
        }

        protected override void Work()
        {
            var obj = new System.Windows.Forms.DataObject(
                _format,
                _data
            );

            Clipboard.SetDataObject(obj, true);
        }

        internal override void LogAndShowMessage(Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}
