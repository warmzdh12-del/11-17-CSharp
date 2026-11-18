using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2026 11/18
// C# 프로그래밍 입문
// 학습 목표 : 화면에 내가 원하는 글자를 출력하고 싶다.

// 내가 어떤 크기에 어떤 물건을 넣어야 할지 딱 맞는 상자를 알려줄게 - type형태

//변수 
//정수 int
//실수 float
//문자열 string
// 불 bool

// 데이터 + 로직 =>
// 로직 :어떻게 진짜 게임이 끝난것처럼 표현이 될까요

// 두번째 학습 목표 : 변수를 변형해서 원하는 흐름을 얻기

// 조건문을 활용해서 아주 간단한 승리 조건을 표연해보세요.
namespace bacis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("게임에 들어오신것을 환영합니다.");
            Console.WriteLine("닉네임을 정해주세요.");

            int hp = 100;
            hp = hp - 100;

            float version = 1.01f;
            bool gameClear = false;


            Console.WriteLine(hp);
            Console.WriteLine(version);
            Console.WriteLine(gameClear);

            string name = Console.ReadLine();
            Console.WriteLine(name);

            // 그러면 당신의 이름이 뭔가요
            //슬라임의 체력 변수로 정의해보세요
            int sliemHP = 100;
             //의 체력
            int p_HP = 100;
            //스라임의 공격력
            int s_atk = 10;
            //용사의 공격력
            int p_atk = 20;

            Console.WriteLine("슬라임의 턴");
            p_HP = p_HP - s_atk;
            Console.WriteLine($"용사의 체력은{p_HP});

            if(true)
            {
                Console.WriteLine("출력이 되었나요?");
            }
        }
       
    }
}
