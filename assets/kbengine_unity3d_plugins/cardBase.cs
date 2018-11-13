/*
	Generated by KBEngine!
	Please do not modify this file!
	Please inherit this module, such as: (class card : cardBase)
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/card.def
	// Please inherit and implement "class card : cardBase"
	public abstract class cardBase : Entity
	{
		public EntityBaseEntityCall_cardBase baseEntityCall = null;
		public EntityCellEntityCall_cardBase cellEntityCall = null;

		public Int16 HP = 0;
		public virtual void onHPChanged(Int16 oldValue) {}
		public UInt16 armor = 0;
		public virtual void onArmorChanged(UInt16 oldValue) {}
		public UInt16 att = 0;
		public virtual void onAttChanged(UInt16 oldValue) {}
		public UInt16 attSum = 0;
		public virtual void onAttSumChanged(UInt16 oldValue) {}
		public UInt32 cardID = 0;
		public virtual void onCardIDChanged(UInt32 oldValue) {}
		public UInt16 cost = 0;
		public virtual void onCostChanged(UInt16 oldValue) {}
		public Byte frozen = 0;
		public virtual void onFrozenChanged(Byte oldValue) {}
		public Byte immune = 0;
		public virtual void onImmuneChanged(Byte oldValue) {}
		public Byte isAbled = 0;
		public virtual void onIsAbledChanged(Byte oldValue) {}
		public Byte isDivineShield = 0;
		public virtual void onIsDivineShieldChanged(Byte oldValue) {}
		public Byte isRush = 0;
		public virtual void onIsRushChanged(Byte oldValue) {}
		public Byte isStealth = 0;
		public virtual void onIsStealthChanged(Byte oldValue) {}
		public Byte isTaunt = 0;
		public virtual void onIsTauntChanged(Byte oldValue) {}
		public Byte isWindfury = 0;
		public virtual void onIsWindfuryChanged(Byte oldValue) {}
		public Byte maxHP = 0;
		public virtual void onMaxHPChanged(Byte oldValue) {}
		public Byte playerID = 0;
		public virtual void onPlayerIDChanged(Byte oldValue) {}
		public string pos = "N";
		public virtual void onPosChanged(string oldValue) {}
		public Byte silent = 0;
		public virtual void onSilentChanged(Byte oldValue) {}
		public UInt16 type = 0;
		public virtual void onTypeChanged(UInt16 oldValue) {}
		public Int16 useSum = 0;
		public virtual void onUseSumChanged(Int16 oldValue) {}

		public abstract void onAtt(Int32 arg1); 
		public abstract void onChoose(STR_LIST arg1); 
		public abstract void onEvent(Int32 arg1, Int32 arg2, string arg3); 
		public abstract void onUse(Int32 arg1); 

		public cardBase()
		{
		}

		public override void onGetBase()
		{
			baseEntityCall = new EntityBaseEntityCall_cardBase(id, className);
		}

		public override void onGetCell()
		{
			cellEntityCall = new EntityCellEntityCall_cardBase(id, className);
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
			ScriptModule sm = EntityDef.moduledefs["card"];

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
					default:
						break;
				}

				return;
			}

			switch(method.methodUtype)
			{
				case 152:
					Int32 onAtt_arg1 = stream.readInt32();
					onAtt(onAtt_arg1);
					break;
				case 153:
					STR_LIST onChoose_arg1 = ((DATATYPE_STR_LIST)method.args[0]).createFromStreamEx(stream);
					onChoose(onChoose_arg1);
					break;
				case 151:
					Int32 onEvent_arg1 = stream.readInt32();
					Int32 onEvent_arg2 = stream.readInt32();
					string onEvent_arg3 = stream.readUnicode();
					onEvent(onEvent_arg1, onEvent_arg2, onEvent_arg3);
					break;
				case 150:
					Int32 onUse_arg1 = stream.readInt32();
					onUse(onUse_arg1);
					break;
				default:
					break;
			};
		}

		public override void onUpdatePropertys(MemoryStream stream)
		{
			ScriptModule sm = EntityDef.moduledefs["card"];
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
						default:
							break;
					}

					return;
				}

				switch(prop.properUtype)
				{
					case 65:
						Int16 oldval_HP = HP;
						HP = stream.readInt16();

						if(prop.isBase())
						{
							if(inited)
								onHPChanged(oldval_HP);
						}
						else
						{
							if(inWorld)
								onHPChanged(oldval_HP);
						}

						break;
					case 67:
						UInt16 oldval_armor = armor;
						armor = stream.readUint16();

						if(prop.isBase())
						{
							if(inited)
								onArmorChanged(oldval_armor);
						}
						else
						{
							if(inWorld)
								onArmorChanged(oldval_armor);
						}

						break;
					case 66:
						UInt16 oldval_att = att;
						att = stream.readUint16();

						if(prop.isBase())
						{
							if(inited)
								onAttChanged(oldval_att);
						}
						else
						{
							if(inWorld)
								onAttChanged(oldval_att);
						}

						break;
					case 68:
						UInt16 oldval_attSum = attSum;
						attSum = stream.readUint16();

						if(prop.isBase())
						{
							if(inited)
								onAttSumChanged(oldval_attSum);
						}
						else
						{
							if(inWorld)
								onAttSumChanged(oldval_attSum);
						}

						break;
					case 64:
						UInt32 oldval_cardID = cardID;
						cardID = stream.readUint32();

						if(prop.isBase())
						{
							if(inited)
								onCardIDChanged(oldval_cardID);
						}
						else
						{
							if(inWorld)
								onCardIDChanged(oldval_cardID);
						}

						break;
					case 69:
						UInt16 oldval_cost = cost;
						cost = stream.readUint16();

						if(prop.isBase())
						{
							if(inited)
								onCostChanged(oldval_cost);
						}
						else
						{
							if(inWorld)
								onCostChanged(oldval_cost);
						}

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
					case 80:
						Byte oldval_frozen = frozen;
						frozen = stream.readUint8();

						if(prop.isBase())
						{
							if(inited)
								onFrozenChanged(oldval_frozen);
						}
						else
						{
							if(inWorld)
								onFrozenChanged(oldval_frozen);
						}

						break;
					case 81:
						Byte oldval_immune = immune;
						immune = stream.readUint8();

						if(prop.isBase())
						{
							if(inited)
								onImmuneChanged(oldval_immune);
						}
						else
						{
							if(inWorld)
								onImmuneChanged(oldval_immune);
						}

						break;
					case 78:
						Byte oldval_isAbled = isAbled;
						isAbled = stream.readUint8();

						if(prop.isBase())
						{
							if(inited)
								onIsAbledChanged(oldval_isAbled);
						}
						else
						{
							if(inWorld)
								onIsAbledChanged(oldval_isAbled);
						}

						break;
					case 77:
						Byte oldval_isDivineShield = isDivineShield;
						isDivineShield = stream.readUint8();

						if(prop.isBase())
						{
							if(inited)
								onIsDivineShieldChanged(oldval_isDivineShield);
						}
						else
						{
							if(inWorld)
								onIsDivineShieldChanged(oldval_isDivineShield);
						}

						break;
					case 75:
						Byte oldval_isRush = isRush;
						isRush = stream.readUint8();

						if(prop.isBase())
						{
							if(inited)
								onIsRushChanged(oldval_isRush);
						}
						else
						{
							if(inWorld)
								onIsRushChanged(oldval_isRush);
						}

						break;
					case 79:
						Byte oldval_isStealth = isStealth;
						isStealth = stream.readUint8();

						if(prop.isBase())
						{
							if(inited)
								onIsStealthChanged(oldval_isStealth);
						}
						else
						{
							if(inWorld)
								onIsStealthChanged(oldval_isStealth);
						}

						break;
					case 74:
						Byte oldval_isTaunt = isTaunt;
						isTaunt = stream.readUint8();

						if(prop.isBase())
						{
							if(inited)
								onIsTauntChanged(oldval_isTaunt);
						}
						else
						{
							if(inWorld)
								onIsTauntChanged(oldval_isTaunt);
						}

						break;
					case 76:
						Byte oldval_isWindfury = isWindfury;
						isWindfury = stream.readUint8();

						if(prop.isBase())
						{
							if(inited)
								onIsWindfuryChanged(oldval_isWindfury);
						}
						else
						{
							if(inWorld)
								onIsWindfuryChanged(oldval_isWindfury);
						}

						break;
					case 73:
						Byte oldval_maxHP = maxHP;
						maxHP = stream.readUint8();

						if(prop.isBase())
						{
							if(inited)
								onMaxHPChanged(oldval_maxHP);
						}
						else
						{
							if(inWorld)
								onMaxHPChanged(oldval_maxHP);
						}

						break;
					case 71:
						Byte oldval_playerID = playerID;
						playerID = stream.readUint8();

						if(prop.isBase())
						{
							if(inited)
								onPlayerIDChanged(oldval_playerID);
						}
						else
						{
							if(inWorld)
								onPlayerIDChanged(oldval_playerID);
						}

						break;
					case 72:
						string oldval_pos = pos;
						pos = stream.readUnicode();

						if(prop.isBase())
						{
							if(inited)
								onPosChanged(oldval_pos);
						}
						else
						{
							if(inWorld)
								onPosChanged(oldval_pos);
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
					case 84:
						Byte oldval_silent = silent;
						silent = stream.readUint8();

						if(prop.isBase())
						{
							if(inited)
								onSilentChanged(oldval_silent);
						}
						else
						{
							if(inWorld)
								onSilentChanged(oldval_silent);
						}

						break;
					case 40002:
						stream.readUint32();
						break;
					case 70:
						UInt16 oldval_type = type;
						type = stream.readUint16();

						if(prop.isBase())
						{
							if(inited)
								onTypeChanged(oldval_type);
						}
						else
						{
							if(inWorld)
								onTypeChanged(oldval_type);
						}

						break;
					case 83:
						Int16 oldval_useSum = useSum;
						useSum = stream.readInt16();

						if(prop.isBase())
						{
							if(inited)
								onUseSumChanged(oldval_useSum);
						}
						else
						{
							if(inWorld)
								onUseSumChanged(oldval_useSum);
						}

						break;
					default:
						break;
				};
			}
		}

		public override void callPropertysSetMethods()
		{
			ScriptModule sm = EntityDef.moduledefs["card"];
			Dictionary<UInt16, Property> pdatas = sm.idpropertys;

			Int16 oldval_HP = HP;
			Property prop_HP = pdatas[4];
			if(prop_HP.isBase())
			{
				if(inited && !inWorld)
					onHPChanged(oldval_HP);
			}
			else
			{
				if(inWorld)
				{
					if(prop_HP.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onHPChanged(oldval_HP);
					}
				}
			}

			UInt16 oldval_armor = armor;
			Property prop_armor = pdatas[5];
			if(prop_armor.isBase())
			{
				if(inited && !inWorld)
					onArmorChanged(oldval_armor);
			}
			else
			{
				if(inWorld)
				{
					if(prop_armor.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onArmorChanged(oldval_armor);
					}
				}
			}

			UInt16 oldval_att = att;
			Property prop_att = pdatas[6];
			if(prop_att.isBase())
			{
				if(inited && !inWorld)
					onAttChanged(oldval_att);
			}
			else
			{
				if(inWorld)
				{
					if(prop_att.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onAttChanged(oldval_att);
					}
				}
			}

			UInt16 oldval_attSum = attSum;
			Property prop_attSum = pdatas[7];
			if(prop_attSum.isBase())
			{
				if(inited && !inWorld)
					onAttSumChanged(oldval_attSum);
			}
			else
			{
				if(inWorld)
				{
					if(prop_attSum.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onAttSumChanged(oldval_attSum);
					}
				}
			}

			UInt32 oldval_cardID = cardID;
			Property prop_cardID = pdatas[8];
			if(prop_cardID.isBase())
			{
				if(inited && !inWorld)
					onCardIDChanged(oldval_cardID);
			}
			else
			{
				if(inWorld)
				{
					if(prop_cardID.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onCardIDChanged(oldval_cardID);
					}
				}
			}

			UInt16 oldval_cost = cost;
			Property prop_cost = pdatas[9];
			if(prop_cost.isBase())
			{
				if(inited && !inWorld)
					onCostChanged(oldval_cost);
			}
			else
			{
				if(inWorld)
				{
					if(prop_cost.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onCostChanged(oldval_cost);
					}
				}
			}

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

			Byte oldval_frozen = frozen;
			Property prop_frozen = pdatas[10];
			if(prop_frozen.isBase())
			{
				if(inited && !inWorld)
					onFrozenChanged(oldval_frozen);
			}
			else
			{
				if(inWorld)
				{
					if(prop_frozen.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onFrozenChanged(oldval_frozen);
					}
				}
			}

			Byte oldval_immune = immune;
			Property prop_immune = pdatas[11];
			if(prop_immune.isBase())
			{
				if(inited && !inWorld)
					onImmuneChanged(oldval_immune);
			}
			else
			{
				if(inWorld)
				{
					if(prop_immune.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onImmuneChanged(oldval_immune);
					}
				}
			}

			Byte oldval_isAbled = isAbled;
			Property prop_isAbled = pdatas[12];
			if(prop_isAbled.isBase())
			{
				if(inited && !inWorld)
					onIsAbledChanged(oldval_isAbled);
			}
			else
			{
				if(inWorld)
				{
					if(prop_isAbled.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onIsAbledChanged(oldval_isAbled);
					}
				}
			}

			Byte oldval_isDivineShield = isDivineShield;
			Property prop_isDivineShield = pdatas[13];
			if(prop_isDivineShield.isBase())
			{
				if(inited && !inWorld)
					onIsDivineShieldChanged(oldval_isDivineShield);
			}
			else
			{
				if(inWorld)
				{
					if(prop_isDivineShield.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onIsDivineShieldChanged(oldval_isDivineShield);
					}
				}
			}

			Byte oldval_isRush = isRush;
			Property prop_isRush = pdatas[14];
			if(prop_isRush.isBase())
			{
				if(inited && !inWorld)
					onIsRushChanged(oldval_isRush);
			}
			else
			{
				if(inWorld)
				{
					if(prop_isRush.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onIsRushChanged(oldval_isRush);
					}
				}
			}

			Byte oldval_isStealth = isStealth;
			Property prop_isStealth = pdatas[15];
			if(prop_isStealth.isBase())
			{
				if(inited && !inWorld)
					onIsStealthChanged(oldval_isStealth);
			}
			else
			{
				if(inWorld)
				{
					if(prop_isStealth.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onIsStealthChanged(oldval_isStealth);
					}
				}
			}

			Byte oldval_isTaunt = isTaunt;
			Property prop_isTaunt = pdatas[16];
			if(prop_isTaunt.isBase())
			{
				if(inited && !inWorld)
					onIsTauntChanged(oldval_isTaunt);
			}
			else
			{
				if(inWorld)
				{
					if(prop_isTaunt.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onIsTauntChanged(oldval_isTaunt);
					}
				}
			}

			Byte oldval_isWindfury = isWindfury;
			Property prop_isWindfury = pdatas[17];
			if(prop_isWindfury.isBase())
			{
				if(inited && !inWorld)
					onIsWindfuryChanged(oldval_isWindfury);
			}
			else
			{
				if(inWorld)
				{
					if(prop_isWindfury.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onIsWindfuryChanged(oldval_isWindfury);
					}
				}
			}

			Byte oldval_maxHP = maxHP;
			Property prop_maxHP = pdatas[18];
			if(prop_maxHP.isBase())
			{
				if(inited && !inWorld)
					onMaxHPChanged(oldval_maxHP);
			}
			else
			{
				if(inWorld)
				{
					if(prop_maxHP.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onMaxHPChanged(oldval_maxHP);
					}
				}
			}

			Byte oldval_playerID = playerID;
			Property prop_playerID = pdatas[19];
			if(prop_playerID.isBase())
			{
				if(inited && !inWorld)
					onPlayerIDChanged(oldval_playerID);
			}
			else
			{
				if(inWorld)
				{
					if(prop_playerID.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onPlayerIDChanged(oldval_playerID);
					}
				}
			}

			string oldval_pos = pos;
			Property prop_pos = pdatas[20];
			if(prop_pos.isBase())
			{
				if(inited && !inWorld)
					onPosChanged(oldval_pos);
			}
			else
			{
				if(inWorld)
				{
					if(prop_pos.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onPosChanged(oldval_pos);
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

			Byte oldval_silent = silent;
			Property prop_silent = pdatas[21];
			if(prop_silent.isBase())
			{
				if(inited && !inWorld)
					onSilentChanged(oldval_silent);
			}
			else
			{
				if(inWorld)
				{
					if(prop_silent.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onSilentChanged(oldval_silent);
					}
				}
			}

			UInt16 oldval_type = type;
			Property prop_type = pdatas[22];
			if(prop_type.isBase())
			{
				if(inited && !inWorld)
					onTypeChanged(oldval_type);
			}
			else
			{
				if(inWorld)
				{
					if(prop_type.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onTypeChanged(oldval_type);
					}
				}
			}

			Int16 oldval_useSum = useSum;
			Property prop_useSum = pdatas[23];
			if(prop_useSum.isBase())
			{
				if(inited && !inWorld)
					onUseSumChanged(oldval_useSum);
			}
			else
			{
				if(inWorld)
				{
					if(prop_useSum.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onUseSumChanged(oldval_useSum);
					}
				}
			}

		}
	}
}