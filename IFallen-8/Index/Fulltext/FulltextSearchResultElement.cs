// 
// FulltextSearchResultElement.cs
//  
// Author:
//       Henning Rauch <Henning@RauchEntwicklung.biz>
// 
// Copyright (c) 2011 Henning Rauch
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using Fallen8.Model;
using System.Collections.Generic;

namespace Fallen8.API.Index
{
	/// <summary>
	/// Fulltext search result element.
	/// </summary>
	public class FulltextSearchResultElement
	{
		/// <summary>
		/// Gets or sets the graph element.
		/// </summary>
		/// <value>
		/// The graph element.
		/// </value>
		public IGraphElementModel GraphElement { get; private set; }
		
		/// <summary>
		/// Gets or sets the highlights.
		/// </summary>
		/// <value>
		/// The highlights.
		/// </value>
		public IList<string> Highlights { get; private set; }
		
		/// <summary>
		/// Gets or sets the score.
		/// </summary>
		/// <value>
		/// The score.
		/// </value>
		public Double Score { get; private set; }
	}
}
