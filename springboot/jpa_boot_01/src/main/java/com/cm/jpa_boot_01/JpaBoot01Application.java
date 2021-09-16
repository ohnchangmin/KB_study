package com.cm.jpa_boot_01;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Bean;
import org.springframework.http.HttpMethod;
import org.springframework.web.servlet.config.annotation.CorsRegistry;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurer;

@SpringBootApplication
public class JpaBoot01Application {

	public static void main(String[] args) {
		SpringApplication.run(JpaBoot01Application.class, args);
	}

	@Bean
	public WebMvcConfigurer webMvcConfigurer() {
		return new WebMvcConfigurer() {
			@Override
			public void addCorsMappings(CorsRegistry registry) {
				registry.addMapping("/board/**")
						.allowedOrigins("*")
						.allowedMethods("*")
						.allowCredentials(false)
						.maxAge(3600);
			}
		};
	}
}
