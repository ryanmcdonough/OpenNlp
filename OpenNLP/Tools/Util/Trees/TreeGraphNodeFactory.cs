﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenNLP.Tools.Util.Ling;

namespace OpenNLP.Tools.Util.Trees
{
    /**
 * A <code>TreeGraphNodeFactory</code> acts as a factory for creating
 * nodes in a {@link TreeGraph <code>TreeGraph</code>}.  Unless
 * another {@link LabelFactory <code>LabelFactory</code>} is
 * supplied, it will use a CoreLabelFactory
 * by default.
 *
 * @author Bill MacCartney
 */

    public class TreeGraphNodeFactory : TreeFactory
    {
        private LabelFactory mlf;

        /**
   * Make a <code>TreeFactory</code> that produces
   * <code>TreeGraphNode</code>s.  The labels are of class
   * <code>CoreLabel</code>.
   */

        public TreeGraphNodeFactory() :
            this(CoreLabel.Factory())
        {
        }

        public TreeGraphNodeFactory(LabelFactory mlf)
        {
            this.mlf = mlf;
        }

        // docs inherited
        public Tree newLeaf( /*final*/ string word)
        {
            return newLeaf(mlf.NewLabel(word));
        }

        // docs inherited
        public Tree newLeaf(Label label)
        {
            return new TreeGraphNode(label);
        }

        // docs inherited
        public Tree newTreeNode( /*final*/ string parent, /*final*/ List<Tree> children)
        {
            return newTreeNode(mlf.NewLabel(parent), children);
        }

        // docs inherited
        public Tree newTreeNode(Label parentLabel, List<Tree> children)
        {
            return new TreeGraphNode(parentLabel, children);
        }
    }
}