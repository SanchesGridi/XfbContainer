using System;
using System.Collections.Generic;
using Prism.Services.Dialogs;
using XfbContainer.CommonTypes.Extensions;

namespace XfbContainer.WpfDomain.Extensions
{
    public static class DialogExtensions
    {
        public static void ShowDefaultDialogBox<TParameter>(
            this IDialogService @this,
            string dialogName,
            bool isModal = false,
            Action<IDialogResult> okAction = null,
            Action<IDialogResult> cancelAction = null,
            Action<IDialogResult> closeAction = null,
            params KeyValuePair<string, TParameter>[] parameters)
        {
            dialogName.VerifyReference();
            var dialogParameters = new DialogParameters().AddOnInit(parameters);
            var dialogCallback = (Action<IDialogResult>)((IDialogResult dialogResult) =>
            {
                if (dialogResult.Result == ButtonResult.OK)
                {
                    okAction?.Invoke(dialogResult);
                }
                else if (dialogResult.Result == ButtonResult.Cancel)
                {
                    cancelAction?.Invoke(dialogResult);
                }
                else if (dialogResult.Result == ButtonResult.None)
                {
                    closeAction?.Invoke(dialogResult);
                }
            });

            if (isModal)
            {
                @this.ShowDialog(dialogName, dialogParameters, dialogCallback);
            }
            else
            {
                @this.Show(dialogName, dialogParameters, dialogCallback);
            }
        }
        public static IDialogParameters AddOnInit<TParameter>(this IDialogParameters @this, params KeyValuePair<string, TParameter>[] parameters)
        {
            @this.VerifyReference();
            parameters.VerifyCollectionNotNullOrEmpty();

            foreach (var parameter in parameters)
            {
                var key = parameter.Key;
                var value = parameter.Value;

                @this.Add(key, value);
            }

            return @this;
        }
        public static (bool Value, string SelectedPath) OpenFolderDialog(this IDialogService @this)
        {
            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    return (true, dialog.SelectedPath);
                }
                else
                {
                    return (false, null);
                }
            }
        }
    }
}
