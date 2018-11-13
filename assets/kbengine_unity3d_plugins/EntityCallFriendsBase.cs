/*
	Generated by KBEngine!
	Please do not modify this file!
	
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/Friends.def
	public class EntityBaseEntityCall_FriendsBase : EntityCall
	{
		public UInt16 entityComponentPropertyID = 0;

		public EntityBaseEntityCall_FriendsBase(UInt16 ecpID, Int32 eid) : base(eid, "Friends")
		{
			entityComponentPropertyID = ecpID;
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_BASE;
		}

		public void reqAcceptSteal(UInt64 arg1, UInt64 arg2, Byte arg3)
		{
			Bundle pBundle = newCall("reqAcceptSteal", entityComponentPropertyID);
			if(pBundle == null)
				return;

			bundle.writeUint64(arg1);
			bundle.writeUint64(arg2);
			bundle.writeUint8(arg3);
			sendCall(null);
		}

		public void reqAcceptYaoShu(UInt64 arg1, UInt64 arg2, Byte arg3)
		{
			Bundle pBundle = newCall("reqAcceptYaoShu", entityComponentPropertyID);
			if(pBundle == null)
				return;

			bundle.writeUint64(arg1);
			bundle.writeUint64(arg2);
			bundle.writeUint8(arg3);
			sendCall(null);
		}

		public void reqAllSysMessage(string arg1)
		{
			Bundle pBundle = newCall("reqAllSysMessage", entityComponentPropertyID);
			if(pBundle == null)
				return;

			bundle.writeUnicode(arg1);
			sendCall(null);
		}

		public void reqApplySteal(UInt64 arg1, UInt64 arg2, string arg3)
		{
			Bundle pBundle = newCall("reqApplySteal", entityComponentPropertyID);
			if(pBundle == null)
				return;

			bundle.writeUint64(arg1);
			bundle.writeUint64(arg2);
			bundle.writeUnicode(arg3);
			sendCall(null);
		}

		public void reqApplyYaoShu(UInt64 arg1)
		{
			Bundle pBundle = newCall("reqApplyYaoShu", entityComponentPropertyID);
			if(pBundle == null)
				return;

			bundle.writeUint64(arg1);
			sendCall(null);
		}

		public void reqCheckCanSteal(List<UInt64> arg1, UInt64 arg2)
		{
			Bundle pBundle = newCall("reqCheckCanSteal", entityComponentPropertyID);
			if(pBundle == null)
				return;

			((DATATYPE_AnonymousArray_69)EntityDef.id2datatypes[69]).addToStreamEx(bundle, arg1);
			bundle.writeUint64(arg2);
			sendCall(null);
		}

		public void reqCheckMessageCanSteal(UInt64 arg1, UInt64 arg2, UInt64 arg3)
		{
			Bundle pBundle = newCall("reqCheckMessageCanSteal", entityComponentPropertyID);
			if(pBundle == null)
				return;

			bundle.writeUint64(arg1);
			bundle.writeUint64(arg2);
			bundle.writeUint64(arg3);
			sendCall(null);
		}

		public void reqFriendList()
		{
			Bundle pBundle = newCall("reqFriendList", entityComponentPropertyID);
			if(pBundle == null)
				return;

			sendCall(null);
		}

		public void reqOpenFriendList()
		{
			Bundle pBundle = newCall("reqOpenFriendList", entityComponentPropertyID);
			if(pBundle == null)
				return;

			sendCall(null);
		}

		public void reqReadMessage()
		{
			Bundle pBundle = newCall("reqReadMessage", entityComponentPropertyID);
			if(pBundle == null)
				return;

			sendCall(null);
		}

		public void reqSteal(UInt64 arg1, string arg2, UInt64 arg3)
		{
			Bundle pBundle = newCall("reqSteal", entityComponentPropertyID);
			if(pBundle == null)
				return;

			bundle.writeUint64(arg1);
			bundle.writeUnicode(arg2);
			bundle.writeUint64(arg3);
			sendCall(null);
		}

		public void reqYaoShu(UInt64 arg1, UInt64 arg2)
		{
			Bundle pBundle = newCall("reqYaoShu", entityComponentPropertyID);
			if(pBundle == null)
				return;

			bundle.writeUint64(arg1);
			bundle.writeUint64(arg2);
			sendCall(null);
		}

		public void reqYaoShuStatus()
		{
			Bundle pBundle = newCall("reqYaoShuStatus", entityComponentPropertyID);
			if(pBundle == null)
				return;

			sendCall(null);
		}

	}

	public class EntityCellEntityCall_FriendsBase : EntityCall
	{
		public UInt16 entityComponentPropertyID = 0;

		public EntityCellEntityCall_FriendsBase(UInt16 ecpID, Int32 eid) : base(eid, "Friends")
		{
			entityComponentPropertyID = ecpID;
			className = "Friends";
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_CELL;
		}

	}
	}
