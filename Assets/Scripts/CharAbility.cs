using System.Collections;
using System.Collections.Generic;

public interface ICharAbility  {
    int HP { get; }//血量
    int ATK{ get; }//攻击力
    int DEF{ get; }//防御力
    int SPD{ get; }//速度
    int CriRate{ get; }//暴击率
    int CriDmag{ get; }//暴击伤害
    int Resistance{ get; }//效果抵抗
    int Accuracy{ get; }//效果命中
    
}
