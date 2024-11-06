using DesignPatternsFantasyRPG.ItemCreator.Models;

namespace DesignPatternsFantasyRPG.ItemCreator
{
    public abstract class ItemFacotry
    {
        public abstract Weapon CreateWeapon();
        public abstract Item CreatePotion();
        public abstract Item CreateArmor();
    }

    public class CommonItemFactory : ItemFacotry
    {
        public override Weapon CreateWeapon()
        {
            return new Weapon("Sword", "Basic sword", RarityEnum.Common, WeaponTypeEnum.Melee, 100);
        }

        public override Item CreatePotion()
        {
            throw new NotImplementedException();
        }

        public override Item CreateArmor()
        {
            throw new NotImplementedException();
        }
    }

    public class MagicItemFactory : ItemFacotry
    {
        public override Weapon CreateWeapon()
        {
            return new Weapon("Elfwood staff", "Magical staff", RarityEnum.Magic, WeaponTypeEnum.Ranged, 150);
        }

        public override Item CreatePotion()
        {
            throw new NotImplementedException();
        }

        public override Item CreateArmor()
        {
            throw new NotImplementedException();
        }
    }

    public class RareItemFactory : ItemFacotry
    {
        public override Weapon CreateWeapon()
        {
            return new Weapon("Golden bow", "Rare bow", RarityEnum.Rare, WeaponTypeEnum.Ranged, 200);
        }

        public override Item CreatePotion()
        {
            throw new NotImplementedException();
        }

        public override Item CreateArmor()
        {
            throw new NotImplementedException();
        }
    }

    public class LegendaryItemFactory : ItemFacotry
    {
        public override Weapon CreateWeapon()
        {
            return new Weapon("Punching gloves of the northern star", "Legendary gloves", RarityEnum.Legendary, WeaponTypeEnum.Melee, 9001);
        }

        public override Item CreatePotion()
        {
            throw new NotImplementedException();
        }

        public override Item CreateArmor()
        {
            throw new NotImplementedException();
        }
    }
}
