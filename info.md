# Интрукция по работе с GIT
Для того чтобы создать локальный репозиторий, нужно:
> git init

Чтобы начать отслеживать файл с именем file_name, нужно:
> qit add file_name

Для фиксации отслеживаемых айлов нужно написать команду:
> git commit -m "some message"

Отобразить все добавленные комиты:
> git log

Чтобы вернуться к предыдущему комиту с кодом commit_code, можно использовать команду:
> git checkout commit_code

и чтобы вернуться к предыдущему состоянию:
> git checkout master

Для просмотра разницы между зафиксированными изменениями и текущими, можно использовать:
> git diff

Чтобы посмотреть все ветки в текущем репозитории, нужно:

> git branch

Для перехода к ветке с именем branch_name:

> git checkout branch_name

Чтобы создать и сразу перейти к созданной ветке:

> git checkout -b branch_name

Для создания ветки с именем branch_name:

> git baranch branch_name

Для совмещения веток используют:
> git merge branch_name

информация из branch_name передастся в текущую ветку

Чтобы удалить ветку:

> git branch -d branch_name

в это случае гит проверит на то есть ли там не замердженная информация

Если хотим удалить не проверяя ничего:

> git branch -D branch_name

Можно посмотреть состояние сляний веток добавив к коменде log тег --graph:

> git log --graph

![some pic](/image/HTML5_Logo.jpg)