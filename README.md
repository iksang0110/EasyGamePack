# Git 협업 가이드

## 브랜치 전략
```
main - 최종 릴리즈용
  ├── feature/main - 게임 선택 메인 화면
  ├── feature/omok - 오목 게임
  ├── feature/tictactoe - 틱택톡 게임
  ├── feature/tetris - 테트리스 게임
  ├── feature/blackjack - 블랙잭 게임
  └── feature/memory - 기억력 게임
```

## 개발 프로세스
1. 자신의 feature 브랜치 생성
```bash
git checkout -b feature/[game-name]
```

2. 작업 전 최신 코드 동기화
```bash
git checkout main
git pull origin main
git checkout feature/[game-name]
git merge main
```

3. 작업 후 커밋 & 푸시
```bash
git add .
git commit -m "feat: [작업내용]"
git push origin feature/[game-name]
```

## Pull Request 규칙
1. PR 템플릿
```markdown
## 변경 사항
- 구현한 기능 설명
- 변경된 파일 목록

## 스크린샷
- 필요한 경우 추가

## 테스트 체크리스트
- [ ] 게임 실행 테스트
- [ ] 메인 화면 연동 테스트
- [ ] 버그 체크

## 리뷰어
@담당자이름
```

2. PR은 최소 1명 이상의 리뷰어 승인 필요
3. Merge는 리뷰 승인 후 진행

## Issue 규칙
1. Issue 템플릿
```markdown
## 이슈 내용
- 문제점 또는 기능 요청 설명

## 해결 방안 (선택)
- 제안하는 해결 방법

## 참고 사항
- 관련 코드나 스크린샷
```

## Commit Message Convention
```
type: subject

body (선택)

footer (선택)
```

### Type
- `feat`: 새로운 게임 기능 추가
- `fix`: 버그 수정
- `refactor`: 코드 리팩토링
- `style`: 코드 포맷팅
- `docs`: 문서 수정
- `test`: 테스트 코드
- `chore`: 빌드, 설정 변경

### 예시
```
feat: 오목 게임 메인화면 연동 구현

- 시작하기 버튼 클릭 시 오목 게임 실행
- 게임 종료 시 메인화면 복귀 기능 추가

Resolves: #123
```

## 작업 순서 예시
1. 첫 번째 개발자 (메인 화면)
```bash
git checkout -b feature/main
# 작업 수행
git add .
git commit -m "feat: 게임 선택 메인 화면 구현"
git push origin feature/main
# PR 생성 및 merge
```

2. 두 번째 개발자 (오목)
```bash
git checkout main
git pull origin main
git checkout -b feature/omok
# 작업 수행
git add .
git commit -m "feat: 오목 게임 구현 및 메인화면 연동"
git push origin feature/omok
# PR 생성 및 merge
```

3. 나머지 개발자들도 동일한 방식으로 진행

## 주의사항
- 작업 전 반드시 main 브랜치의 최신 상태 확인
- 충돌 발생 시 팀원과 상의 후 해결
- 커밋 메시지는 명확하고 상세하게 작성
- PR 시 반드시 테스트 후 제출


# 이지게임팩 (EasyGamePack)
## 원광대학교 윈도우프로그래밍 6조 프로젝트

<div align="center">
  <img src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white">
  <img src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white">
  <img src="https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white">
</div>

## 📌 프로젝트 소개
**이지게임팩**은 C# Windows Forms를 사용하여 개발한 5가지 미니게임 모음입니다. 각각의 게임은 독특한 특징과 게임성을 가지고 있으며, 사용자 친화적인 인터페이스를 통해 누구나 쉽게 즐길 수 있습니다.

## 🎮 게임 구성
1. **오목**
   - 인공지능과 대결하는 1:1 오목 게임
   - 3단계 난이도 시스템 (쉬움/보통/어려움)
   - 개발자: 정익상

2. **틱택톡**
   - 3x3 격자판에서 진행되는 전략 게임
   - 개발자: 양우혁

3. **테트리스**
   - 클래식 블록 쌓기 게임
   - 개발자: 김수호

4. **블랙잭**
   - 딜러와 대결하는 카드 게임
   - 개발자: 최이지

5. **기억력 게임**
   - 카드 짝 맞추기를 통한 두뇌 훈련 게임
   - 개발자: 조효민

## 🛠️ 기술 스택
- **언어:** C#
- **프레임워크:** .NET Framework, Windows Forms
- **개발도구:** Visual Studio 2022
- **버전관리:** Git, GitHub

## 🌟 주요 기능
- 통합 로그인 시스템
- 게임별 독립적인 실행 환경
- 직관적인 UI/UX
- 게임별 난이도 조절
- 실시간 점수 시스템

## 👥 개발팀 소개
| 이름 | 담당 | 역할 |
|------|------|------|
| 정익상 | 오목 | AI 구현 및 게임 로직 개발 |
| 양우혁 | 틱택톡 | 게임 로직 및 UI 개발 |
| 김수호 | 테트리스 | 블록 시스템 구현 |
| 최이지 | 블랙잭 | 카드 게임 로직 구현 |
| 조효민 | 기억력 게임 | 매칭 시스템 개발 |

## 💡 프로젝트 특징
- **모듈화된 설계:** 각 게임이 독립적으로 동작하면서도 하나의 통합된 시스템으로 운영
- **사용자 경험 중심:** 직관적인 UI와 부드러운 게임 진행
- **확장 가능한 구조:** 새로운 게임 추가가 용이한 구조 설계
- **성능 최적화:** 효율적인 리소스 관리로 쾌적한 게임 환경 제공

## 📱 스크린샷
[스크린샷 이미지들 추가 예정]

## 🔍 실행 방법
1. 프로젝트 클론
```bash
git clone [repository URL]
```
2. Visual Studio에서 프로젝트 열기
3. 프로젝트 빌드 및 실행

## ⚙️ 개발 환경 설정
- Windows 10 이상
- Visual Studio 2022
- .NET Framework 4.7.2 이상

## 📝 라이선스
This project is licensed under the MIT License - see the LICENSE.md file for details

## 🤝 기여 방법
1. Fork the Project
2. Create your Feature Branch
3. Commit your Changes
4. Push to the Branch
5. Open a Pull Request

---
© 2024 EasyGamePack Team. All Rights Reserved.
