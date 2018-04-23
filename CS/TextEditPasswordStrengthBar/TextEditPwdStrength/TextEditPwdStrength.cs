using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace TextEditPasswordStrengthBar
{
    class TextEditPwdStrength : TextEdit
    {
        static TextEditPwdStrength() { RepositoryItemTextEditPwdStrength.RegisterTextEditPwdStrength(); }
        public TextEditPwdStrength() : base() { }

        public override string EditorTypeName { get { return RepositoryItemTextEditPwdStrength.TextEditPwdStrengthName; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemTextEditPwdStrength Properties
        { get { return base.Properties as RepositoryItemTextEditPwdStrength; } }

        protected override void OnEditValueChanged()
        {
            this.RefreshVisualLayout();
            base.OnEditValueChanged();
        }
    }
}
