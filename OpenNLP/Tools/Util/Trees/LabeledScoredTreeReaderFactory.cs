﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenNLP.Tools.Util.Ling;

namespace OpenNLP.Tools.Util.Trees
{
    /**
 * This class implements a <code>TreeReaderFactory</code> that produces
 * labeled, scored array-based Trees, which have been cleaned up to
 * delete empties, etc.   This seems to be a common case (for English).
 * By default, the labels are of type CategoryWordTag,
 * but a different Label type can be specified by the user.
 *
 * @author Christopher Manning
 */

    public class LabeledScoredTreeReaderFactory : TreeReaderFactory
    {
        private readonly LabelFactory lf;
        private readonly TreeNormalizer tm;

        /**
   * Create a new TreeReaderFactory with CoreLabel labels.
   */

        public LabeledScoredTreeReaderFactory()
        {
            lf = CoreLabel.Factory();
            tm = new BobChrisTreeNormalizer();
        }

        public LabeledScoredTreeReaderFactory(LabelFactory lf)
        {
            this.lf = lf;
            tm = new BobChrisTreeNormalizer();
        }

        public LabeledScoredTreeReaderFactory(TreeNormalizer tm)
        {
            lf = CoreLabel.Factory();
            this.tm = tm;
        }

        public LabeledScoredTreeReaderFactory(LabelFactory lf, TreeNormalizer tm)
        {
            this.lf = lf;
            this.tm = tm;
        }

        /**
   * An implementation of the <code>TreeReaderFactory</code> interface.
   * It creates a <code>TreeReader</code> which normalizes trees using
   * the <code>BobChrisTreeNormalizer</code>, and makes
   * <code>LabeledScoredTree</code> objects with
   * <code>CategoryWordTag</code> labels (unless otherwise specified on
   * construction).
   */

        public TreeReader newTreeReader(TextReader input)
        {
            return new PennTreeReader(input, new LabeledScoredTreeFactory(lf), tm);
        }
    }
}