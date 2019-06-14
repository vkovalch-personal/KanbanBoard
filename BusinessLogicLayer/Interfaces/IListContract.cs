﻿using BusinessLogicLayer.DTO;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BusinessLogicLayer.Interfaces.Contracts
{
	[ServiceContract]
	public interface IListContract
	{
		[OperationContract]
		void AddList(ListDTO list);

		[OperationContract]
		ListDTO FindListById(int id);

		[OperationContract]
		IEnumerable<ListDTO> GetLists();

		[OperationContract]
		IEnumerable<ListDTO> GetLists(Func<ListDTO, bool> predicate);

		[OperationContract]
		void RemoveList(ListDTO list);

		[OperationContract]
		void UpdateList(ListDTO list);
	}
}