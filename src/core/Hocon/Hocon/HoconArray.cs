﻿//-----------------------------------------------------------------------
// <copyright file="HoconArray.cs" company="Hocon Project">
//     Copyright (C) 2009-2015 Typesafe Inc. <http://www.typesafe.com>
//     Copyright (C) 2013-2015 Akka.NET project <https://github.com/akkadotnet/hocon>
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Configuration.Hocon
{
    /// <summary>
    /// This class represents an array element in a HOCON (Human-Optimized Config Object Notation)
    /// configuration string.
    /// <code>
    /// root {
    ///     items = [
    ///       "1",
    ///       "2"]
    /// }
    /// </code>
    /// </summary>
    public class HoconArray : List<HoconValue>, IHoconElement
    {
        /// <summary>
        /// Determines whether this element is a string.
        /// </summary>
        /// <returns><c>false</c></returns>
        public bool IsString()
        {
            return false;
        }

        /// <summary>
        /// Retrieves the string representation of this element.
        /// </summary>
        /// <returns>
        /// The string representation of this element.
        /// </returns>
        /// <exception cref="System.NotImplementedException">
        /// This element is an array. It is not a string.
        /// Therefore this method will throw an exception.
        /// </exception>
        public string GetString()
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Determines whether this element is an array.
        /// </summary>
        /// <returns><c>true</c></returns>
        public bool IsArray()
        {
            return true;
        }

        /// <summary>
        /// Retrieves a list of elements associated with this element.
        /// </summary>
        /// <returns>
        /// A list of elements associated with this element.
        /// </returns>
        public IList<HoconValue> GetArray()
        {
            return this;
        }

        /// <summary>
        /// Returns a HOCON string representation of this element.
        /// </summary>
        /// <returns>A HOCON string representation of this element.</returns>
        public override string ToString()
        {
            return "[" + string.Join(",", this) + "]";
        }
    }
}

