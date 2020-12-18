﻿using System;
using System.CodeDom.Compiler;
using System.Drawing;
using System.ServiceModel;

[GeneratedCode("System.ServiceModel", "3.0.0.0")]
public interface ISchemeCallback
{
	[OperationContract(IsOneWay = true)]
	void ReceiveObjectOnLineOnChange(int idBase, bool on, int[] idConsumers, Guid databaseGuid);

	[OperationContract(IsOneWay = true)]
	void ReceiveStateOnLine(int idBase, int idRelation, int numBranch, double delta, int typeState, bool add, int idLineState, int[] idConsumers, Guid databaseGuid);

	[OperationContract(IsOneWay = true)]
	void ReceiveNodeChange(int idBase, int idAction, string text, PointF point, Color color);

	[OperationContract(IsOneWay = true)]
	void UserEnter(string clientID);

	[OperationContract(IsOneWay = true)]
	void UserLeave(string clientID);
}