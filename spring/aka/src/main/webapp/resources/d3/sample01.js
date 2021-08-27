var dataSet =  [100,10,120,200,90];

d3.select("#myGraph")
  .selectAll("rect")
  .data(dataSet)
  .enter()
  .append("rect")
  .attr("class","bar")
  .attr("width",function(d,i){
      return d;
  })
  .attr("height",40)
  .attr("x",0)
  .attr("y",function(d,i){
      return i*45;
  })
