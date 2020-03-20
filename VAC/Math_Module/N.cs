﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Module
{
    public class N : Math_Field
    {

        #region Поля

        private List<uint> znach;

        private const uint uint_size = 99999999;
        private const uint uint_size_div = 8;

        #endregion

        #region Конструторы

        public N(List<string> s) // Александр Рассохин 9370
        {
            znach = new List<uint>();
            for (int i = s.Count-1; i >= 0; i--)
                znach.Add(Convert.ToUInt32(s[i]));
        }

        #endregion

        #region Свойства

        protected override bool isDown // Евгений Куликов 9370
        {
            get
            {
                return false;
            }
        }
        private bool NZER_N_B // Проверка на ноль - Шлемин Роман 9370
        {
            get
            {
                if ((znach.Count == 1)&&(znach[0] == 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<uint> Znach //Необходимость релизации под вопросом
        {
            get
            {
                return null;
            }
        }

        #endregion

        #region Перегрузки

        public static N operator ++(N value) // Александр Баталин 9370
        {
           for (int i = 0; i < value.znach.Count; i++)
           {
                if (value.znach[i] == uint_size)
                {
                    value.znach[i] = 0;
                }
                else
                {
                    value.znach[i]++;
                    return value;
                }
           }
            value.znach.Add(1);
            return value;
        }

        public static N operator +(N first, N second) // Шлемин Роман 9370
        {
            return null;
        }

        public static N operator -(N first, N second) // Шлемин Роман 9370
        {
            return null;
        }

        public static N operator *(N first, N second)
        {
            return null;
        }

        public static N operator /(N first, N second)
        {
            return null;
        }

        public static N operator %(N first, N second)
        {
            return null;
        }

        public static implicit operator List<string>(N value) // Александр Рассохин 9370
        {
            List<string> S = new List<string>();
        List<uint> temp = new List<uint>(new uint[value.znach.Count]);
        temp = value.znach;
        S = temp.ConvertAll<string>(delegate (uint i) { return i.ToString(); });
        StringBuilder temp = new StringBuilder();
        int i;
        for (i = 0; i < value.znach.Count / uint_size_div; i++) // Цикл выполняется столько раз, сколько разрядов uint_size_div входит в число
        {
            for (long j = value.znach.Count - 1 - (uint_size_div * i); j >= value.znach.Count - uint_size_div * (i + 1); j--) // каждый цикл у числа забираются следующие uint_size_div разрядов
                temp.Append(Convert.ToString(value.znach[Convert.ToInt32(j)]));     // построение временной string, куда будут записываться эти uint_size_div разрядов

            S.Add(Convert.ToString(temp));  // добавление построенной string в элемент списка
            temp.Clear();                   // очищение временной строки
        }

        if (value.znach.Count % uint_size_div != 0)     // запись в строку оставшихся разрядов, если число не делится на uint_div_size нацело
        {
            for (long j = value.znach.Count - 1 - (uint_size_div * i); j >= 0; j--) // цикл, для записи оставшихся разрядов
                temp.Append(Convert.ToString(value.znach[Convert.ToInt32(j)]));     // построение временной string с элементами числа
            S.Add(Convert.ToString(temp));                                          // добавление построенной string в элемент списка
        }
        return S;
    }
        }

        public static implicit operator Z(N value)
        {
            return null;
        }

        #endregion

        #region Методы

        private static byte COM_NN_D(N first, N second) // Сравнение двух чисел - Шлемин Роман 9370
        {
            if (first.znach.Count > second.znach.Count)
            {
                return 2;
            }
            if (first.znach.Count < second.znach.Count)
            {
                return 1;
            }
            for (int i = first.znach.Count; i == 0;i--)
            {
                if (first.znach[i] <= second.znach[i])
                    {
                    if (first.znach[i] != second.znach[i])
                    {
                        return 1;
                    }
                }
                else
                {
                    return 2;
                }
            }
            return 0;
        }

        private N MUL_ND_N(byte value) // Умножеине числа на цифру - Дмитрий Панченко 9370
        {
            return null;
        }

        private N MUL_Nk_N(N value) // Умножение числа на 10^value - Дмитрий Панченко 9370
        {
            return null;
        }

        private static N SUB_NDN_N(N first, N second, byte k)
        {
            return null;
        }

        private static N DIV_NN_Dk(N first, N second)
        {
            return null;
        }

        public static N GCF_NN_N(N first, N second)
        {
            return null;
        }

        public static N LCM_NN_N(N first, N second)
        {
            return null;
        }

        public N Clone() // Александр Баталин 9370
        {
            return null;
        }

        #endregion
    }
}
