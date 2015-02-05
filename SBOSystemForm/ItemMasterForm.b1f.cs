using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;

namespace SBOSystemForm
{
    [FormAttribute("150", "ItemMasterForm.b1f")]
    class ItemMasterForm : SystemFormBase
    {
        public ItemMasterForm()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_0").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private SAPbouiCOM.Button Button0;

        private void OnCustomInitialize()
        {

        }
    }
}
