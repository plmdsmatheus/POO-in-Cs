class Energia:
  def __init__(self, mes, ano, valor):
    self.__mes = mes
    self.__ano = ano
    self.__valor = valor
  def get_ano(self):
    return self.__ano
  def get_mes(self):
    return self.__mes
  def get_valor(self):
    return self.__valor
  def set_ano(self, ano):
    if ano > 0:
      self.__ano = ano
  def set_mes(self, mes):
    if 1 <= mes <= 12:
      self.__mes = mes
  def set_valor(self, valor):
    if valor > 0:
      self.__valor = valor
  def __str__(self):
    return f"A conta de energia do mês {self.__mes} do ano {self.__ano} é de valor: {self.__valor}"


if __name__ == "__main__":
    e = Energia(11, 2022, 120)
    print(e)
    print(e.get_ano())
    print(e.get_mes())
    print(e.get_valor())
    e.set_ano(2020)
    e.set_mes(20)
    e.set_valor(300)
    print(e)
    print(e.get_ano())
    print(e.get_mes())
    print(e.get_valor())
    