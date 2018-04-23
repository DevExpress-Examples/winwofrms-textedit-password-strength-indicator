using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;

namespace TextEditPasswordStrengthBar
{
    class TextEditPwdStrengthViewInfo : TextEditViewInfo
    {
        public TextEditPwdStrengthViewInfo(RepositoryItem item) : base(item) { }

        public RepositoryItemTextEditPwdStrength RepositoryItem
        {
            get { return this.Item as RepositoryItemTextEditPwdStrength; }
        }

        protected override System.Drawing.Rectangle CalcMaskBoxRect(System.Drawing.Rectangle content, ref Rectangle contextImageBounds)
        {
            Rectangle r = base.CalcMaskBoxRect(content, ref contextImageBounds);
            r.Height -= 1;
            r.Y = 1;
            return r;
        }
    }
}
