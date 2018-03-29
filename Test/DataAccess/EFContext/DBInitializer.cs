using System;
using System.Collections.Generic;
using Test.DataAccess.Entities;

namespace Test.DataAccess.EFContext
{
    public class DBInitializer
    {
        public static void Initialize(DBContext context)
        {
            context.Database.EnsureCreated();

            #region Tasks
            List<TaskModel> client1Tasks = new List<TaskModel>()
            {
                new TaskModel()
                {
                    Name = "Настройка RAID",
                    Description = "Установить на сервере RAID-контроллер adaptec 3805, подключить к нему 4 диска и настроить RAID5",
                    Address = "Киев",
                    StartDate = new DateTime(2018,04, 15),
                    EndDate = new DateTime(2018,05, 01)
                },
                new TaskModel()
                {
                    Name = "Организовать систему мониторинга сети",
                    Description = "Установка и настройка Zabbix сервера и агентов на все узлы сети",
                    Address = "Киев",
                    StartDate = new DateTime(2018, 04, 25),
                    EndDate = new DateTime(2018, 05, 02)
                },
                new TaskModel()
                {
                    Name = "Установка гипервизора",
                    Description = "Установить гипервизор ESXI-6.0 и перенести все физические сервера на виртуальные машины",
                    Address = "Киев",
                    StartDate = new DateTime(2018, 04, 13),
                    EndDate = new DateTime(2018, 04, 28)
                },
                new TaskModel()
                {
                    Name = "Автоматизация управления коммутаторами в биллинге",
                    Description = "Написать скрипты (Perl или Python) для управления коммутаторами (вкл/выкл порта, просмотр логов, перезагрузка) из системы биллинга",
                    Address = "Днепр",
                    StartDate = new DateTime(2018, 03, 24),
                    EndDate = new DateTime(2018, 03, 29)
                }
            };

            List<TaskModel> client2Tasks = new List<TaskModel>()
            {
                new TaskModel()
                {
                    Name = "Организация резервного копирования",
                    Description = "Установка и настройка сервера резервного копирования BackupPC для бекапа важной информации",
                    Address = "Львов",
                    StartDate = new DateTime(2018, 05, 01),
                    EndDate = new DateTime(2018, 05, 09)
                },
                new TaskModel()
                {
                    Name = "Настройка GSM-шлюза",
                    Description = "Произвести настройку GSM-шлюза GOIP4, с заранее установленными SIM-картами, для возможности осуществления звонков с сервера VoIP-телефонии",
                    Address = "Львов",
                    StartDate = new DateTime(2018, 05, 10),
                    EndDate = new DateTime(2018, 05, 24)
                },
                new TaskModel()
                {
                    Name = "Автоматизация управления коммутаторами в биллинге",
                    Description = "Написать скрипты (Perl или Python) для управления коммутаторами (вкл/выкл порта, просмотр логов, перезагрузка) из системы биллинга",
                    Address = "Львов",
                    StartDate = new DateTime(2018, 04, 04),
                    EndDate = new DateTime(2018, 04, 15)
                }
            };

            List<TaskModel> client3Tasks = new List<TaskModel>()
            {
                new TaskModel()
                {
                    Name = "Удаленный офис",
                    Description = "Установка сервера для удаленного офиса с двумя резервными линиями для выхода в Интернет",
                    Address = "Днепр",
                    StartDate = new DateTime(2018, 03, 25),
                    EndDate = new DateTime(2018, 03, 31)
                },
                new TaskModel()
                {
                    Name = "Организация резервного копирования",
                    Description = "Установка и настройка сервера резервного копирования BackupPC для бекапа важной информации",
                    Address = "Днепр",
                    StartDate = new DateTime(2018, 04, 25),
                    EndDate = new DateTime(2018, 04, 30)
                },
                new TaskModel()
                {
                    Name = "Настройка RAID",
                    Description = "Установить на сервере RAID-контроллер adaptec 3805, подключить к нему 4 диска и настроить RAID5",
                    Address = "Днепр",
                    StartDate = new DateTime(2018, 03, 26),
                    EndDate = new DateTime(2018, 04, 10)
                },
                new TaskModel()
                {
                    Name = "Настройка GSM-шлюза",
                    Description = "Произвести настройку GSM-шлюза GOIP4, с заранее установленными SIM-картами, для возможности осуществления звонков с сервера VoIP-телефонии",
                    Address = "Днепр",
                    StartDate = new DateTime(2018, 04, 12),
                    EndDate = new DateTime(2018, 04, 18)
                },
                new TaskModel()
                {
                    Name = "Установка гипервизора",
                    Description = "Установить гипервизор ESXI-6.0 и перенести все физические сервера на виртуальные машины",
                    Address = "Днепр",
                    StartDate = new DateTime(2018, 04, 01),
                    EndDate = new DateTime(2018, 04, 10)
                }
            };

            List<TaskModel> client4Tasks = new List<TaskModel>()
            {
                new TaskModel()
                {
                    Name = "Проведение инструктажа",
                    Description = "Организовывать тестирование и обучение сотрудников предприятия основам компьютерной грамотности и работе с прикладными программными средствами.",
                    Address = "Кировоград",
                    StartDate = new DateTime(2018,05, 11),
                    EndDate = new DateTime(2018,06, 01)
                },
                new TaskModel()
                {
                    Name = "Подключение и удаление аппаратных средств",
                    Description = "Выполнить конфигурацию системы после замены принтера Xerox 3540.",
                    Address = "Кировоград",
                    StartDate = new DateTime(2018, 05, 25),
                    EndDate = new DateTime(2018, 06, 02)
                }
            };

            List<TaskModel> client5Tasks = new List<TaskModel>()
            {
                new TaskModel()
                {
                    Name = "Подключение и удаление аппаратных средств",
                    Description = "Выполнить конфигурацию системы после замены принтера Epson L605",
                    Address = "Полтава",
                    StartDate = new DateTime(2018, 06, 01),
                    EndDate = new DateTime(2018, 06, 10)
                },
                new TaskModel()
                {
                    Name = "Удаленный офис",
                    Description = "установка сервера для удаленного офиса с двумя резервными линиями для выхода в Интернет",
                    Address = "Полтава",
                    StartDate = new DateTime(2018, 06, 10),
                    EndDate = new DateTime(2018, 06, 14)
                },
                new TaskModel()
                {
                    Name = "Проведение инструктажа",
                    Description = "Организовывать тестирование и обучение сотрудников предприятия основам компьютерной грамотности и работе с прикладными программными средствами.",
                    Address = "Полтава",
                    StartDate = new DateTime(2018, 04, 06),
                    EndDate = new DateTime(2018, 04, 13)
                }
            };

            List<TaskModel> client6Tasks = new List<TaskModel>()
            {
                new TaskModel()
                {
                    Name = "Настройка RAID",
                    Description = "Установить на сервере RAID-контроллер adaptec 3805, подключить к нему 4 диска и настроить RAID5",
                    Address = "Харьков",
                    StartDate = new DateTime(2018,04, 15),
                    EndDate = new DateTime(2018,05, 01)
                },
                new TaskModel()
                {
                    Name = "Установка гипервизора",
                    Description = "Установить гипервизор ESXI-6.0 и перенести все физические сервера на виртуальные машины",
                    Address = "Харьков",
                    StartDate = new DateTime(2018, 04, 13),
                    EndDate = new DateTime(2018, 04, 28)
                },
                new TaskModel()
                {
                    Name = "Мониторинг системы",
                    Description = "Проверка правильности функционирования электронной почты и телеконференций, просмотр регистрационных файлов на предмет наличия ранних признаков неисправностей, контроль за подключением локальных сетей, контроль за наличием системных ресурсов.",
                    Address = "Харьков",
                    StartDate = new DateTime(2018, 04, 25),
                    EndDate = new DateTime(2018, 05, 02)
                }                
            };

            List<TaskModel> client7Tasks = new List<TaskModel>()
            {
                new TaskModel()
                {
                    Name = "Подключение и удаление аппаратных средств",
                    Description = "Выполнить конфигурацию системы после замены принтера HP LaserJet Pro M130a",
                    Address = "Киев",
                    StartDate = new DateTime(2018, 04, 06),
                    EndDate = new DateTime(2018, 04, 09)
                },
                new TaskModel()
                {
                    Name = "Проведение инструктажа",
                    Description = "Организовывать тестирование и обучение сотрудников предприятия основам компьютерной грамотности и работе с прикладными программными средствами.",
                    Address = "Киев",
                    StartDate = new DateTime(2018, 04, 10),
                    EndDate = new DateTime(2018, 04, 14)
                }
            };

            #endregion

            #region Clients
            ClientModel client1 = new ClientModel()
            {
                FirstName = "Максим",
                LastName = "Коновалов",
                Address = "Киев",
                Phone = "43-50-56,01-23-45",
                Tasks = client1Tasks
            };
            ClientModel client2 = new ClientModel()
            {
                FirstName = "Евгения",
                LastName = "Доронина",
                Address = "Львов",
                Phone = "80970123456",
                Tasks = client2Tasks
            };
            ClientModel client3 = new ClientModel()
            {
                FirstName = "Денис",
                LastName = "Мельников",
                Address = "Днепр",
                Phone = "80960123456",
                Tasks = client3Tasks
            };
            ClientModel client4 = new ClientModel()
            {
                FirstName = "Олег",
                LastName = "Орехов",
                Address = "Кировоград",
                Phone = "8096012345,б453-56-78",
                Tasks = client4Tasks
            };
            ClientModel client5 = new ClientModel()
            {
                FirstName = "Денис",
                LastName = "Крюков",
                Address = "Полтава",
                Phone = "45-69-78,80991247841",
                Tasks = client5Tasks
            };
            ClientModel client6 = new ClientModel()
            {
                FirstName = "Валентина",
                LastName = "Гордеева",
                Address = "Харьков",
                Phone = "8056451432,45-89-78",
                Tasks = client6Tasks
            };
            ClientModel client7 = new ClientModel()
            {
                FirstName = "Екатерина",
                LastName = "Костина",
                Address = "Киев",
                Phone = "80504781245,89-54-21",
                Tasks = client7Tasks
            };
            #endregion

            context.Clients.Add(client1);
            context.Clients.Add(client2);
            context.Clients.Add(client3);
            context.Clients.Add(client4);
            context.Clients.Add(client5);
            context.Clients.Add(client6);
            context.Clients.Add(client7);

            context.SaveChanges();
        }
    }
}
