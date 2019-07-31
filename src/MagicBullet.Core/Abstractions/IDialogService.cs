//-----------------------------------------------------------------------
// <copyright file="IDialogService.cs" company="Magic Bullet Ltd">
//     Copyright (c) Magic Bullet Ltd. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace MagicBullet.Core.Abstractions
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The DialogService interface.
    /// </summary>
    public interface IDialogService
    {
        /// <summary>
        /// The alert.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="title">
        /// The title.
        /// </param>
        /// <param name="okText">
        /// The ok text.
        /// </param>
        void Alert(string message, string title, string okText = "");

        /// <summary>
        /// The alert async.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="title">
        /// The title.
        /// </param>
        /// <param name="okText">
        /// The ok text.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task AlertAsync(string message, string title, string okText = "");

        /// <summary>The action sheet async.</summary>
        /// <param name="title">The title.</param>
        /// <param name="cancel">The cancel.</param>
        /// <param name="destructive">The destructive.</param>
        /// <param name="cancelToken">The cancel token.</param>
        /// <param name="buttons">The buttons.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        Task<string> ActionSheetAsync(
            string title,
            string cancel,
            string destructive,
            CancellationToken? cancelToken = null,
            params string[] buttons);

        /// <summary>
        /// The confirm async.
        /// </summary>
        /// <param name="title">
        /// The title.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="okText">
        /// The ok text.
        /// </param>
        /// <param name="cancelText">
        /// The cancel text.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<bool> ConfirmAsync(string title, string message, string okText, string cancelText);

        /// <summary>
        /// The toast.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        void Toast(string message);

        /// <summary>
        /// The hide loading.
        /// </summary>
        void HideLoading();

        /// <summary>
        /// The show loading.
        /// </summary>
        /// <param name="title">
        /// The title.
        /// </param>
        void ShowLoading(string title = null);
    }
}