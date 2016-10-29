using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBlackTreeProject
{
    class RBTree
    {
        private RBTreeNode root = null;
        private RBTreeNode newNode;
        private RBTreeNode deleteChild;
        private int level;
        private static int defaultPrintNodeLength = 4;
        private RBTreeStepsForm stepsForm;

        public RBTree(RBTreeStepsForm stepsForm)
        {
            this.stepsForm = stepsForm;
        }


        internal RBTreeNode Root
        {
            get { return root; }
        }

        public int Level
        {
            get { return level; }
        }

        public static int DefaultLength
        {
            get { return defaultPrintNodeLength; }
        }

        public static void ResetDefaultLength()
        {
            defaultPrintNodeLength = 4;
        }

        public void Reset()
        {
            root = null;
            newNode = null;
            level = 0;
        }

        public void AddElement(int value)
        {
            if (value.ToString().Length + 2 > RBTree.defaultPrintNodeLength)
            {
                int newLength = value.ToString().Length + 2;
                if (newLength % 2 == 1)
                {
                    newLength += 1;
                }
                RBTree.defaultPrintNodeLength = newLength;
            }
            newNode = new RBTreeNode(value, true);
            stepsForm.AddStep("Dodaje se novi čvor N crvene boje: " + newNode + ".");
            if (root == null)
            {
                root = newNode;
                stepsForm.AddSubStep(string.Format("Novi čvor N {0} je korijen stabla, boja mu se mijenja u crnu.",
                    newNode));
                root.isRed = false;
            }
            else
            {
                InsertIntoTree(value);
                RBTreeNode parent = newNode.parentNode;
                if (!parent.isRed)
                {
                    stepsForm.AddSubStep("Roditelj P " + parent + " je crne boje. Nema potrebe za rekonstrukcijom.");
                }
                while (newNode.parentNode != null && newNode.parentNode.isRed)
                {
                    stepsForm.AddSubStep(string.Format("Roditelj P {0} je crvene boje.",
                        newNode.parentNode));
                    RBTreeNode grandparent = newNode.parentNode.parentNode;
                    RBTreeNode uncle;
                    // p(N) == g(N).left
                    if (newNode.parentNode == newNode.parentNode.parentNode.leftNode)
                    {
                        uncle = newNode.parentNode.parentNode.rightNode;
                        stepsForm.AddSubStep(string.Format("P {0} je lijevo dijete od djeda G {1}. "+
                            "Ujak U {2} je desno dijete od G {1}.", 
                            newNode.parentNode, newNode.parentNode.parentNode, uncle));
                        if (uncle != null && uncle.isRed)
                        {
                            stepsForm.AddSubStep(string.Format("U {0} je crven. P {1} postaje crn, "+
                                "U {0} postaje crn, G {2} postaje crven.", 
                                uncle, newNode.parentNode, newNode.parentNode.parentNode));
                            newNode.parentNode.isRed = false;
                            uncle.isRed = false;
                            newNode.parentNode.parentNode.isRed = true;
                            newNode = newNode.parentNode.parentNode;
                        }
                        else
                        {
                            parent = newNode.parentNode;
                            grandparent = parent.parentNode;
                            stepsForm.AddSubStep(string.Format("U {0} je crn.", uncle));
                            if (newNode == parent.rightNode)
                            {
                                stepsForm.AddSubStep(string.Format("Novi čvor N {0} je desno dijete od P {1}. "+
                                    "Obavlja se lijeva rotacija N {0} oko P {1}.",
                                    newNode, parent));
                                grandparent.leftNode = newNode;
                                FixParent(grandparent.leftNode, grandparent);

                                parent.rightNode = newNode.leftNode;
                                FixParent(parent.rightNode, parent);

                                newNode.leftNode = parent;
                                FixParent(newNode.leftNode, newNode);

                                stepsForm.AddSubStep(string.Format("N {0} postaje P {1}.",
                                    newNode, parent));
                                newNode = parent;
                            }
                            RBTreeNode tempParent = newNode.parentNode;
                            RBTreeNode tempGrandparent = tempParent.parentNode;
                            RBTreeNode tempGrandGrandparent = tempGrandparent.parentNode;
                            stepsForm.AddSubStep(string.Format("Obavlja se desna rotacija roditelja od N p(N) {0} oko djeda od N g(N) {1}.",
                                tempParent, tempGrandparent));

                            Rotation(newNode.parentNode, newNode.parentNode.parentNode, true);
                            stepsForm.AddSubStep(string.Format("P {0} postaje crn, G {1} postaje crven.",
                                newNode.parentNode, newNode.parentNode.parentNode));
                            if (newNode.parentNode != null)
                            {
                                newNode.parentNode.isRed = false;
                            }
                            newNode.parentNode.parentNode.isRed = true;


                        }
                    }
                    else
                    {
                        uncle = newNode.parentNode.parentNode.leftNode;
                        stepsForm.AddSubStep(string.Format("P {0} je desno dijete od djeda G {1}. Ujak U {2} je lijevo dijete od G {1}.",
                            parent, grandparent, uncle));
                        if (uncle != null && uncle.isRed)
                        {
                            stepsForm.AddSubStep(string.Format("U {0} je crven. P {1} postaje crn, U {0} postaje crn, G {2} postaje crven.",
                                uncle, newNode.parentNode, newNode.parentNode.parentNode));
                            newNode.parentNode.isRed = false;
                            uncle.isRed = false;
                            newNode.parentNode.parentNode.isRed = true;
                            newNode = newNode.parentNode.parentNode;
                        }
                        else
                        {
                            parent = newNode.parentNode;
                            grandparent = parent.parentNode;
                            stepsForm.AddSubStep(string.Format("U {0} je crn.",
                                uncle));
                            if (newNode == parent.leftNode)
                            {
                                stepsForm.AddSubStep(string.Format("Novi čvor N {0} je lijevo dijete od P {1}. Obavlja se desna rotacija N {0} oko P {1}.",
                                    newNode, parent));
                                grandparent.rightNode = newNode;
                                FixParent(grandparent.rightNode, grandparent);

                                parent.leftNode = newNode.rightNode;
                                FixParent(parent.leftNode, parent);
                                newNode.rightNode = parent;
                                FixParent(newNode.rightNode, newNode);
                                stepsForm.AddSubStep(string.Format("N {0} postaje P {1}.",
                                    newNode, parent));
                                newNode = parent;
                            }
                            RBTreeNode tempParent = newNode.parentNode;
                            RBTreeNode tempGrandparent = tempParent.parentNode;
                            RBTreeNode tempGrandGrandparent = tempGrandparent.parentNode;
                            stepsForm.AddSubStep(string.Format("Obavlja se lijeva rotacija roditelja od N p(N) {0} oko djeda od N g(N) {1}.",
                                tempParent, tempGrandparent));
                            Rotation(newNode.parentNode, newNode.parentNode.parentNode, false);
                            stepsForm.AddSubStep(string.Format("P {0} postaje crn, G {1} postaje crven.",
                                newNode.parentNode, newNode.parentNode.parentNode));
                            if (newNode.parentNode != null)
                            {
                                newNode.parentNode.isRed = false;
                            }
                            grandparent.isRed = true;
                        }
                    }
                }
                RBTreeNode node = parent;
                while (node.parentNode != null)
                {
                    node = node.parentNode;
                }
                if (node.isRed)
                {
                    stepsForm.AddSubStep(string.Format("Korijen {0} postaje crn.", root));
                    node.isRed = false;
                }
                

            }

        }

        private void InsertIntoTree(int value)
        {
            int currentLevel = 0;
            RBTreeNode node = root;
            while (node != null)
            {
                currentLevel++;
                if (value < node.value)
                {
                    if (node.leftNode == null)
                    {
                        if (currentLevel > level)
                        {
                            level = currentLevel;
                        }
                        node.leftNode = newNode;
                        FixParent(node.leftNode, node);
                        break;
                    }
                    else
                    {
                        node = node.leftNode;
                    }
                }
                else
                {
                    if (node.rightNode == null)
                    {
                        if (currentLevel > level)
                        {
                            level = currentLevel;
                        }
                        node.rightNode = newNode;
                        FixParent(node.rightNode, node);
                        break;
                    }
                    else
                    {
                        node = node.rightNode;
                    }
                }
            }
        }

        private void Rotation(RBTreeNode rotated, RBTreeNode centered, Boolean leftSide)
        {
            RBTreeNode parentCentered = centered.parentNode;
            // p(N) == root
            if (parentCentered == null)
            {
                if (leftSide)
                {
                    // g(N).left = p(N).right
                    centered.leftNode = rotated.rightNode;
                    FixParent(centered.leftNode, centered);
                    // p(N).right = g(N)
                    rotated.rightNode = centered;
                    FixParent(rotated.rightNode, rotated);
                }
                else
                {
                    // g(N).right = p(N).left
                    centered.rightNode = rotated.leftNode;
                    FixParent(centered.rightNode, centered);
                    // p(N).left = g(N)
                    rotated.leftNode = centered;
                    FixParent(rotated.leftNode, rotated);
                }
          
                root = rotated;
                rotated.parentNode = parentCentered;

            }
            else if (leftSide)
            {
                if (parentCentered.leftNode == centered)
                {
                    // p(g(N)).left = p(N)
                    parentCentered.leftNode = rotated;
                    FixParent(parentCentered.leftNode, parentCentered);
                    // g(N).left = p(N).right
                    centered.leftNode = rotated.rightNode;
                    FixParent(centered.leftNode, centered);
                    // p(N).right = g(N)
                    rotated.rightNode = centered;
                    FixParent(rotated.rightNode, rotated);
                }
                else
                {
                    // p(g(N)).right = p(N)
                    parentCentered.rightNode = rotated;
                    FixParent(parentCentered.rightNode, parentCentered);
                    // g(N).left = p(N).right
                    centered.leftNode = rotated.rightNode;
                    FixParent(centered.leftNode, centered);
                    // p(N).right = g(N)
                    rotated.rightNode = centered;
                    FixParent(rotated.rightNode, rotated);
                }
            }
            else
            {
                if (parentCentered.rightNode == centered)
                {
                    // p(g(N)).right = p(N)
                    parentCentered.rightNode = rotated;
                    FixParent(parentCentered.rightNode, parentCentered);
                    // g(N).right = p(N).left
                    centered.rightNode = rotated.leftNode;
                    FixParent(centered.rightNode, centered);
                    // p(N).left = g(N)
                    rotated.leftNode = centered;
                    FixParent(rotated.leftNode, rotated);
                }
                else
                {
                    // p(g(N)).left = p(N)
                    parentCentered.leftNode = rotated;
                    FixParent(parentCentered.leftNode, parentCentered);
                    // g(N).right = p(N).left
                    centered.rightNode = rotated.leftNode;
                    FixParent(centered.rightNode, centered);
                    // p(N).left = g(N)
                    rotated.leftNode = centered;
                    FixParent(rotated.leftNode, rotated);
                }
            }
        }

        private void FixParent(RBTreeNode childNode, RBTreeNode parentNode)
        {
            if (childNode != null)
            {
                childNode.parentNode = parentNode;
            }
        }

        private Boolean RemoveFromTree(int value)
        {
            RBTreeNode deleteNode = FindValue(value);
            if (deleteNode == null) return false;
            if (deleteNode == root && deleteNode.leftNode == null && deleteNode.rightNode == null)
            {
                root = null;
                return false;
            }
            deleteChild = null;
            if (deleteNode == null) return true;
            RBTreeNode replaceNode = FindReplace(deleteNode);
            Boolean replaceColor = replaceNode.isRed;
            if (replaceNode == deleteNode)
            {
                // delnode != root
                if (deleteNode.parentNode != null)
                {
                    deleteChild = new RBTreeNode(-1, false);
                    deleteChild.isNullLeaf = true;
                    deleteChild.parentNode = deleteNode.parentNode;
                    if (deleteNode.parentNode.leftNode == deleteNode)
                    {
                        deleteNode.parentNode.leftNode = deleteChild;
                    }
                    else
                    {
                        deleteNode.parentNode.rightNode = deleteChild;
                    }
                }
                deleteNode = null;
                return replaceColor;
            }
            if (replaceNode.value <= deleteNode.value)
            {
                if (deleteNode.leftNode == replaceNode)
                {
                    deleteNode.leftNode = replaceNode.leftNode;
                    if (deleteNode.leftNode != null)
                    {
                        deleteNode.leftNode.parentNode = deleteNode;
                        deleteChild = deleteNode.leftNode;
                    }
                    else
                    {
                        deleteChild = new RBTreeNode(-1, false);
                        deleteChild.isNullLeaf = true;
                        deleteNode.leftNode = deleteChild;
                    }
                    deleteChild.parentNode = deleteNode;
                    deleteNode.value = replaceNode.value;
                    replaceNode = null;
                }
                else
                {
                    RBTreeNode parentOfReplace = replaceNode.parentNode;
                    parentOfReplace.rightNode = replaceNode.leftNode;

                    if (parentOfReplace.rightNode == null)
                    {
                        deleteChild = new RBTreeNode(-1, false);
                        deleteChild.isNullLeaf = true;
                        parentOfReplace.rightNode = deleteChild;
                        deleteChild.parentNode = parentOfReplace;
                    }
                    else
                    {
                        if (parentOfReplace.rightNode.leftNode != null)
                        {
                            parentOfReplace.rightNode.leftNode.parentNode = parentOfReplace;
                            deleteChild = parentOfReplace.rightNode.leftNode;
                        }
                        else
                        {
                            deleteChild = new RBTreeNode(-1, false);
                            deleteChild.isNullLeaf = true;
                            parentOfReplace.rightNode.leftNode = deleteChild;
                            deleteChild.parentNode = parentOfReplace;
                        }
                    }


                    deleteNode.value = replaceNode.value;
                    replaceNode = null;
                }
            }
            else
            {
                if (deleteNode.rightNode == replaceNode)
                {
                    deleteNode.rightNode = replaceNode.rightNode;
                    if (deleteNode.rightNode != null)
                    {
                        deleteChild = deleteNode.rightNode;
                    }
                    else
                    {
                        deleteChild = new RBTreeNode(-1, false);
                        deleteChild.isNullLeaf = true;
                        deleteNode.rightNode = deleteChild;
                    }
                    deleteChild.parentNode = deleteNode;
                    deleteNode.value = replaceNode.value;
                    replaceNode = null;
                }
                else
                {
                    RBTreeNode parentOfReplace = replaceNode.parentNode;
                    parentOfReplace.leftNode = replaceNode.rightNode;

                    if (parentOfReplace.leftNode == null)
                    {
                        deleteChild = new RBTreeNode(-1, false);
                        deleteChild.isNullLeaf = true;
                        parentOfReplace.leftNode = deleteChild;
                        deleteChild.parentNode = parentOfReplace;
                    }
                    else
                    {
                        if (parentOfReplace.leftNode.rightNode != null)
                        {
                            parentOfReplace.leftNode.rightNode.parentNode = parentOfReplace;
                            deleteChild = parentOfReplace.leftNode.rightNode;
                        }
                        else
                        {
                            deleteChild = new RBTreeNode(-1, false);
                            deleteChild.isNullLeaf = true;
                            parentOfReplace.leftNode.rightNode = deleteChild;
                            deleteChild.parentNode = parentOfReplace;
                        }
                    }


                    deleteNode.value = replaceNode.value;
                    replaceNode = null;
                }
            }
            return replaceColor;
        }

        private RBTreeNode FindReplace(RBTreeNode deleteNode)
        {
            RBTreeNode replaceNode = deleteNode;
            if (deleteNode.leftNode != null)
            {
                RBTreeNode node = deleteNode.leftNode;
                while (node.rightNode != null)
                {
                    node = node.rightNode;
                }
                replaceNode = node;
            }
            else if (deleteNode.rightNode != null)
            {
                RBTreeNode node = deleteNode.rightNode;

                while (node.leftNode != null)
                {
                    node = node.leftNode;
                }
                replaceNode = node;
            }
            return replaceNode;
        }

        private RBTreeNode FindValue(int value)
        {
            RBTreeNode node = root;
            while (node != null)
            {
                if (value == node.value)
                {
                    break;
                }
                if (value < node.value)
                {
                    node = node.leftNode;
                }
                else
                {
                    node = node.rightNode;
                }
            }
            return node;
        }

        public void RemoveElement(int value)
        {
            stepsForm.AddStep("Briše se čvor s vrijednošću " + value + ".");
            Boolean replaceColorIsRed = RemoveFromTree(value);
            if (deleteChild == null) return;
            if (root == null) return;

            if (deleteChild == null || replaceColorIsRed == true)
            {
                if (deleteChild != null && deleteChild.isNullLeaf)
                {
                    if (deleteChild.parentNode.leftNode == deleteChild)
                    {
                        deleteChild.parentNode.leftNode = null;
                    }
                    else
                    {
                        deleteChild.parentNode.rightNode = null;
                    }
                    deleteChild = null;
                }
                return;
            }
            while (deleteChild != root && !deleteChild.isRed)
            {
                stepsForm.AddSubStep(string.Format("Dijete N {0} je crne boje.",deleteChild));
                if (deleteChild == deleteChild.parentNode.leftNode)
                {
                    stepsForm.AddSubStep(string.Format("N {0} je lijevo dijete roditelja P {1}.",
                        deleteChild, deleteChild.parentNode));
                    RBTreeNode sibling = deleteChild.parentNode.rightNode;
                    if (sibling.isRed)
                    {
                        stepsForm.AddSubStep(string.Format("S {0}, drugo dijete od P {1} je crvene boje, boji se u crnu.",
                            sibling, deleteChild.parentNode));
                        sibling.isRed = false;
                        stepsForm.AddSubStep(string.Format("Roditelj od N P {0} se boji u crvenu.",
                            deleteChild.parentNode));
                        deleteChild.parentNode.isRed = true;

                        stepsForm.AddSubStep(string.Format("Obavlja se lijeva rotacija S {0} oko P {1}.",
                            sibling, deleteChild.parentNode));
                        deleteChild.parentNode.rightNode = sibling.leftNode;
                        sibling.leftNode.parentNode = deleteChild.parentNode;
                        sibling.leftNode = deleteChild.parentNode;
                        if (deleteChild.parentNode == root)
                        {
                            root = sibling;
                            sibling.parentNode = null;
                        }
                        else
                        {
                            if (deleteChild.parentNode == deleteChild.parentNode.parentNode.leftNode)
                            {
                                deleteChild.parentNode.parentNode.leftNode = sibling;
                            }
                            else
                            {
                                deleteChild.parentNode.parentNode.rightNode = sibling;
                            }
                            sibling.parentNode = deleteChild.parentNode.parentNode;
                        }
                        deleteChild.parentNode.parentNode = sibling;

                    }

                    sibling = deleteChild.parentNode.rightNode;
                    if ((sibling.leftNode == null || !sibling.leftNode.isRed) && (sibling.rightNode == null || !sibling.rightNode.isRed))
                    {
                        stepsForm.AddSubStep(string.Format("Djeca od S {0} su crna. S {0} se boji u crvenu.",
                            sibling));
                        sibling.isRed = true;
                        if (deleteChild.isNullLeaf)
                        {
                            if (deleteChild.parentNode.leftNode == deleteChild)
                            {
                                deleteChild.parentNode.leftNode = null;
                            }
                            else
                            {
                                deleteChild.parentNode.rightNode = null;
                            }
                        }

                        stepsForm.AddSubStep(string.Format("Roditelj od N P {0} postaje novi N.",
                            deleteChild.parentNode));
                        deleteChild = deleteChild.parentNode;
                    }
                    else
                    {
                        if (sibling.rightNode == null || !sibling.rightNode.isRed)
                        {
                            stepsForm.AddSubStep(string.Format("Desno dijete od S SR {0} je crne boje. Lijevo dijete od S SL {1} se boji u crnu.",
                                sibling.rightNode, sibling.leftNode));
                            sibling.leftNode.isRed = false;
                            stepsForm.AddSubStep(string.Format("S {0} se boji u crvenu.", sibling));
                            sibling.isRed = true;
                            stepsForm.AddSubStep(string.Format("Obavlja se desna rotacija SL {0} oko S {1}.",
                                sibling.leftNode, sibling));

                            deleteChild.parentNode.rightNode = sibling.leftNode;
                            sibling.leftNode.parentNode = deleteChild.parentNode;

                            sibling.leftNode = sibling.leftNode.rightNode;
                            FixParent(sibling.leftNode, sibling);

                            deleteChild.parentNode.rightNode.rightNode = sibling;
                            sibling.parentNode = deleteChild.parentNode.rightNode; 
                        }
                        sibling = deleteChild.parentNode.rightNode;
                        stepsForm.AddSubStep(string.Format("S {0} se boji u boju od roditelja P {1}.",
                            sibling, deleteChild.parentNode));
                        sibling.isRed = deleteChild.parentNode.isRed;
                        stepsForm.AddSubStep(string.Format("P {0} se boji u crnu.",
                            deleteChild.parentNode));
                        deleteChild.parentNode.isRed = false;
                        stepsForm.AddSubStep(string.Format("Desno dijete od S SR {0} se boji u crnu.",
                            sibling.rightNode));
                        if (sibling.rightNode != null)
                        {
                            sibling.rightNode.isRed = false;
                        }

                        stepsForm.AddSubStep(string.Format("Obavlja se lijeva rotacija S {0} oko P {1}.",
                            sibling, deleteChild.parentNode));
                        deleteChild.parentNode.rightNode = sibling.leftNode;
                        FixParent(deleteChild.parentNode.rightNode, deleteChild.parentNode);

                        if (deleteChild.parentNode == root)
                        {
                            root = sibling;
                            sibling.parentNode = null;
                        }
                        else
                        {
                            if (deleteChild.parentNode == deleteChild.parentNode.parentNode.leftNode)
                            {
                                deleteChild.parentNode.parentNode.leftNode = sibling;
                            }
                            else
                            {
                                deleteChild.parentNode.parentNode.rightNode = sibling;
                            }
                            sibling.parentNode = deleteChild.parentNode.parentNode;
                        }
                        

                        sibling.leftNode = deleteChild.parentNode;
                        deleteChild.parentNode.parentNode = sibling;
                        stepsForm.AddSubStep(string.Format("Korijen {0} postaje novi N.",
                            root));

                        if (deleteChild.isNullLeaf)
                        {
                            if (deleteChild.parentNode.leftNode == deleteChild)
                            {
                                deleteChild.parentNode.leftNode = null;
                            }
                            else
                            {
                                deleteChild.parentNode.rightNode = null;
                            }
                        }
                        deleteChild = root;
                    }
                }
                else
                {
                    stepsForm.AddSubStep(string.Format("N {0} je desno dijete roditelja P {1}.",
                        deleteChild, deleteChild.parentNode));
                    RBTreeNode sibling = deleteChild.parentNode.leftNode;
                    if (sibling.isRed)
                    {
                        stepsForm.AddSubStep(string.Format("S {0}, drugo dijete od P {1} je crvene boje, boji se u crnu.",
                            sibling, deleteChild.parentNode));
                        sibling.isRed = false;
                        stepsForm.AddSubStep(string.Format("Roditelj od N P {0} se boji u crvenu.",
                            deleteChild.parentNode));
                        deleteChild.parentNode.isRed = true;

                        stepsForm.AddSubStep(string.Format("Obavlja se desna rotacija S {0} oko P {1}.",
                            sibling, deleteChild.parentNode));
                        deleteChild.parentNode.leftNode = sibling.rightNode;
                        sibling.rightNode.parentNode = deleteChild.parentNode;
                        sibling.rightNode = deleteChild.parentNode;
                        if (deleteChild.parentNode == root)
                        {
                            root = sibling;
                            sibling.parentNode = null;
                        }
                        else
                        {
                            if (deleteChild.parentNode == deleteChild.parentNode.parentNode.rightNode)
                            {
                                deleteChild.parentNode.parentNode.rightNode = sibling;
                            }
                            else
                            {
                                deleteChild.parentNode.parentNode.leftNode = sibling;
                            }
                            sibling.parentNode = deleteChild.parentNode.parentNode;
                        }
                        deleteChild.parentNode.parentNode = sibling;

                    }

                    sibling = deleteChild.parentNode.leftNode;
                    if ((sibling.leftNode == null || !sibling.leftNode.isRed) && (sibling.rightNode == null || !sibling.rightNode.isRed))
                    {
                        stepsForm.AddSubStep(string.Format("Djeca od S {0} su crna. S {0} se boji u crvenu.",
                            sibling));
                        sibling.isRed = true;
                        if (deleteChild.isNullLeaf)
                        {
                            if (deleteChild.parentNode.leftNode == deleteChild)
                            {
                                deleteChild.parentNode.leftNode = null;
                            }
                            else
                            {
                                deleteChild.parentNode.rightNode = null;
                            }
                        }

                        stepsForm.AddSubStep(string.Format("Roditelj od N P {0} postaje novi N.",
                            deleteChild.parentNode));
                        deleteChild = deleteChild.parentNode;
                    }
                    else
                    {
                        if (sibling.leftNode == null || !sibling.leftNode.isRed)
                        {
                            stepsForm.AddSubStep(string.Format("Lijevo dijete od S SL {0} je crne boje. Desno dijete od S SR {1} se boji u crnu.",
                                sibling.leftNode, sibling.rightNode));
                            sibling.rightNode.isRed = false;
                            stepsForm.AddSubStep(string.Format("S {0} se boji u crvenu.", sibling));
                            sibling.isRed = true;
                            stepsForm.AddSubStep(string.Format("Obavlja se lijeva rotacija SR {0} oko S {1}.",
                                sibling.rightNode, sibling));

                            deleteChild.parentNode.leftNode = sibling.rightNode;
                            FixParent(deleteChild.parentNode.leftNode, deleteChild.parentNode);

                            sibling.rightNode = sibling.rightNode.leftNode;
                            FixParent(sibling.rightNode, sibling);
                            deleteChild.parentNode.leftNode.leftNode = sibling;
                            sibling.parentNode = deleteChild.parentNode.leftNode;
                        }
                        sibling = deleteChild.parentNode.leftNode;
                        stepsForm.AddSubStep(string.Format("S {0} se boji u boju od roditelja P {1}.",
                            sibling, deleteChild.parentNode));
                        sibling.isRed = deleteChild.parentNode.isRed;
                        stepsForm.AddSubStep(string.Format("P {0} se boji u crnu.",
                            deleteChild.parentNode));
                        deleteChild.parentNode.isRed = false;
                        stepsForm.AddSubStep(string.Format("Lijevo dijete od S SL {0} se boji u crnu.",
                            sibling.leftNode));
                        if (sibling.leftNode != null)
                        {
                            sibling.leftNode.isRed = false;
                        }

                        stepsForm.AddSubStep(string.Format("Obavlja se desna rotacija S {0} oko P {1}.",
                            sibling, deleteChild.parentNode));
                        deleteChild.parentNode.leftNode = sibling.rightNode;
                        FixParent(deleteChild.parentNode.leftNode, deleteChild.parentNode);

                        if (deleteChild.parentNode == root)
                        {
                            root = sibling;
                            sibling.parentNode = null;
                        }
                        else
                        {
                            if (deleteChild.parentNode == deleteChild.parentNode.parentNode.rightNode)
                            {
                                deleteChild.parentNode.parentNode.rightNode = sibling;
                            }
                            else
                            {
                                deleteChild.parentNode.parentNode.leftNode = sibling;
                            }
                            sibling.parentNode = deleteChild.parentNode.parentNode;
                        }

                        sibling.rightNode = deleteChild.parentNode;
                        deleteChild.parentNode.parentNode = sibling;
                        stepsForm.AddSubStep(string.Format("Korijen {0} postaje novi N.",
                            root));

                        if (deleteChild.isNullLeaf)
                        {
                            if (deleteChild.parentNode.rightNode == deleteChild)
                            {
                                deleteChild.parentNode.rightNode = null;
                            }
                            else
                            {
                                deleteChild.parentNode.leftNode = null;
                            }
                        }
                        deleteChild = root;
                    }
                }
            }
            stepsForm.AddSubStep(string.Format("N {0} se boji u crnu.", deleteChild));
            deleteChild.isRed = false;
        }

        private int calculatePadding(int treeLevel)
        {
            // rezultat rekurzivne relacije:
            return (RBTree.DefaultLength / 2) * (int) Math.Pow(2, treeLevel+1) - (RBTree.DefaultLength / 2);
        }

        public override string ToString()
        {
            List<RBTreeNode> previousNodes = new List<RBTreeNode>() { root };
            List<RBTreeNode> currentNodes = new List<RBTreeNode>();
            int currentLevel = level;
            int defaultLength = RBTree.DefaultLength;
            int previousPadding;
            int padding = previousPadding = calculatePadding(currentLevel);
            string treeRows = "";
            string treeRow = string.Format("{0, " + (padding + defaultLength) + "}", root);
            treeRows += treeRow + "\n";
            while (currentLevel-- > 0)
            {
                treeRow = "";
                string connectionRow = "";
                padding = calculatePadding(currentLevel);
                Boolean first = true;
                currentNodes.Clear();
                currentNodes.AddRange(previousNodes);
                previousNodes.Clear();
                int wireLength;
                foreach (RBTreeNode node in currentNodes)
                {
                    if (node == null)
                    {
                        treeRow += string.Format("{0, " + (padding + defaultLength) + "}", "");
                        connectionRow += string.Format("{0, " + (padding + defaultLength) + "}", "");
                        previousNodes.Add(null);

                        if (first)
                        {
                            first = false;
                            padding *= 2;
                            previousPadding *= 2;
                        }
                        //connectionRow += string.Format("{0, " + (padding + defaultLength) + "}", "");
                        treeRow += string.Format("{0, " + (padding + defaultLength) + "}", "");
                        connectionRow += string.Format("{0, " + (padding + defaultLength) + "}", "");
                        previousNodes.Add(null);
                    }
                    else
                    {
                        int nodeLength = node.ToString().Length;

                        int leftNodeLength = 0;
                        wireLength = 0;
                        if (node.leftNode != null)
                        {
                            leftNodeLength = node.leftNode.ToString().Length;
                        }
                        treeRow += string.Format("{0, " + (padding + defaultLength) + "}", node.leftNode);
                        connectionRow += string.Format("{0, " + (padding + defaultLength) + "}", "");
                        string connection = "";
                        if (node.leftNode != null) connection = " ";

                        //connectionRow += string.Format("{0, " + (padding + defaultLength - leftNodeLength / 2) + "}", connection);
                        //connectionRow += string.Format("{0, " + (leftNodeLength / 2) + "}", "");


                        //connectionRow += string.Format("{0, " + (padding + defaultLength) + "}", connection);
                        previousNodes.Add(node.leftNode);
                        if (first)
                        {
                            first = false;
                            padding *= 2;
                            previousPadding *= 2;
                        }
                        wireLength = padding / 2 - 1;
                        if (wireLength > 0 && node.leftNode != null)
                        {
                            connectionRow += new string('_', wireLength);
                        }
                        if (node.leftNode != null)
                        {
                            connectionRow += "/";
                        }
                        else
                        {
                            connectionRow += string.Format("{0, " + (wireLength + 1) + "}", "");
                        }

                        /*
                        else
                        {
                            //connectionRow += string.Format("{0, " + (wireLength + 1) + "}", "");
                        }
                        */
                        //connectionRow += new string('-', wireLength) +"/";

                        int rightNodeLength = 0;
                        if (node.rightNode != null)
                        {
                            rightNodeLength = node.rightNode.ToString().Length;
                        }

                        treeRow += string.Format("{0, " + (padding + defaultLength) + "}", node.rightNode);

                        if (node.rightNode != null)
                        {
                            connectionRow += "\\";
                            wireLength = padding / 2 - 1 + RBTree.DefaultLength - rightNodeLength;
                            if (wireLength > 0)
                            {
                                connectionRow += new string('_', wireLength);
                            }
                            connectionRow += string.Format("{0, " + (rightNodeLength) + "}", "");
                        }
                        else
                        {
                            connectionRow += string.Format("{0, " + (padding / 2 - 1 + RBTree.DefaultLength) + "}", "");
                        }



                        connection = "";
                        if (node.rightNode != null) connection = " ";
                        if (wireLength > 0 && node.rightNode != null)
                        {
                            connection = "\\" + new string('_', wireLength) + connection;
                        }
                        //connectionRow += string.Format("{0, " + (padding/2 + defaultLength - rightNodeLength/2) + "}", connection);
                        //connectionRow += string.Format("{0, " + (rightNodeLength/2) + "}", "");
                        previousNodes.Add(node.rightNode);

                    }


                }

                treeRows += connectionRow + "\n";
                treeRows += treeRow + "\n";
                previousPadding = padding / 2;
            }
            return treeRows;
        }
    }
}
