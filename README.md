# Автоматизированной информационной системы “Учёта и контроля инвентаризации”
### Описание приложения:
**Данное приложение - это система для учёта и контроля инвентаризации, с возможностью отображения ФИО, инвентарного номера, типом, стоимостью оборудования и местом расположения. А также сортировкой и поиском оборудования с учётом подстроки с простым, но понятным для работы, чтобы было удобно работать даже новичку.

# В приложении имеются следующие страницы:
1. **Главный экран (MainWindow)** - на нем содержатся кнопки для перехода упраления данных путём сортировки, поиска, добавления и изменения с удалением.

# Описание функций приложения:
1. **Сортировка.** Отображает данные, а также раскрывающийся список, который позволяет выбрать тип сортировки. 
2. **Посик с учётом подстроки.** Дано поле поиска с розыском данных набранного текста.
3. **Добавление.** Указан перечень данных с окнами для заполнения данных.
4. **Удаление.** Список данных с функцией двойного щелчка по строке и отображение предупреждения об удалении. После подтверждения следует переход на главный экран. Если снова зайти по кнопке “Изменить/Удалить”, стертых данных не обнаружится.
5. **Изменение данных.** Список данных с кнопкной “Изменить”, где можно скорректировать по всем пунктам информацию.

# Технологии, которые были использованы во время разработки приложения:
- **Язык программирования C#** - использован для создания всей логики приложения.
- **Фреймворк Windows Presentation Foundation (WPF)** - использован для создания интерфейса приложения.
- **Microsoft SQL Server Management Studio 18** - работа с БД (Создание БД, создание таблицы и заполнение её данными).

# Описание базы данных:
### Файл базы данных называется projectSonya.pdb <br/>
Файл базы данных расположен локально в проекте по пути **projectSonya\bin\Debug** </br>
В базе данных имеется таблица «Info», в которой содержатся колонки id, name, number, type, price, location. Содержит информацию о темах. <br/>

# Скриншоты приложения:
## Главная страница
https://drive.google.com/file/d/1suxp4QfaR34L5SynVXY3qQa9QtEibxtR/view
</br> </br> </br>

## Отображение данных
https://drive.google.com/drive/folders/1IfEgyaaxbNYR23ROOsRZV7IH2cskXwu4
</br> </br> </br>

![Сортировка]([https://drive.google.com/file/d/1CJFFic5l359Ae61CZFpz3-PlCElVGIum/view))
## Сортировка </br>
</br> </br> </br>

![Поиск](https://drive.google.com/file/d/13AI5IkjNb-QPivvbVgxi7mOa355Dz94m/view)
## Поиск </br>
</br> </br> </br>

![Добавление](https://drive.google.com/file/d/1q37igLcnIvzZovU7XmC_r0IzQYqpNvpY/view)
## Добавление </br>
</br> </br> </br>

![Удаление](https://drive.google.com/file/d/1YgminQ--cn6fhjDqyHs6YEfqdJi6J2Bq/view)
## Удаление </br>
</br> </br> </br>

![Изменение](https://drive.google.com/file/d/1xj2Bl_HtWjJJD-Ta2ESW7yolFDS_chom/view)
## Изменение </br>
</br> </br> </br>
