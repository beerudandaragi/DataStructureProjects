﻿using System;
using System.Collections.Generic;
using System.Text;
//this is the node and it contais object type to store data and next it holds the next location of next data
public class Node
{
    public Node Next;
    public Object data;
    //constructor for saving the data to node.data
    public Node(Object Val)
    {
        data = Val;
    }
}