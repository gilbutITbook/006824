using DotNetNote.Models;
using System;

namespace MemoEngine.DotNetNote
{
    public partial class BoardWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctlBoardEditorFormControl.FormType = BoardWriteFormType.Write;
        }
    }
}