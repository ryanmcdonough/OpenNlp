﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenNLP.Tools.Util.Ling
{
    /**
 * Something that implements the <code>HasTag</code> interface
 * knows about part-of-speech tags.
 *
 * @author Christopher Manning
 */

    public interface HasTag
    {
        /**
   * Return the tag value of the label (or null if none).
   *
   * @return string the tag value for the label
   */
        string Tag();


        /**
         * Set the tag value for the label (if one is stored).
         *
         * @param tag The tag value for the label
         */
        void SetTag(string tag);
    }
}