﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EasyExcel.
//     Runtime Version: 4.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using UnityEngine;
using EasyExcel;

namespace SheetData
{
	[Serializable]
	public class GameDataTable_Client : EERowData
	{
		[EEKeyField]
		[SerializeField]
		private long _UID;
		public long UID { get { return _UID; } set{_UID=value; } }

		[SerializeField]
		private string _GameDataID;
		public string GameDataID { get { return _GameDataID; } set{_GameDataID=value; } }

		[SerializeField]
		private long _GameDataValue;
		public long GameDataValue { get { return _GameDataValue; } set{_GameDataValue=value; } }

		[SerializeField]
		private int _GameDataCount;
		public int GameDataCount { get { return _GameDataCount; } set{_GameDataCount=value; } }

		[SerializeField]
		private float _GameDataRatio;
		public float GameDataRatio { get { return _GameDataRatio; } set{_GameDataRatio=value; } }


		public GameDataTable_Client()
		{
		}

#if UNITY_EDITOR
		public GameDataTable_Client(List<List<string>> sheet, int row, int column)
		{
			TryParse(sheet[row][column++], out _UID);
			TryParse(sheet[row][column++], out _GameDataID);
			TryParse(sheet[row][column++], out _GameDataValue);
			TryParse(sheet[row][column++], out _GameDataCount);
			TryParse(sheet[row][column++], out _GameDataRatio);
		}
#endif
		public override void OnAfterSerialized()
		{
		}
	}

	public class GameDataTable_GameDataTable_Client : EERowDataCollection
	{
		
		public List<GameDataTable_Client> elements = new List<GameDataTable_Client>();

		public override void AddData(EERowData data)
		{
			elements.Add(data as GameDataTable_Client);
		}

		public override int GetDataCount()
		{
			return elements.Count;
		}

	
public List<GameDataTable_Client> OnGetAllData()
		{		
return elements;
		}		public override EERowData GetData(int index)
		{
			return elements[index];
		}

		public override void OnAfterSerialized()
		{
			foreach (var element in elements)
				element.OnAfterSerialized();
		}
	}
}