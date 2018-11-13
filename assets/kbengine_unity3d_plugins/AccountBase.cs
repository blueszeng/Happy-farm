/*
	Generated by KBEngine!
	Please do not modify this file!
	Please inherit this module, such as: (class Account : AccountBase)
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/Account.def
	// Please inherit and implement "class Account : AccountBase"
	public abstract class AccountBase : Entity
	{
		public EntityBaseEntityCall_AccountBase baseEntityCall = null;
		public EntityCellEntityCall_AccountBase cellEntityCall = null;

		public AVATAR_INFOS_LIST Avatar_List = new AVATAR_INFOS_LIST();
		public virtual void onAvatar_ListChanged(AVATAR_INFOS_LIST oldValue) {}
		public CARD_INFOS_LIST Card_Data = new CARD_INFOS_LIST();
		public virtual void onCard_DataChanged(CARD_INFOS_LIST oldValue) {}
		public FriendsBase Friends = null;
		public LandBase Land = null;
		public PetBase Pet = null;
		public TaskBase Task = null;
		public bagsBase bags = null;

		public abstract void OnAddCardGroup(string arg1); 
		public abstract void OnBattleResult(SByte arg1); 
		public abstract void OnDelCarErr(Byte arg1); 
		public abstract void OnGetKz(CARD_GROUP arg1); 
		public abstract void OnMarcherSum(Int64 arg1); 
		public abstract void battleResultClientDisplay(Int32 arg1, Int32 arg2); 
		public abstract void gotoMain(); 
		public abstract void onAccountCardData(CARD_INFOS_LIST arg1); 
		public abstract void onAddCardGroup(string arg1); 
		public abstract void onBindAccount(string arg1); 
		public abstract void onChangeAvatar(string arg1); 
		public abstract void onChangeData(string arg1, string arg2); 
		public abstract void onData(ACCOUNT_DATA arg1, UInt64 arg2); 
		public abstract void onDiamond(UInt64 arg1); 
		public abstract void onEglod(UInt64 arg1); 
		public abstract void onGetPlayerSum(Int64 arg1); 
		public abstract void onInf(string arg1); 
		public abstract void onInitBattleField(); 
		public abstract void onKglod(UInt64 arg1); 
		public abstract void onMarchMsg(string arg1); 
		public abstract void onMoney(UInt64 arg1); 
		public abstract void onOpeningPackResult(OPEN_PACK_DATA arg1, OPEN_PACK_NAME_DATA arg2); 
		public abstract void onRemoveAvatar(string arg1); 
		public abstract void onReqAvatarList(AVATAR_INFOS_LIST arg1); 
		public abstract void onbuycard(Byte arg1); 

		public AccountBase()
		{
			foreach (System.Reflection.Assembly ass in AppDomain.CurrentDomain.GetAssemblies())
			{
				Type entityComponentScript = ass.GetType("KBEngine.Friends");
				if(entityComponentScript != null)
				{
					Friends = (FriendsBase)Activator.CreateInstance(entityComponentScript);
					Friends.owner = this;
					Friends.entityComponentPropertyID = 10;
				}
			}

			if(Friends == null)
				throw new Exception("Please inherit and implement, such as: \"class Friends : FriendsBase\"");

			foreach (System.Reflection.Assembly ass in AppDomain.CurrentDomain.GetAssemblies())
			{
				Type entityComponentScript = ass.GetType("KBEngine.Land");
				if(entityComponentScript != null)
				{
					Land = (LandBase)Activator.CreateInstance(entityComponentScript);
					Land.owner = this;
					Land.entityComponentPropertyID = 7;
				}
			}

			if(Land == null)
				throw new Exception("Please inherit and implement, such as: \"class Land : LandBase\"");

			foreach (System.Reflection.Assembly ass in AppDomain.CurrentDomain.GetAssemblies())
			{
				Type entityComponentScript = ass.GetType("KBEngine.Pet");
				if(entityComponentScript != null)
				{
					Pet = (PetBase)Activator.CreateInstance(entityComponentScript);
					Pet.owner = this;
					Pet.entityComponentPropertyID = 17;
				}
			}

			if(Pet == null)
				throw new Exception("Please inherit and implement, such as: \"class Pet : PetBase\"");

			foreach (System.Reflection.Assembly ass in AppDomain.CurrentDomain.GetAssemblies())
			{
				Type entityComponentScript = ass.GetType("KBEngine.Task");
				if(entityComponentScript != null)
				{
					Task = (TaskBase)Activator.CreateInstance(entityComponentScript);
					Task.owner = this;
					Task.entityComponentPropertyID = 20;
				}
			}

			if(Task == null)
				throw new Exception("Please inherit and implement, such as: \"class Task : TaskBase\"");

			foreach (System.Reflection.Assembly ass in AppDomain.CurrentDomain.GetAssemblies())
			{
				Type entityComponentScript = ass.GetType("KBEngine.bags");
				if(entityComponentScript != null)
				{
					bags = (bagsBase)Activator.CreateInstance(entityComponentScript);
					bags.owner = this;
					bags.entityComponentPropertyID = 5;
				}
			}

			if(bags == null)
				throw new Exception("Please inherit and implement, such as: \"class bags : bagsBase\"");

		}

		public override void onGetBase()
		{
			baseEntityCall = new EntityBaseEntityCall_AccountBase(id, className);
		}

		public override void onGetCell()
		{
			cellEntityCall = new EntityCellEntityCall_AccountBase(id, className);
		}

		public override void onLoseCell()
		{
			cellEntityCall = null;
		}

		public override EntityCall getBaseEntityCall()
		{
			return baseEntityCall;
		}

		public override EntityCall getCellEntityCall()
		{
			return cellEntityCall;
		}

		public override void onRemoteMethodCall(MemoryStream stream)
		{
			ScriptModule sm = EntityDef.moduledefs["Account"];

			UInt16 methodUtype = 0;
			UInt16 componentPropertyUType = 0;

			if(sm.useMethodDescrAlias)
			{
				componentPropertyUType = stream.readUint8();
				methodUtype = stream.readUint8();
			}
			else
			{
				componentPropertyUType = stream.readUint16();
				methodUtype = stream.readUint16();
			}

			Method method = null;

			if(componentPropertyUType == 0)
			{
				method = sm.idmethods[methodUtype];
			}
			else
			{
				Property pComponentPropertyDescription = sm.idpropertys[componentPropertyUType];
				switch(pComponentPropertyDescription.properUtype)
				{
					case 10:
						Friends.onRemoteMethodCall(methodUtype, stream);
						break;
					case 7:
						Land.onRemoteMethodCall(methodUtype, stream);
						break;
					case 17:
						Pet.onRemoteMethodCall(methodUtype, stream);
						break;
					case 20:
						Task.onRemoteMethodCall(methodUtype, stream);
						break;
					case 5:
						bags.onRemoteMethodCall(methodUtype, stream);
						break;
					default:
						break;
				}

				return;
			}

			switch(method.methodUtype)
			{
				case 36:
					string OnAddCardGroup_arg1 = stream.readUnicode();
					OnAddCardGroup(OnAddCardGroup_arg1);
					break;
				case 30:
					SByte OnBattleResult_arg1 = stream.readInt8();
					OnBattleResult(OnBattleResult_arg1);
					break;
				case 34:
					Byte OnDelCarErr_arg1 = stream.readUint8();
					OnDelCarErr(OnDelCarErr_arg1);
					break;
				case 35:
					CARD_GROUP OnGetKz_arg1 = ((DATATYPE_CARD_GROUP)method.args[0]).createFromStreamEx(stream);
					OnGetKz(OnGetKz_arg1);
					break;
				case 32:
					Int64 OnMarcherSum_arg1 = stream.readInt64();
					OnMarcherSum(OnMarcherSum_arg1);
					break;
				case 23:
					Int32 battleResultClientDisplay_arg1 = stream.readInt32();
					Int32 battleResultClientDisplay_arg2 = stream.readInt32();
					battleResultClientDisplay(battleResultClientDisplay_arg1, battleResultClientDisplay_arg2);
					break;
				case 24:
					gotoMain();
					break;
				case 42:
					CARD_INFOS_LIST onAccountCardData_arg1 = ((DATATYPE_CARD_INFOS_LIST)method.args[0]).createFromStreamEx(stream);
					onAccountCardData(onAccountCardData_arg1);
					break;
				case 28:
					string onAddCardGroup_arg1 = stream.readUnicode();
					onAddCardGroup(onAddCardGroup_arg1);
					break;
				case 47:
					string onBindAccount_arg1 = stream.readUnicode();
					onBindAccount(onBindAccount_arg1);
					break;
				case 27:
					string onChangeAvatar_arg1 = stream.readUnicode();
					onChangeAvatar(onChangeAvatar_arg1);
					break;
				case 46:
					string onChangeData_arg1 = stream.readUnicode();
					string onChangeData_arg2 = stream.readUnicode();
					onChangeData(onChangeData_arg1, onChangeData_arg2);
					break;
				case 45:
					ACCOUNT_DATA onData_arg1 = ((DATATYPE_ACCOUNT_DATA)method.args[0]).createFromStreamEx(stream);
					UInt64 onData_arg2 = stream.readUint64();
					onData(onData_arg1, onData_arg2);
					break;
				case 39:
					UInt64 onDiamond_arg1 = stream.readUint64();
					onDiamond(onDiamond_arg1);
					break;
				case 41:
					UInt64 onEglod_arg1 = stream.readUint64();
					onEglod(onEglod_arg1);
					break;
				case 33:
					Int64 onGetPlayerSum_arg1 = stream.readInt64();
					onGetPlayerSum(onGetPlayerSum_arg1);
					break;
				case 37:
					string onInf_arg1 = stream.readUnicode();
					onInf(onInf_arg1);
					break;
				case 29:
					onInitBattleField();
					break;
				case 40:
					UInt64 onKglod_arg1 = stream.readUint64();
					onKglod(onKglod_arg1);
					break;
				case 31:
					string onMarchMsg_arg1 = stream.readUnicode();
					onMarchMsg(onMarchMsg_arg1);
					break;
				case 38:
					UInt64 onMoney_arg1 = stream.readUint64();
					onMoney(onMoney_arg1);
					break;
				case 44:
					OPEN_PACK_DATA onOpeningPackResult_arg1 = ((DATATYPE_OPEN_PACK_DATA)method.args[0]).createFromStreamEx(stream);
					OPEN_PACK_NAME_DATA onOpeningPackResult_arg2 = ((DATATYPE_OPEN_PACK_NAME_DATA)method.args[1]).createFromStreamEx(stream);
					onOpeningPackResult(onOpeningPackResult_arg1, onOpeningPackResult_arg2);
					break;
				case 26:
					string onRemoveAvatar_arg1 = stream.readUnicode();
					onRemoveAvatar(onRemoveAvatar_arg1);
					break;
				case 25:
					AVATAR_INFOS_LIST onReqAvatarList_arg1 = ((DATATYPE_AVATAR_INFOS_LIST)method.args[0]).createFromStreamEx(stream);
					onReqAvatarList(onReqAvatarList_arg1);
					break;
				case 43:
					Byte onbuycard_arg1 = stream.readUint8();
					onbuycard(onbuycard_arg1);
					break;
				default:
					break;
			};
		}

		public override void onUpdatePropertys(MemoryStream stream)
		{
			ScriptModule sm = EntityDef.moduledefs["Account"];
			Dictionary<UInt16, Property> pdatas = sm.idpropertys;

			while(stream.length() > 0)
			{
				UInt16 _t_utype = 0;
				UInt16 _t_child_utype = 0;

				{
					if(sm.usePropertyDescrAlias)
					{
						_t_utype = stream.readUint8();
						_t_child_utype = stream.readUint8();
					}
					else
					{
						_t_utype = stream.readUint16();
						_t_child_utype = stream.readUint16();
					}
				}

				Property prop = null;

				if(_t_utype == 0)
				{
					prop = pdatas[_t_child_utype];
				}
				else
				{
					Property pComponentPropertyDescription = pdatas[_t_utype];
					switch(pComponentPropertyDescription.properUtype)
					{
						case 10:
							Friends.onUpdatePropertys(_t_child_utype, stream, -1);
							break;
						case 7:
							Land.onUpdatePropertys(_t_child_utype, stream, -1);
							break;
						case 17:
							Pet.onUpdatePropertys(_t_child_utype, stream, -1);
							break;
						case 20:
							Task.onUpdatePropertys(_t_child_utype, stream, -1);
							break;
						case 5:
							bags.onUpdatePropertys(_t_child_utype, stream, -1);
							break;
						default:
							break;
					}

					return;
				}

				switch(prop.properUtype)
				{
					case 4:
						AVATAR_INFOS_LIST oldval_Avatar_List = Avatar_List;
						Avatar_List = ((DATATYPE_AVATAR_INFOS_LIST)EntityDef.id2datatypes[55]).createFromStreamEx(stream);

						if(prop.isBase())
						{
							if(inited)
								onAvatar_ListChanged(oldval_Avatar_List);
						}
						else
						{
							if(inWorld)
								onAvatar_ListChanged(oldval_Avatar_List);
						}

						break;
					case 3:
						CARD_INFOS_LIST oldval_Card_Data = Card_Data;
						Card_Data = ((DATATYPE_CARD_INFOS_LIST)EntityDef.id2datatypes[49]).createFromStreamEx(stream);

						if(prop.isBase())
						{
							if(inited)
								onCard_DataChanged(oldval_Card_Data);
						}
						else
						{
							if(inWorld)
								onCard_DataChanged(oldval_Card_Data);
						}

						break;
					case 10:
						Friends.createFromStream(stream);
						break;
					case 7:
						Land.createFromStream(stream);
						break;
					case 17:
						Pet.createFromStream(stream);
						break;
					case 20:
						Task.createFromStream(stream);
						break;
					case 5:
						bags.createFromStream(stream);
						break;
					case 40001:
						Vector3 oldval_direction = direction;
						direction = stream.readVector3();

						if(prop.isBase())
						{
							if(inited)
								onDirectionChanged(oldval_direction);
						}
						else
						{
							if(inWorld)
								onDirectionChanged(oldval_direction);
						}

						break;
					case 40000:
						Vector3 oldval_position = position;
						position = stream.readVector3();

						if(prop.isBase())
						{
							if(inited)
								onPositionChanged(oldval_position);
						}
						else
						{
							if(inWorld)
								onPositionChanged(oldval_position);
						}

						break;
					case 40002:
						stream.readUint32();
						break;
					default:
						break;
				};
			}
		}

		public override void callPropertysSetMethods()
		{
			ScriptModule sm = EntityDef.moduledefs["Account"];
			Dictionary<UInt16, Property> pdatas = sm.idpropertys;

			AVATAR_INFOS_LIST oldval_Avatar_List = Avatar_List;
			Property prop_Avatar_List = pdatas[4];
			if(prop_Avatar_List.isBase())
			{
				if(inited && !inWorld)
					onAvatar_ListChanged(oldval_Avatar_List);
			}
			else
			{
				if(inWorld)
				{
					if(prop_Avatar_List.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onAvatar_ListChanged(oldval_Avatar_List);
					}
				}
			}

			CARD_INFOS_LIST oldval_Card_Data = Card_Data;
			Property prop_Card_Data = pdatas[5];
			if(prop_Card_Data.isBase())
			{
				if(inited && !inWorld)
					onCard_DataChanged(oldval_Card_Data);
			}
			else
			{
				if(inWorld)
				{
					if(prop_Card_Data.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onCard_DataChanged(oldval_Card_Data);
					}
				}
			}

			Friends.callPropertysSetMethods();

			Land.callPropertysSetMethods();

			Pet.callPropertysSetMethods();

			Task.callPropertysSetMethods();

			bags.callPropertysSetMethods();

			Vector3 oldval_direction = direction;
			Property prop_direction = pdatas[2];
			if(prop_direction.isBase())
			{
				if(inited && !inWorld)
					onDirectionChanged(oldval_direction);
			}
			else
			{
				if(inWorld)
				{
					if(prop_direction.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onDirectionChanged(oldval_direction);
					}
				}
			}

			Vector3 oldval_position = position;
			Property prop_position = pdatas[1];
			if(prop_position.isBase())
			{
				if(inited && !inWorld)
					onPositionChanged(oldval_position);
			}
			else
			{
				if(inWorld)
				{
					if(prop_position.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onPositionChanged(oldval_position);
					}
				}
			}

		}
	}
}