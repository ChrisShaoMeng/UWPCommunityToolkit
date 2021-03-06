﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace Microsoft.Toolkit.Uwp.UI.Controls.Markdown.Render
{
    /// <summary>
    /// An interface used to resolve images in the markdown.
    /// </summary>
    public interface IImageResolver
    {
        /// <summary>
        /// Resolves an Image from a Url.
        /// </summary>
        /// <param name="url">Url to Resolve.</param>
        /// <param name="tooltip">Tooltip for Image.</param>
        /// <returns>Image</returns>
        Task<ImageSource> ResolveImageAsync(string url, string tooltip);
    }
}