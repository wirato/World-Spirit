using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameText
{
    private const string TEXT_PREFIX = "TEXT_";
    private const string VALUE_PREFIX = "VALUE_";
    private const string FORMAT_PREFIX = "FORMAT_";
    public const string TITLE_INFO_DIALOG = TEXT_PREFIX + "TITLE_INFO_DIALOG";
    public const string TITLE_ERROR_DIALOG = TEXT_PREFIX + "TITLE_ERROR_DIALOG";
    public const string TITLE_PROFILE_NAME_DIALOG = TEXT_PREFIX + "TITLE_PROFILE_NAME_DIALOG";
    public const string CONTENT_PROFILE_NAME_DIALOG = TEXT_PREFIX + "CONTENT_PROFILE_NAME_DIALOG";
    public const string PLACE_HOLDER_PROFILE_NAME = TEXT_PREFIX + "PLACE_HOLDER_PROFILE_NAME";
    public const string TITLE_SOFT_CURRENCY = TEXT_PREFIX + "TITLE_SOFT_CURRENCY";
    public const string TITLE_HARD_CURRENCY = TEXT_PREFIX + "TITLE_HARD_CURRENCY";
    public const string TITLE_STAGE_STAMINA = TEXT_PREFIX + "TITLE_STAGE_STAMINA";
    public const string TITLE_ARENA_STAMINA = TEXT_PREFIX + "TITLE_ARENA_STAMINA";
    // Combat
    public const string COMBAT_MISS = TEXT_PREFIX + "COMBAT_MISS";
    public const string COMBAT_RESIST = TEXT_PREFIX + "COMBAT_RESIST";
    // Item
    public const string TITLE_LEVEL = TEXT_PREFIX + "TITLE_LEVEL";
    public const string TITLE_COLLECT_EXP = TEXT_PREFIX + "TITLE_COLLECT_EXP";
    public const string TITLE_EVOLVE_PRICE = TEXT_PREFIX + "TITLE_EVOLVE_PRICE";
    public const string TITLE_NEXT_EXP = TEXT_PREFIX + "TITLE_NEXT_EXP";
    public const string TITLE_REQUIRE_EXP = TEXT_PREFIX + "TITLE_REQUIRE_EXP";
    public const string TITLE_PRICE = TEXT_PREFIX + "TITLE_PRICE";
    public const string TITLE_REWARD_EXP = TEXT_PREFIX + "TITLE_REWARD_EXP";
    public const string TITLE_BATTLE_POINT = TEXT_PREFIX + "TITLE_BATTLE_POINT";
    public const string TITLE_LEVEL_UP_PRICE = TEXT_PREFIX + "TITLE_LEVEL_UP_PRICE";
    // Attribute titles
    public const string TITLE_EXP_MAX = TEXT_PREFIX + "TITLE_EXP_MAX";
    public const string TITLE_ATTRIBUTE_HP = TEXT_PREFIX + "TITLE_ATTRIBUTE_HP";
    public const string TITLE_ATTRIBUTE_PATK = TEXT_PREFIX + "TITLE_ATTRIBUTE_PATK";
    public const string TITLE_ATTRIBUTE_PDEF = TEXT_PREFIX + "TITLE_ATTRIBUTE_PDEF";
    public const string TITLE_ATTRIBUTE_MATK = TEXT_PREFIX + "TITLE_ATTRIBUTE_MATK";
    public const string TITLE_ATTRIBUTE_MDEF = TEXT_PREFIX + "TITLE_ATTRIBUTE_MDEF";
    public const string TITLE_ATTRIBUTE_SPD = TEXT_PREFIX + "TITLE_ATTRIBUTE_SPD";
    public const string TITLE_ATTRIBUTE_EVA = TEXT_PREFIX + "TITLE_ATTRIBUTE_EVA";
    public const string TITLE_ATTRIBUTE_ACC = TEXT_PREFIX + "TITLE_ATTRIBUTE_ACC";
    public const string TITLE_ATTRIBUTE_HP_RATE = TEXT_PREFIX + "TITLE_ATTRIBUTE_HP_RATE";
    public const string TITLE_ATTRIBUTE_PATK_RATE = TEXT_PREFIX + "TITLE_ATTRIBUTE_PATK_RATE";
    public const string TITLE_ATTRIBUTE_PDEF_RATE = TEXT_PREFIX + "TITLE_ATTRIBUTE_PDEF_RATE";
    public const string TITLE_ATTRIBUTE_MATK_RATE = TEXT_PREFIX + "TITLE_ATTRIBUTE_MATK_RATE";
    public const string TITLE_ATTRIBUTE_MDEF_RATE = TEXT_PREFIX + "TITLE_ATTRIBUTE_MDEF_RATE";
    public const string TITLE_ATTRIBUTE_SPD_RATE = TEXT_PREFIX + "TITLE_ATTRIBUTE_SPD_RATE";
    public const string TITLE_ATTRIBUTE_EVA_RATE = TEXT_PREFIX + "TITLE_ATTRIBUTE_EVA_RATE";
    public const string TITLE_ATTRIBUTE_ACC_RATE = TEXT_PREFIX + "TITLE_ATTRIBUTE_ACC_RATE";
    public const string TITLE_ATTRIBUTE_CRIT_CHANCE = TEXT_PREFIX + "TITLE_ATTRIBUTE_CRIT_CHANCE";
    public const string TITLE_ATTRIBUTE_CRIT_DAMAGE_RATE = TEXT_PREFIX + "TITLE_ATTRIBUTE_CRIT_DAMAGE_RATE";
    public const string TITLE_ATTRIBUTE_BLOCK_CHANCE = TEXT_PREFIX + "TITLE_ATTRIBUTE_BLOCK_CHANCE";
    public const string TITLE_ATTRIBUTE_BLOCK_DAMAGE_RATE = TEXT_PREFIX + "TITLE_ATTRIBUTE_BLOCK_DAMAGE_RATE";
    public const string TITLE_ATTRIBUTE_RESISTANCE_CHANCE = TEXT_PREFIX + "TITLE_ATTRIBUTE_RESISTANCE";
    public const string TITLE_ATTRIBUTE_BLOOD_STEAL_RATE_BY_PATK = TEXT_PREFIX + "TITLE_ATTRIBUTE_BLOOD_STEAL_RATE_BY_PATK";
    public const string TITLE_ATTRIBUTE_BLOOD_STEAL_RATE_BY_MATK = TEXT_PREFIX + "TITLE_ATTRIBUTE_BLOOD_STEAL_RATE_BY_MATK";
    // Warn
    public const string WARN_TITLE_DELETE_FRIEND = TEXT_PREFIX + "WARN_TITLE_DELETE_FRIEND";
    public const string WARN_DESCRIPTION_DELETE_FRIEND = TEXT_PREFIX + "WARN_DESCRIPTION_DELETE_FRIEND";
    public const string WARN_TITLE_DELETE_REQUEST = TEXT_PREFIX + "WARN_TITLE_DELETE_REQUEST";
    public const string WARN_DESCRIPTION_DELETE_REQUEST = TEXT_PREFIX + "WARN_DESCRIPTION_DELETE_REQUEST";
    public const string WARN_TITLE_DELETE_CLAN_MEMBER = TEXT_PREFIX + "WARN_TITLE_DELETE_CLAN_MEMBER";
    public const string WARN_DESCRIPTION_DELETE_CLAN_MEMBER = TEXT_PREFIX + "WARN_DESCRIPTION_DELETE_CLAN_MEMBER";
    public const string WARN_TITLE_CLAN_OWNER_TRANSFER = TEXT_PREFIX + "WARN_TITLE_CLAN_OWNER_TRANSFER";
    public const string WARN_DESCRIPTION_CLAN_OWNER_TRANSFER = TEXT_PREFIX + "WARN_DESCRIPTION_CLAN_OWNER_TRANSFER";
    public const string WARN_TITLE_CLAN_SET_ROLE_TO_MEMBER = TEXT_PREFIX + "WARN_TITLE_CLAN_SET_ROLE_TO_MEMBER";
    public const string WARN_DESCRIPTION_CLAN_SET_ROLE_TO_MEMBER = TEXT_PREFIX + "WARN_DESCRIPTION_CLAN_SET_ROLE_TO_MEMBER";
    public const string WARN_TITLE_CLAN_SET_ROLE_TO_MANAGER = TEXT_PREFIX + "WARN_TITLE_CLAN_SET_ROLE_TO_MANAGER";
    public const string WARN_DESCRIPTION_CLAN_SET_ROLE_TO_MANAGER = TEXT_PREFIX + "WARN_DESCRIPTION_CLAN_SET_ROLE_TO_MANAGER";
    public const string WARN_TITLE_DELETE_CLAN_JOIN_REQUEST = TEXT_PREFIX + "WARN_TITLE_DELETE_CLAN_JOIN_REQUEST";
    public const string WARN_DESCRIPTION_DELETE_CLAN_JOIN_REQUEST = TEXT_PREFIX + "WARN_DESCRIPTION_DELETE_CLAN_JOIN_REQUEST";
    public const string WARN_TITLE_CLAN_TERMINATE = TEXT_PREFIX + "WARN_TITLE_CLAN_TERMINATE";
    public const string WARN_DESCRIPTION_CLAN_TERMINATE = TEXT_PREFIX + "WARN_DESCRIPTION_CLAN_TERMINATE";
    public const string WARN_TITLE_CLAN_EXIT = TEXT_PREFIX + "WARN_TITLE_CLAN_EXIT";
    public const string WARN_DESCRIPTION_CLAN_EXIT = TEXT_PREFIX + "WARN_DESCRIPTION_CLAN_EXIT";
    public const string WARN_TITLE_REFILL_STAMINA = TEXT_PREFIX + "WARN_TITLE_REFILL_STAMINA";
    public const string WARN_DESCRIPTION_REFILL_STAMINA = TEXT_PREFIX + "WARN_DESCRIPTION_REFILL_STAMINA";
    // Formats
    public const string FORMAT_INFO = FORMAT_PREFIX + "FORMAT_INFO";
    public const string FORMAT_ATTRIBUTE = FORMAT_PREFIX + "FORMAT_ATTRIBUTE";
    public const string FORMAT_BONUS = FORMAT_PREFIX + "FORMAT_BONUS";
}

public static class DefaultLocale
{
    public static readonly Dictionary<string, string> Texts = new Dictionary<string, string>();
    static DefaultLocale()
    {
        Texts.Add(GameText.TITLE_INFO_DIALOG, "ข้อมูล");
        Texts.Add(GameText.TITLE_ERROR_DIALOG, "Error");
        Texts.Add(GameText.TITLE_PROFILE_NAME_DIALOG, "ชื่อ");
        Texts.Add(GameText.CONTENT_PROFILE_NAME_DIALOG, "ใส่ชื่อของคุณ");
        Texts.Add(GameText.PLACE_HOLDER_PROFILE_NAME, "ใส่ชื่อของคุณ...");
        Texts.Add(GameText.TITLE_SOFT_CURRENCY, "ทอง");
        Texts.Add(GameText.TITLE_HARD_CURRENCY, "อัญมณี");
        Texts.Add(GameText.TITLE_STAGE_STAMINA, "กุญแจ");
        Texts.Add(GameText.TITLE_ARENA_STAMINA, "กุญแจ อารีน่า");
        // Combat
        Texts.Add(GameText.COMBAT_MISS, "Miss");
        // Item
        Texts.Add(GameText.TITLE_LEVEL, "Level");
        Texts.Add(GameText.TITLE_COLLECT_EXP, "Collect Exp");
        Texts.Add(GameText.TITLE_EVOLVE_PRICE, "Evolve Price");
        Texts.Add(GameText.TITLE_NEXT_EXP, "Next Exp");
        Texts.Add(GameText.TITLE_REQUIRE_EXP, "Require Exp");
        Texts.Add(GameText.TITLE_PRICE, "Price");
        Texts.Add(GameText.TITLE_REWARD_EXP, "Reward Exp");
        Texts.Add(GameText.TITLE_BATTLE_POINT, "Battle Point");
        Texts.Add(GameText.TITLE_LEVEL_UP_PRICE, "Level Up Price");
        // Attributes
        Texts.Add(GameText.TITLE_EXP_MAX, "Max");
        Texts.Add(GameText.TITLE_ATTRIBUTE_HP, "พลังชีวิต");
        Texts.Add(GameText.TITLE_ATTRIBUTE_PATK, "พลังโจมตีกายภาพ");
        Texts.Add(GameText.TITLE_ATTRIBUTE_PDEF, "พลังป้องกันกายภาพ");
        Texts.Add(GameText.TITLE_ATTRIBUTE_MATK, "พลังโจมตีเวทย์");
        Texts.Add(GameText.TITLE_ATTRIBUTE_MDEF, "พลังป้องกันเวทย์");
        Texts.Add(GameText.TITLE_ATTRIBUTE_SPD, "ความเร็วโจมตี");
        Texts.Add(GameText.TITLE_ATTRIBUTE_EVA, "หลบหลีก");
        Texts.Add(GameText.TITLE_ATTRIBUTE_ACC, "ความแม่นยำ");
        Texts.Add(GameText.TITLE_ATTRIBUTE_HP_RATE, "อัตรา พลังชีวิต");
        Texts.Add(GameText.TITLE_ATTRIBUTE_PATK_RATE, "อัตรา พลังโจมตีกายภาพ");
        Texts.Add(GameText.TITLE_ATTRIBUTE_PDEF_RATE, "อัตรา พลังป้องกันกายภาพ");
        Texts.Add(GameText.TITLE_ATTRIBUTE_MATK_RATE, "อัตรา พลังโจมตีเวทย์");
        Texts.Add(GameText.TITLE_ATTRIBUTE_MDEF_RATE, "อัตรา พลังป้องกันเวทย์");
        Texts.Add(GameText.TITLE_ATTRIBUTE_SPD_RATE, "อัตรา ความเร็วโจมตี");
        Texts.Add(GameText.TITLE_ATTRIBUTE_EVA_RATE, "อัตรา หลบหลีก");
        Texts.Add(GameText.TITLE_ATTRIBUTE_ACC_RATE, "อัตรา ความแม่นยำ");
        Texts.Add(GameText.TITLE_ATTRIBUTE_CRIT_CHANCE, "โอกาสคริติคอล");
        Texts.Add(GameText.TITLE_ATTRIBUTE_CRIT_DAMAGE_RATE, "อัตราความเสียหายคริติคอล");
        Texts.Add(GameText.TITLE_ATTRIBUTE_BLOCK_CHANCE, "โอกาสบล็อค");
        Texts.Add(GameText.TITLE_ATTRIBUTE_BLOCK_DAMAGE_RATE, "อัตราบล็อกความเสียหาย");
        Texts.Add(GameText.TITLE_ATTRIBUTE_RESISTANCE_CHANCE, "ความต้านทาน");
        Texts.Add(GameText.TITLE_ATTRIBUTE_BLOOD_STEAL_RATE_BY_PATK, "อัตราดูดเลือดด้วยพลังโจมตีกายภาพ");
        Texts.Add(GameText.TITLE_ATTRIBUTE_BLOOD_STEAL_RATE_BY_MATK, "อัตราดูดเลือดด้วยพลังป้องกันเวทย์");
        // Warn
        Texts.Add(GameText.WARN_TITLE_DELETE_FRIEND, "ลบเพื่อน");
        Texts.Add(GameText.WARN_DESCRIPTION_DELETE_FRIEND, "คุณต้องการลบผู้เล่นนี้ออกจากรายชื่อเพื่อนของคุณหรือไม่?");
        Texts.Add(GameText.WARN_TITLE_DELETE_REQUEST, "ลบคำขอเป็นเพื่อน");
        Texts.Add(GameText.WARN_DESCRIPTION_DELETE_REQUEST, "คุณต้องการลบคำขอเป็นเพื่อนนี้หรือไม่?");
        Texts.Add(GameText.WARN_TITLE_DELETE_CLAN_MEMBER, "แตะสมาชิก");
        Texts.Add(GameText.WARN_DESCRIPTION_DELETE_CLAN_MEMBER, "คุณต้องการแตะสมาชิกออกจากกิลด์หรือไม่?");
        Texts.Add(GameText.WARN_TITLE_CLAN_OWNER_TRANSFER, "โอนตำแหน่งหัวกิลด์");
        Texts.Add(GameText.WARN_DESCRIPTION_CLAN_OWNER_TRANSFER, "คุณต้องการโอนตำแหน่งหัวกิลด์ให้สมาชิกหรือไม่?");
        Texts.Add(GameText.WARN_TITLE_CLAN_SET_ROLE_TO_MEMBER, "ลดระดับ");
        Texts.Add(GameText.WARN_DESCRIPTION_CLAN_SET_ROLE_TO_MEMBER, "คุณต้องการลดระดับสมาชิกหรือไม่?");
        Texts.Add(GameText.WARN_TITLE_CLAN_SET_ROLE_TO_MANAGER, "เลื่อนตำแหน่ง");
        Texts.Add(GameText.WARN_DESCRIPTION_CLAN_SET_ROLE_TO_MANAGER, "คุณต้องการเลื่อนตำแหน่งสมาชิกหรือไม่?");
        Texts.Add(GameText.WARN_TITLE_DELETE_CLAN_JOIN_REQUEST, "ลบคำขอเข้าร่วมกิลด์");
        Texts.Add(GameText.WARN_DESCRIPTION_DELETE_CLAN_JOIN_REQUEST, "คุณต้องการลบคำขอเข้าร่วมกิลด์หรือไม่?");
        Texts.Add(GameText.WARN_TITLE_CLAN_TERMINATE, "ยุบกิลด์");
        Texts.Add(GameText.WARN_DESCRIPTION_CLAN_TERMINATE, "คุณต้องการยุบกิลด์หรือไม่?");
        Texts.Add(GameText.WARN_TITLE_CLAN_EXIT, "ออกจากกิลด์");
        Texts.Add(GameText.WARN_DESCRIPTION_CLAN_EXIT, "คุณต้องการที่จะออกจากกิลด์หรือไม่?");
        Texts.Add(GameText.WARN_TITLE_REFILL_STAMINA, "ฟื้นฟู กุญแจ");
        Texts.Add(GameText.WARN_DESCRIPTION_REFILL_STAMINA, "คุณต้องการฟื้นฟูกุญแจหรือไม่?");
        // Format
        Texts.Add(GameText.FORMAT_INFO, "{0}{1}");
        Texts.Add(GameText.FORMAT_ATTRIBUTE, "{0}: {1}{2}");
        Texts.Add(GameText.FORMAT_BONUS, "{0}{1}");
        // Error texts
        Texts.Add(GameServiceErrorCode.EMPTY_USERNAME_OR_PASSWORD, "กรุณากรอกชื่อผู้ใช้หรือรหัสผ่าน");
        Texts.Add(GameServiceErrorCode.EXISTED_USERNAME, "ชื่อผู้ใช้นี้ถูกใช้ไปแล้ว");
        Texts.Add(GameServiceErrorCode.EMPTY_PROFILE_NAME, "Name is empty");
        Texts.Add(GameServiceErrorCode.EMPTY_CLAN_NAME, "กรุณากรอกชื่ชื่อกิลด์");
        Texts.Add(GameServiceErrorCode.EXISTED_PROFILE_NAME, "กรุณากรอกชื่อผู้เล่น");
        Texts.Add(GameServiceErrorCode.INVALID_USERNAME_OR_PASSWORD, "ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง");
        Texts.Add(GameServiceErrorCode.INVALID_LOGIN_TOKEN, "โทเค็นการเข้าสู่ระบบไม่ถูกต้อง");
        Texts.Add(GameServiceErrorCode.INVALID_PLAYER_DATA, "ข้อมูลผู้เล่นไม่ถูกต้อง");
        Texts.Add(GameServiceErrorCode.INVALID_PLAYER_ITEM_DATA, "ข้อมูล player item ไม่ถูกต้อง");
        Texts.Add(GameServiceErrorCode.INVALID_ITEM_DATA, "ข้อมูล item ไม่ถูกต้อง");
        Texts.Add(GameServiceErrorCode.INVALID_FORMATION_DATA, "ข้อมูล formation ไม่ถูกต้อง");
        Texts.Add(GameServiceErrorCode.INVALID_STAGE_DATA, "ข้อมูล stage ไม่ถูกต้อง");
        Texts.Add(GameServiceErrorCode.INVALID_CLAN_DONATION_DATA, "ข้อมูลการบริจาคกิลด์ไม่ถูกต้อง");
        Texts.Add(GameServiceErrorCode.INVALID_STAGE_NOT_AVAILABLE, "stage ไม่สามารถเข้าได้");
        Texts.Add(GameServiceErrorCode.INVALID_LOOT_BOX_DATA, "ข้อมูล loot box ไม่ถูกต้อง");
        Texts.Add(GameServiceErrorCode.INVALID_IAP_PACKAGE_DATA, "ข้อมูล IAP package ไม่ถูกต้อง");
        Texts.Add(GameServiceErrorCode.INVALID_IN_GAME_PACKAGE_DATA, "ข้อมูล In-game package ไม่ถูกต้อง");
        Texts.Add(GameServiceErrorCode.INVALID_ACHIEVEMENT_DATA, "ข้อมูลความสำเร็จไม่ถูกต้อง");
        Texts.Add(GameServiceErrorCode.INVALID_ITEM_CRAFT_FORMULA_DATA, "ข้อมูลการสร้างไอเท็มไม่ถูกต้อง");
        Texts.Add(GameServiceErrorCode.INVALID_CURRENCY_DATA, "ข้อมูลเงินไม่ถูกต้อง");
        Texts.Add(GameServiceErrorCode.INVALID_STAMINA_DATA, "ข้อมูลกุญแจไม่ถูกต้อง");
        Texts.Add(GameServiceErrorCode.INVALID_EQUIP_POSITION, "ตำแหน่งสวมใส่อุปกรณ์ไม่ถูกต้อง");
        Texts.Add(GameServiceErrorCode.INVALID_BATTLE_SESSION, "เซสชั่นการต่อสู้ไม่ถูกต้อง");
        Texts.Add(GameServiceErrorCode.NOT_ENOUGH_CURRENCY, "เหรียญกิลด์ไม่เพียงพอ");
        Texts.Add(GameServiceErrorCode.NOT_ENOUGH_SOFT_CURRENCY, Texts[GameText.TITLE_SOFT_CURRENCY] + " ไม่เพียงพอ");
        Texts.Add(GameServiceErrorCode.NOT_ENOUGH_HARD_CURRENCY, Texts[GameText.TITLE_HARD_CURRENCY] + " ไม่เพียงพอ");
        Texts.Add(GameServiceErrorCode.NOT_ENOUGH_STAGE_STAMINA, Texts[GameText.TITLE_STAGE_STAMINA] + " ไม่เพียงพอ");
        Texts.Add(GameServiceErrorCode.NOT_ENOUGH_ARENA_STAMINA, Texts[GameText.TITLE_ARENA_STAMINA] + " ไม่เพียงพอ");
        Texts.Add(GameServiceErrorCode.NOT_ENOUGH_ITEMS, "วัตถุดิบไม่เพียงพอ");
        Texts.Add(GameServiceErrorCode.ACHIEVEMENT_UNDONE, "ความสำเร็จยังไม่เสร็จ");
        Texts.Add(GameServiceErrorCode.ACHIEVEMENT_EARNED, "รางวัลความสำเร็จที่ได้รับ");
        Texts.Add(GameServiceErrorCode.CANNOT_EVOLVE, "วิวัฒนาการไม่ได้");
        Texts.Add(GameServiceErrorCode.CANNOT_REFILL_STAMINA, "ฟื้นฟู กุญแจ ไม่ได้");
        Texts.Add(GameServiceErrorCode.NOT_AVAILABLE, "ไม่มีบริการ");
        Texts.Add(GameServiceErrorCode.CANNOT_RECEIVE_ALL_ITEMS, "ไม่สามารถรับไอเท็มได้ทั้งหมด");
        Texts.Add(GameServiceErrorCode.JOINED_CLAN, "เข้าร่วมกิลด์แล้ว");
        Texts.Add(GameServiceErrorCode.NOT_JOINED_CLAN, "ไม่เข้าร่วมกิลด์");
        Texts.Add(GameServiceErrorCode.NOT_HAVE_PERMISSION, "คุณไม่ได้รับอนุญาต");
        Texts.Add(GameServiceErrorCode.CLAN_OWNER_CANNOT_EXIT, "หัวหน้ากิลด์ออกจากกิลด์ไม่ได้");
        Texts.Add(GameServiceErrorCode.UNKNOW, "Unknow Error");
    }
}

[System.Serializable]
public class Language
{
    public string languageKey;
    public List<LanguageData> dataList = new List<LanguageData>();

    public bool ContainKey(string key)
    {
        foreach (LanguageData entry in dataList)
        {
            if (string.IsNullOrEmpty(entry.key))
                continue;
            if (entry.key.Equals(key))
                return true;
        }
        return false;
    }

    public static string GetText(IEnumerable<LanguageData> langs, string defaultValue)
    {
        if (langs != null)
        {
            foreach (LanguageData entry in langs)
            {
                if (string.IsNullOrEmpty(entry.key))
                    continue;
                if (entry.key.Equals(LanguageManager.CurrentLanguageKey))
                    return entry.value;
            }
        }
        return defaultValue;
    }
}

[System.Serializable]
public struct LanguageData
{
    public string key;
    [TextArea]
    public string value;
}
 