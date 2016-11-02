using UnityEngine;
using System.Collections;

public enum EGameEvent
{
    eGameEvent_ErrorStr = 1,
    eGameEvent_ConnectServerFail,   //z连接服务器失败
    eGameEvent_ConnectServerSuccess,//z连接服务器成功

    eGameEvent_ReConnectSuccess,//z重连成功
    eGameEvent_ReConnectFail,//z重连失败

    eGameEvent_InputUserData,//z输入用户数据
    
    eGameEvent_SelectServer,//z选择服务器

    eGameEvent_IntoLobby,//z进入大厅

    eGameEvent_IntoRoom,//z进入房间

    eGameEvent_RoomBack,//z回到房间

    eGameEvent_RoomEnd,//z退出房间

    eGameEvent_IntoHero,//z进入英雄选择界面

    eGameEvent_Loading,//z加载

    eGameEvent_LoadingEnd,//z加载结束

    eGameEvent_GameOver,  //z游戏结束

    eGameEvent_ReconnectToBatttle,//z重连到战斗

    eGameEvent_BatttleFinished,//z战斗结束
	
	eGameEvent_AskReadySucces,//z   没用上
    eGameEvent_AskLeaveBattleSucces,//z   没用上
    eGameEvent_BattleStateChange,//z   没用上

	eGameEvent_AskComplementedRegisterInfo,

	eGameEvent_AskAddInBattle,//z询问加入战斗


	eGameEvent_TheBattleUserFull,//z 没用上
    eGameEvent_NullBattle,//z 没用上
    eGameEvent_BattlePDWNotMatch,//z 没用上
    eGameEvent_NullUser,//z 没用上
    eGameEvent_InvalidMapID,//z 没用上
    eGameEvent_InvalidBattlePos,//z 没用上
    eGameEvent_JustInBattle,//z 没用上

	
	eGameEvent_JustNotInBattle,
	eGameEvent_UserDonotInTheBattle,
	eGameEvent_InvalidBattleState,
	eGameEvent_YouAreNotBattleManager,
	eGameEvent_NotAllUserReady,

	eGameEvent_NotEnoughGold,

	eGameEvent_Reborn,
    eGameEvent_PlayerEnterAltar,

    eGameEvent_ChangeMapState,

    eGameEvent_UpdateUserGameItems,
    eGameEvent_GameStartTime,

    

    eGameEvent_OpenUIPlay,

    eGameEent_ScenseChange,
    eGameEent_SystemNoticeCreataPrefab,
    
    eGameEent_CretateDailyBonus,
    eGameEent_DailyBonus,
    eGameEent_RemoveDailyBonus,
    eGameEent_ChangeMoney,
    eGameEvent_UpdateMiniMap,
    eGameEvent_InitMiniMap,
    eGameEvent_AddMiniMap,
    eGameEvent_RemoveMiniMap,
    eGameEvent_BroadcastBeAtk,
    eGameEvent_RemoveMiniWarning,

    eGameEvent_AllPlayerGoods,
    eGameEvent_AllPlayerAssist,
    eGameEvent_AllPlayerKills,
    eGameEvent_AllPlayerDeaths,
    eGameEvent_AllPlayerCp,
    eGameEvent_AllPlayerLevel,
    eGameEvent_AllPlayerLastHit,

    eGameEvent_NotifyChangeKills,
    eGameEvent_NotifyChangeDeaths,
    eGameEvent_LocalPlayerCp,
    eGameEvent_PlayerGetCp,
    eGameEvent_LocalPlayerAssist,

    eGameEent_UpLv,


    eGameEvent_BeginWaiting,
    eGameEvent_EndWaiting,

    eGameEvent_MatchNumber,

    eGameEvent_EntityHpChange,//entityHP改变
    eGameEvent_EntityMpChange,//entityMP改变
    //OB
    eGameEvent_HeroInfoChange,
    eGameEvent_HeroHpChange,
    eGameEvent_HeroLvChange,
    eGameEvent_HeroMpChange,
    eGameEvent_SkillUpLvChange,
    eGameEvent_SkillInfo,
    eGameEvent_HeroHeadInfoChange,
    eGameEvent_HeroDeathTime,
    eGameEvent_HeroBackTown,
    eGameEvent_AbsSkillInfo,
    eGameEvent_SkillCDInfo,
    eGameEvent_FuryStateInfo,
    eGameEvent_PackageBuyInfo,
    eGameEvent_PersonInitInfo,

    eGameEvent_InvitatAddFriendInfo,
    eGameEvent_RemoveFriend,
    eGameEvent_RemoveFriendEnd,
    eGameEvent_FriendPersonInfo,//详细信息
    eGameEvent_BlackInfo,//黑名单简介
    eGameEvent_ReceiveLobbyMsg,
    eGameEvent_ReceiveNewMsg,
    eGameEvent_RemoveChatTask,
    eGameEvent_InvitationMsg,
    eGameEvent_FindFriendInfo,
    eGameEvent_FindClear,
	eGameEvent_TalkUIDetails,
    eGameEvent_AskFriendEorr,

    eGameEvent_HeroReborn,//英雄复活
    eGameEvent_NotifyDeathEnter,
    eGameEvent_NotifyDeathExit,

    eGameEvent_ChatCheck,
    
    
    eGameEvent_LockTarget,//广播自己锁定目标
    eGameEvent_AddOrDelEnemy,//广播增加或者删除敌方玩家
    eGameEvent_SSPingInfo,//广播SSPing;
    eGameEvent_NotifyChangeCp,//Cp改变
    eGameEvent_NotifyHpLessWarning,//血量警告特效
    eGameEvent_NotifyOpenShop,//打开商店，关闭商店
    eGameEvent_NotifyBuildingDes,//Ientity死亡
    eGameEvent_GuideShowBuildingTips,



    // sdk event
    eGameEvent_SdkRegisterSuccess,//sdk登錄成功
    eGameEvent_SdkServerCheckSuccess,//服務器向SDK的驗證成功 
    eGameEvent_SdkLogOff,
    


    //Login
    eGameEvent_LoginEnter, //进入登陆
    eGameEvent_LoginExit, //退出登陆
    eGameEvent_LoginError,  //登陆错误码
    eGameEvent_LoginSuccess,  //登陆成功
    eGameEvent_LoginFail,  //登陆失败

    //system notice
    eGameEvent_SystemNoticeEnter,
    eGameEvent_SystemNoticeExit,
    //兑换码
    eGameEvent_ExtraBonusEnter,
    eGameEvent_ExtraBonusExit,
    //英雄时限
    eGameEvent_TimeLimitHeroEnter,
    eGameEvent_TimeLimitHeroExit,

    //英雄信息

    eGameEvent_HeroDatumEnter,
    eGameEvent_HeroDatumExit,
    //user info
    eGameEvent_UserEnter, //进入用户信息设置
    eGameEvent_UserExit, //退出用户信息设置

    //帐号获得商品
    eGameEvent_UserGetGoodsHero,   //获得英雄
    eGameEvent_UserGetGoodsNml,    //获得普通物品
    eGameEvent_UserGetMoney,   
    eGameEvent_RefreshGoodHero,      //刷新商城显示物品  
    eGameEvent_CsGetNewHero,      //帐号获得新的英雄 
    eGameEvent_RefreshTimeLimitHero,

    //lobby
    eGameEvent_LobbyEnter, //进入大厅
    eGameEvent_LobbyExit, //退出大厅
    eGameEvent_BattleEnter, //进入战斗
    eGameEvent_BattleExit, //退出战斗
    eGameEvent_MarketEnter,
    eGameEvent_MarketExit,
    eGameEvent_MarketHeroListEnter,
    eGameEvent_MarketHeroListExit,
    eGameEvent_MarketHeroInfoEnter,
    eGameEvent_MarketHeroInfoExit,

     eGameEvent_HeroTimeLimitEnter,
     eGameEvent_HeroTimeLimitExit,

    eGameEvent_MarketRuneListEnter,
    eGameEvent_MarketRuneListExit,
    eGameEvent_MarketRuneInfoEnter,
    eGameEvent_MarketRuneInfoExit,

    eGameEvent_MarketRuneBuyEnter,
    eGameEvent_MarketRuneBuyExit,

    eGameEvent_RuneEquipWindowEnter,
    eGameEvent_RuneEquipWindowExit,

    eGameEvent_RuneCombineWindowEnter,
    eGameEvent_RuneCombineWindowExit,

    eGameEvent_RuneRefreshCardUpdate,

    eGameEvent_RuneRefeshWindowEnter,
    eGameEvent_RuneRefeshWindowExit,

    eGameEvent_RuneBuyWindowEnter,
    eGameEvent_RuneBuyWindowExit,

    eGameEvent_PurchaseSuccessWindowEnter,
    eGameEvent_PurchaseSuccessWindowExit,

    eGameEvent_PurchaseRuneSuccessWin,

    eGameEvent_RuneQuipUpdate,
    eGameEvent_RuneQuipUnload,
    eGameEvent_RuneBagUpdate,

    eGameEvent_GameSettingEnter,
    eGameEvent_GameSettingExit,

    eGameEvent_TeamMatchEnter, //进入组队匹配
    eGameEvent_TeamMatchExit, //退出组队匹配
    eGameEvent_TeamMatchAddTeammate,  //增加队友
    eGameEvent_TeamMatchDelTeammate,  //删除队友

    eGameEvent_TeamMatchInvitationEnter,  //组队邀请界面
    eGameEvent_TeamMatchInvitationExit,   //组队邀请界面退出

    eGameEvent_TeamMatchSearchinEnter,   //匹配中界面
    eGameEvent_TeamMatchSearchinExit,    //匹配中界面

    eGameEvent_ServerMatchInvitationEnter,  //服务器匹配邀请界面
    eGameEvent_ServerMatchInvitationExit,   //服务器匹配邀请界面退出

    eGameEvent_HomePageEnter, //进入主页
    eGameEvent_HomePageExit, //退出主页

    // 个人信息
    eGameEvent_PresonInfoEnter,
    eGameEvent_PresonInfoExit,
    eGameEvent_ChangeNickName,
    eGameEvent_ChangeHeadID,
    eGameEvent_ChangeUserLevel,
    //VIP
    eGameEvent_VIPPrerogativeEnter,
    eGameEvent_VIPPrerogativeExit,

    //mail
    eGameEvent_MailEnter,
    eGameEvent_MailExit,
    eGameEvent_AskMailInfo,
    eGameEvent_AskCloseOrGetMailGift,
    eGameEvent_UpdateMailList,
    eGameEvent_UpdateMailInfo, 
    eGameEvent_AddNewMailReq,
    eGameEvent_AddNewMailRsp,
    eGameEvent_SetDefaultMailInfo,

    eGameEvent_BattleUpdateRoomList, //更新房间列表

    //social
    eGameEvent_SocialEnter,
    eGameEvent_SocialExit,
    eGameEvent_CreateFriendPrefab,
    eGameEvent_CreateBlackPrefab,
    eGameEvent_FriendChangeInfo,//简介
    //Invite
    eGameEvent_InviteCreate,
    eGameEvent_InviteEnter,
    eGameEvent_InviteExit,
    eGameEvent_InviteChange,

    //在大厅接收Invite
    eGameEvent_InviteAddRoom,
    eGameEvent_InviteRoomEnter,
    eGameEvent_InviteRoomExit,
    eGameEvent_NewInviteRoom,
   
    //chatTask
    eGameEvent_ChatTaskEnter,
    eGameEvent_ChatTaskExit,
    eGameEvent_ChatTaskFriend,
    eGameEvent_ReadyChatTaskEnter,
    eGameEvent_ShowChatTaskFriend,

    //room
    eGameEvent_RoomEnter, //进入登陆
    eGameEvent_RoomExit, //退出登陆
    eGameEvent_AskBeginBattleError,  //开始游戏错语反馈
    eGameEvent_SeatPosUpdate,  //更新座位
    eGameEvent_RecvChatMsg,   //收到房间聊天消息

    //RoomOpenInvite
    eGameEvent_RoomInviteEnter,
    eGameEvent_RoomInviteExit,
    eGameEvent_InviteList,

    //hero
    eGameEvent_HeroEnter, //进入英雄选择
    eGameEvent_HeroExit, //退出英雄选择
    eGameEvent_HeroPreSelect, //英雄预选择
    eGameEvent_HeroRealSelect,//英雄选择确认
    eGameEvent_HeroAddSelect, //增加一个英雄选择
    eGameEvent_HeroEnterRandom, //进入随机选择英雄
    eGameEvent_HeroFirstTime,   //第一次读秒时间
    eGameEvent_HeroSecondTime,  //第二次读秒时间
    eGameEvent_HeroReconnectPreSelect, //重连预选择处理


    //play
    eGameEvent_BattleInfoEnter,//进入实时战斗查看信息
    eGameEvent_BattleInfoExit,//退出实时战斗查看信息
    eGameEvent_BattleIngEnter,//查看当前战绩
    eGameEvent_BattleMineEnter,//查看自己当前的属性
    eGameEvent_BattleTimeDownEnter,//进入战斗倒计时

    //LocalPlayer
    eGameEvent_LocalPlayerHpChange,
    eGameEvent_LocalPlayerMpChange,
    eGameEvent_LocalPlayerLevelChange,
    eGameEvent_LocalPlayerExpChange,
    eGameEvent_LocalPlayerInit,
    eGameEvent_LocalPlayerPassiveSkillsUpLv,
    eGameEvent_LocalPlayerPassiveSkills,
    eGameEvent_LocalPlayerSkillCD,
    eGameEvent_LocalPlayerSilence,
    eGameEvent_SkillDescribleType,
    eGameEvent_SkillDescribleId,
    eGameEvent_SkillDescribleUpdate,
    eGameEvent_LocalPlayerUpdateFuryValue,
    eGameEvent_LocalPlayerUpdateFuryEffect,
    eGameEvent_LocalPlayerRange,

    //over
    eGameEvent_ScoreEnter,  //进入胜负显示
    eGameEvent_ScoreExit,   //退出胜负显示
    eGameEvent_SettlementEnter,  //进入结算显示
    eGameEvent_SettlementExit,   //退出结算显示

    eGameEvent_GamePlayEnter,
    eGameEvent_GamePlayExit,
    eGameEvent_HeroAttributesInfo,

    //吸附
    eGameEvent_SoleSoldierEnter,
    eGameEvent_SoleSoldierExit,
    eGameEvent_ResetAbsHead,
    eGameEvent_ResetLockHead,
    eGameEvent_AbsorbResult,



    //新手引导
    eGameEvent_UIGuideEnter,
    eGameEvent_UIGuideExit,
    eGameEvent_UIGuideEvent,
    eGameEvent_PlayGuideEnter,
    eGameEvent_PlayGuideExit,
    eGameEvent_PlayGuideDragEvent,
    eGameEvent_PlayChildTaskFinish,
    eGameEvent_PlayTaskModelFinish,

    eGameEvent_GuideKillTask,
    eGameEvent_GuideAbsorbTask,
    eGameEvent_GuideLockTargetCanAbsorb,   //如果锁定了可以吸附的小怪
    eGameEvent_GuideLockTargetCanNotAbsorb, //锁定对象为空了或者锁定对象不能吸附

    //进阶引导
    eGameEvent_AdvancedGuideEnter,
    eGameEvent_AdvancedGuideExit,
    eGameEvent_AdvancedGuideShowTip,
    eGameEvent_AdvancedGuideBeAttackByBuilding,


    //其它
    eGameEvent_ShowMessage, //显示MessageBox
    eGameEvent_ShowLogicMessage,

    //DailyBonus
    eGameEvent_DailyBonusEnter,
    eGameEvent_DailyBonusExit,
    eGameEvent_DailyBonusUpdate,
    eGameEvent_NotifyAllTaskUpdate,
    eGameEvent_NotifyDailyTaskUpdate,
    eGameEvent_NotifyOneTaskAdd,
    eGameEvent_NotifyOneTaskUpdate,
    eGameEvent_NotifyOneTaskDel,
    eGameEvent_NotifyOneTaskRewards,

    //UIGuide // register guide
    eGameEvent_UIGuideTriggerRegister = -5000,
    eGameEvent_UIGuideTriggerNewsGuide = -5001,
    eGameEvent_UIGuideTriggerSelfDefGame = -5002,
    eGameEvent_UIGuideTriggerCreateRoom = -5003,
    eGameEvent_UIGuideTriggerBackLobby = -5004,
    eGameEvent_UIGuideTriggerMatchGame = -5005, 
    eGameEvent_UIGuideTriggerSelectHero = -5006,
    eGameEvent_UIGuideTriggerRoomBeginGame = -5007,

    eGameEvent_SecondaryGuideTipToBuyStart = -5008,
    eGameEvent_SecondaryGuideTipToBackCityStart = -5009,
    eGameEvent_SecondaryGuideTipToFurySkillStart = -5010,
    eGameEvent_SecondaryGuideTipToShopCpStart = -5011,
    eGameEvent_SecondaryGuideTipToBuyEnd = -5012,
    eGameEvent_SecondaryGuideTipToBackCityEnd = -5013,
    eGameEvent_SecondaryGuideTipToFurySkillEnd = -5014,
    eGameEvent_SecondaryGuideTipToShopCpEnd = -5015, 

    eGameEent_UIGuideInputNickNameStart = -8000,
    eGameEvent_UIGuideSelectSexStart = -8001,
    eGameEvent_UIGuideSelectHeadStart = -8002,
    eGameEvent_UIGuideCommitRegisterStart = -8003,
    eGameEvent_UIGuideNewsGuideStart = -8004,
    eGameEvent_UIGuideSelfDefBtnStart = -8005,
    eGameEvent_UIGuideSelectPrimaryBtnStart = -8006,
    eGameEvent_UIGuideCreateRoomBtnStart = -8007,
    eGameEvent_UIGuideBackLobbyBtnStart = -8008,
    eGameEvent_UIGuideMatchBtnStart = -8009,
    eGameEvent_UIGuideRoomBeginBtnStart = -8010,
    eGameEvent_UIGuideSelectHeroHeadStart = -8011,
    eGameEvent_UIGuideSelectHeroCommitStart = -8012, 


    eGameEent_UIGuideInputNickNameEnd = -1000,
    eGameEvent_UIGuideSelectSexEnd = -1001,
    eGameEvent_UIGuideSelectHeadEnd = -1002,
    eGameEvent_UIGuideCommitRegisterEnd = -1003,
    eGameEvent_UIGuideNewsGuideEnd = -1004,
    eGameEvent_UIGuideSelfDefBtnEnd = -1005,
    eGameEvent_UIGuideSelectPrimaryBtnEnd = -1006,
    eGameEvent_UIGuideSelectCreateRoomBtnEnd = -1007,
    eGameEvent_UIGuideBackLobbyBtnEnd = -1008,
    eGameEvent_UIGuideMatchBtnEnd = -1009,
    eGameEvent_UIGuideRoomBeginBtnEnd = -1010,
    eGameEvent_UIGuideSelectHeroHeadEnd = -1011,
    eGameEvent_UIGuideSelectHeroCommitEnd = -1012, 
}
