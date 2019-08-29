using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySortTree
{
    //定义二叉树节点结构
    public class TreeNode
    {
        public int data;//the value of the node
        public int level;//The level of the point in the tree;the root's level is 0;
        public TreeNode left;//the pillow to the left child
        public TreeNode right;//the pillow to the right child
        public int Data
        {
            set { data = value; }
            get { return data; }
        }

        public TreeNode LChild
        {
            set { left = value; }
            get { return left; }
        }

        public TreeNode RChild
        {
            set { right = value; }
            get { return right; }
        }
        public TreeNode(int values)
        {
            data = values;
            left = null;
            right = null;
        }
    };
    //定义整个二叉树结构
    class BinaryTree
    {
        public TreeNode root;//the root node
        public TreeNode Root
        {
            set { root = value; }
            get { return root; }
        }
        private int[] datas;
        public BinaryTree(int[] vals)
        {
            datas = vals;
            int length = vals.Length;
            int i = 0;
            for (i = 0; i < length; i++)
            {
                InsertNode(vals[i]);
            }
        }
        //insert the new node
        public void InsertNode(int data)
        {
            TreeNode node = new TreeNode(data);
            //root is null
            if (root == null)
            {
                root = node;
                return;
            }
            TreeNode cur = root;
            //loop to find the proper point to plugin
            while (true)
            {
                //left-child
                if (cur.data > data)
                {
                    if (cur.left == null)
                    {//cur is the LeftChild
                        cur.left = node;
                        return;
                    }
                    cur = cur.left;
                }
                else
                {//rightChild                    
                    if (cur.right == null)
                    {//cur is theRightChild
                        cur.right = node;
                        return;
                    }
                    cur = cur.right;
                }
            }
        }
        //search the node which value is data
        public TreeNode SearchData(int data)
        {
            TreeNode cur = root;
            if (root.data==data)//if the answer is the root than we return directly
                return root;
            while (cur.data !=data)
            {//loop to find the proper point
                
                if (cur.data > data)
                {//To search the answer in the leftChildTree
                    cur = cur.left;
                    if (cur == null)//if the last one is null than we return null
                        return null;
                }
                else
                {//To search the answer in the RightChildTree
                    cur = cur.right;
                    if (cur == null)//if the last one is null than we return null
                        return null;
                }
            }
            return cur;
        }
        /*
            二叉排序树的删除
            1、删除的是叶子节点
                直接删除
            2、删除的是只有一个子节点
                叶子节点直接继承父节点位置
            3、删除的节点有左右节点
                以中序遍历的前驱和后继节点替换，下面的代码演示是以后继节点替换
            4->返回0代表没找到，1代表找到了并删除了它
         */
        public int DeleteNode(int data)
        {
            if (root != null)
            {
                TreeNode parent = root;
                TreeNode cur = root;
                //To Find the point
                while (cur.data!=data)
                {
                    parent = cur;
                    if (cur.data > data)//if the point is in the LeftChildTree
                    {
                        cur = cur.left;
                        if (cur == null)//Not find the answer
                        {
                            return 0;
                        }
                    }
                    else//the point is in the RightChildTree
                    {
                        cur = cur.right;
                        if (cur == null)//Not find the answer
                        {
                            return 0;
                        }
                    }
                }


                if (cur == null)//Not find the answer
                {
                    return 0;
                }
                else
                {//if we find the answer,than 
                    if (cur.left == null && cur.right == null)//the left and right child both are null
                    {
                        if (cur == root)
                        {
                            root = null;
                        }
                        else if (parent.left == cur)
                        {
                            parent.left = null;
                        }
                        else
                        {
                            parent.right = null;
                        }
                    }
                    else if (cur.left == null)
                    {
                        if (cur == root)
                        {
                            root = cur.right;
                        }
                        else if (parent.left == cur)
                        {
                            parent.left = cur.right;
                        }
                        else
                        {
                            parent.right = cur.right;
                        }
                    }
                    else if (cur.right == null)
                    {
                        if (cur == root)
                        {
                            root = cur.left;
                        }
                        else if (parent.left == cur)
                        {
                            parent.left = cur.left;
                        }
                        else
                        {
                            parent.right = cur.left;
                        }
                    }
                    else
                    {
                        TreeNode pTemp = cur.left;
                        while (pTemp.right != null)
                        {
                            pTemp = pTemp.right;
                        }
                        pTemp.right = cur.right;
                        if (cur == root)
                        {
                            root = cur.left;
                        }
                        else if (parent.left == cur)
                        {
                            parent.left = cur.left;
                        }
                        else
                        {
                            parent.right = cur.left;
                        }
                    }
                }
            }
            return 1;
        }
        //Print the tree
        //step1:calculate the level of each point
        //step2:print the tree
        private void CalculateLevel(TreeNode t, int i)
        {
            if (t != null)
            {
                t.level = i;
                CalculateLevel(t.left, i + 1);
                CalculateLevel(t.right, i + 1);
            }
        }
        private void RightFirstPrint(TreeNode t, ref string strTemp, int data, int search)
        {
            if (t != null)
            {
                string strFiveSpace = "          ";
                RightFirstPrint(t.right, ref strTemp, data, search);               
                if (t.level != 0)
                {
                    for (int i = 0; i < t.level-1; i++)
                    {
                        strTemp = strTemp + strFiveSpace;
                    }
                    strTemp = strTemp + "          ";
                }

                strTemp = strTemp + t.data.ToString();
                if(search==1 && t.data ==data )
                {
                    strTemp = strTemp + "*";
                }
                strTemp = strTemp + "\r\n";
                RightFirstPrint(t.left, ref strTemp, data, search);
            }
        }
        public void PrintTree(ref string strTemp,int data,int search)
        {
            CalculateLevel(root, 0);
            RightFirstPrint(root, ref strTemp,data,search);
        }
    };
}