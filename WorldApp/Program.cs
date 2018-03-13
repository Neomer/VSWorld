using Shop.SDK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WorldApp.Models;
using WorldApp.Models.Managers;

namespace WorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var appPath = Assembly.GetExecutingAssembly().Location;
            NHibernateHelper.Instance.Initialize(appPath.Substring(0, appPath.LastIndexOf("\\")));
            Program.GenerateModels();

        }

        private static void GenerateModels()
        {
            /*
            var races = new List<Race>();
            races.Add(new Race() { ID = Guid.NewGuid(), Name = "Люди", Description = "Самая многочисленная из населяющих Континент рас, которая мало-помалу «выживает» иные расы и становится полноправным и единственным хозяином всего мира." });
            races.Add(new Race() { ID = Guid.NewGuid(), Name = "Краснолюды", Description = "Одна из древнейших рас, прибывших в ходе Сопряжения Сфер на Континент. Родственна гномам, ее представители — невысокие, широкоплечие, кряжистые и коренастые карлики с длинными бородами. Краснолюды обладают невероятными выносливостью, стойкостью и силой, они неприхотливы, дисциплинированы и яростны в бою, а потому являются отличными воинами и солдатами. Краснолюды лучше других рас сотрудничают и уживаются с людьми. Эта раса имеет имеет склонность к шахтерскому, столярному и кузнечному делу, а благодаря врожденному предпринимательскому чутью краснолюды успешно занимаются любым бизнесом — от банковского дела до содержания таверн и публичных домов." });
            races.Add(new Race() { ID = Guid.NewGuid(), Name = "Гномы", Description = "Самая древняя из прибывших в ходе Сопряжения Сфер раса, родственная краснолюдам. Ее представители похожи на них и являются невысокими карликами, но уступают им в росте, не носят бороды и имеют очень длинные носы. Они обладают склонностью и талантом к шахтерскому и столярному делу, а также завидной комерческой хваткой." });
            races.Add(new Race() { ID = Guid.NewGuid(), Name = "Эльфы", Description = "Немногочисленная раса долгожителей с развитой культурой, науками, магией и архитектурой, причем Континент населяет только Народ Гор. Эльфы — высокие создания, отличающиеся тонкими чертами лица и «острыми» ушами, они гордые и умелые воины, талантливые чародеи и мастеровые. Ныне они вымирают, поскольку не способны выдержать видовую конкуренцию с людьми и при этом не желают сотрудничать и хоть как-то взаимодействовать с ними." });
            races.Add(new Race() { ID = Guid.NewGuid(), Name = "Низушки", Description = "Раса невысоких, ловких безбородых человечков, покрытых на большей части тела густой и мягкой шерстью. О них мало что известно. Низушки, в большинстве своем, живут в людских городах или деревнях и являются успешными предпринимателями." });
            races.Add(new Race() { ID = Guid.NewGuid(), Name = "Дриады", Description = "Похожая внешне и по культуре на эльфов малочисленная раса, обитающая в Брокилоне. У дриад нет самцов, и новые дриады рождаются от союзов с лучшими, по их мнению, представителями людей и эльфов. Они тесно связаны с природой и местом своего обитания и мало контактируют с иными расами." });
            races.Add(new Race() { ID = Guid.NewGuid(), Name = "Вампиры", Description = "Группа относительно разнородных существ, прибывших на Континент в ходе Сопряжения Сфер и объединенных жаждой крови иных рас этот мира, особенно человеческой. Низшие вампиры — типичные неразумные чудовища, убивающие любых представителей иных видов, в то время как вампиры переходных стадий и высшие вампиры человекоподобны и разумны, в случае вторых — даже более интеллектуально развиты, чем люди, причем им иногда удается жить в человеческом сообществе." });
            Program.SaveCollection(races);

            var items = new List<Item>();
            items.Add(new Item() { ID = Guid.NewGuid(), Name = "Ветка", Description = "Раньше была частью дерева", EqipSlot = Slot.None, Type = Models.Type.Resource, Weight = 0.030, IsDestroyable = true, IsDroppable = true, IsEquippable = false, IsStackable = true });
            items.Add(new Item() { ID = Guid.NewGuid(), Name = "Трава", Description = "Естественный природный ковер", EqipSlot = Slot.None, Type = Models.Type.Resource, Weight = 0.005, IsDestroyable = true, IsDroppable = true, IsEquippable = false, IsStackable = true });
            items.Add(new Item() { ID = Guid.NewGuid(), Name = "Охотничий нож", Description = "Короткий нож - универсальное оружие, позволяющее как набрать веток, так и поохотиться на небольших животных.", EqipSlot = Slot.RightHand, Type = Models.Type.Weapon, Weight = 0.1, IsDestroyable = true, IsDroppable = true, IsEquippable = true, IsStackable = false });
            items.Add(new Item() { ID = Guid.NewGuid(), Name = "Легкий лук", Description = "Небольшой лук, вырезанный не из самых подходящих пород деревьев. Хороший выбор для путешественника, которому не из чего выбирать.", EqipSlot = Slot.BothHand, Type = Models.Type.Weapon, Weight = 0.084, IsDestroyable = true, IsDroppable = true, IsEquippable = true, IsStackable = false });
            items.Add(new Item() { ID = Guid.NewGuid(), Name = "Короткий деревянный меч", Description = "", EqipSlot = Slot.RightHand, Type = Models.Type.Weapon, Weight = 0.075, IsDestroyable = true, IsDroppable = true, IsEquippable = true, IsStackable = false });
            Program.SaveCollection(items);

            var neutrals = new List<Neutral>();
            neutrals.Add(new Neutral() { ID = Guid.NewGuid(), Name = "Заяц", Description = "Абсолютно безобидное животное не представляющее никому угрозы.", IsImmortal = false, IsAggressive = false, IsAttackable = true, Level = 1, Health = 10, Mana = 1, Experience = 1, Inventory = null, IsImmobile = false, SpawnX = 0, SpawnY = 0, MovingDistance = 10 });
            neutrals.Add(new Neutral() { ID = Guid.NewGuid(), Name = "Волк", Description = "Волк", IsImmortal = false, IsAggressive = true, IsAttackable = true, Level = 2, Health = 20, Mana = 1, Experience = 5, Inventory = null, IsImmobile = false, SpawnX = 0, SpawnY = 0, MovingDistance = 10 });
            neutrals.Add(new Neutral() { ID = Guid.NewGuid(), Name = "Помощник", Description = "Помощник для всех новичков.", IsImmortal = true, IsAggressive = false, IsAttackable = false, IsImmobile = true, Level = 0, Health = 0, Mana = 0, Experience = 0, Inventory = null, SpawnX = 10, SpawnY = 10, MovingDistance = 0 });
            Program.SaveCollection(neutrals);
            */

        }

        private static void SaveCollection(IEnumerable<IEntity> list)
        {
            var session = NHibernateHelper.Instance.GetCurrentSession();
            using (var tr = session.BeginTransaction())
            {
                try
                {
                    foreach (var item in list)
                    {
                        session.Save(item);
                    }
                    tr.Commit();
                }
                catch (Exception ex)
                {
                    tr.Rollback();

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
