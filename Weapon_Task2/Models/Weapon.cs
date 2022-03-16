using System;
using System.Collections.Generic;
using System.Text;

namespace Weapon_Task2
{
    class Weapon
    {
        private int _bulletCapacity;
        private int _bulletCount;
        private int _dischargeSeconds;
        private bool _auto;

        public Weapon (int bulletCapacity, int bulletCount, double dischargeSeconds, bool auto)
            {
           
            bulletCapacity = bulletCapacity;
            bulletCapacity = bulletCount;
            dischargeSeconds = dischargeSeconds;
            auto = auto;

            }
                public void Shoot()
                {
                    if (_bulletCount > 0)
                    {
                        _bulletCount--;
                        Console.WriteLine("1 bullet was fired");
                    }
                    else
                    {
                        Console.WriteLine("no bullet left");
                    }
                }
                public void Fire()
                {
                    if (_bulletCount == 0)
                    {
                        Console.WriteLine("no bullets");
                    }
                    else
                    {
                        double time = _bulletCount * _dischargeSeconds / _bulletCapacity;
                        Console.WriteLine(time + "san");
                    }
                }

                public void GetRemainBulletCount()
                {
                    int required = 0;
                    required = _bulletCapacity - _bulletCount;
                    Console.WriteLine("How many bullets are left:" + required);
                }
                public void Reload()
                {
                    if (_bulletCapacity - _bulletCount == 0)
                    {
                        Console.WriteLine("the comb of the bullet is full");
                    }
                    else
                    {
                        Console.WriteLine($"{_bulletCapacity - _bulletCount}: + n add as many bullets");
                    }
                }
                public void ChangeFireMode()
                {
                    bool choice = bool.Parse(Console.ReadLine());
                    if (choice == true)
                    {
                        _auto = true;
                    }
                    else if (choice == false)
                    {
                        Console.WriteLine("There are no bullets in the weapon to make a choice");
                    }
                    else
                    {
                        Console.WriteLine("Make one of two choices");
                    }
                }
                public void GetInfo()
                {
                    Console.WriteLine($"bulletCapacity:{_bulletCapacity} bulletCount:{_bulletCount} dischargeSeconds:{_dischargeSeconds} auto:{_auto}");
                }
            }

        }
